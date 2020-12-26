using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniOS_Simulator
{
    public partial class frm_sim : Form
    {

        int globalClock = 0;
        int pCount = 0;
        int pInSystem = 0;
        int trkSpd = 0;

        Random r = new Random();
        bool paused = false;
        BackgroundWorker bw = new BackgroundWorker();

        int maxProcesses = 20;
        int probCreation;
        int quantum;
        int duration;
        int probPrinterUse;
        int probChange;
        int probPrinterUsingTime;
        int ramSize = 0;
        int frameSize = 0;
        int numFrames = 0;
        int maxProgramSize = 0;
        int memoryOS = 0;

        List<Process> processesInSystem = new List<Process>();       
        List<Process> newListP = new List<Process>();
        List<Process> readyListP = new List<Process>();
        List<Process> waitingDiskList = new List<Process>();
        List<Process> waitingListP = new List<Process>();
        Process runningP = null;
        Process diskP;
        Process printingP;
        List<Process> terminatedListP = new List<Process>();
        List<Slot> ramSlots = new List<Slot>();
       
        DataTable PCB = new DataTable();
        DataTable TAP = new DataTable();
        DataTable RAM = new DataTable();
        DataTable newListTable = new DataTable();
        DataTable terminatedListTable = new DataTable();
        DataTable readyListTable = new DataTable();
        DataTable waitingListTable = new DataTable();
        DataTable waitingDiskListTable = new DataTable();


        public frm_sim()
        {
            InitializeComponent();
            createTables();
            bw.DoWork += bw_doWork;
           // bw.ProgressChanged += bw_progressChanged;
            //bw.WorkerReportsProgress = true;
            bw.RunWorkerCompleted += bw_RunWorkerCompleted;
            probCreation = trk_creation.Value;
            quantum = trk_quantum.Value;
            duration = trk_duration.Value;
            probPrinterUse = trk_printerUse.Value;
            probPrinterUsingTime = trk_printerUsingTime.Value;
            
        }

        public void createTables()
        {
            PCB.Columns.Add("ID").ReadOnly=true;
            PCB.Columns.Add("Arrival time").ReadOnly = true;
            PCB.Columns.Add("Duration").ReadOnly = true;
            PCB.Columns.Add("Progress").ReadOnly = true;
            PCB.Columns.Add("Printer?").ReadOnly = true;
            PCB.Columns.Add("Need printer at").ReadOnly = true;
            PCB.Columns.Add("Printer usage").ReadOnly = true;
            PCB.Columns.Add("Program Size").ReadOnly = true;
            dgr_pcb.DataSource = PCB;

            TAP.Columns.Add("ID").ReadOnly = true;
            TAP.Columns.Add("Page A").ReadOnly = true;
            TAP.Columns.Add("Page B").ReadOnly = true;
            TAP.Columns.Add("Page C").ReadOnly = true;
            TAP.Columns.Add("Page D").ReadOnly = true;
            TAP.Columns.Add("Page E").ReadOnly = true;
            TAP.Columns.Add("Page F").ReadOnly = true;
            dgr_TAP.DataSource = TAP;

            RAM.Columns.Add("Frames");
            dgr_RAM.DataSource = RAM;

            terminatedListTable.Columns.Add("Process ID").ReadOnly = true;
            terminatedListTable.Columns.Add("Overall time").ReadOnly = true;
            terminatedListTable.Columns.Add("Working time").ReadOnly = true;
            terminatedListTable.Columns.Add("Idle time").ReadOnly = true;
            terminatedListTable.Columns.Add("Performance").ReadOnly = true;
            dgr_terminated.DataSource = terminatedListTable;

            newListTable.Columns.Add("Process ID").ReadOnly = true;
            dgr_new.DataSource = newListTable;

            readyListTable.Columns.Add("Process ID").ReadOnly = true;
            dgr_ready.DataSource = readyListTable;

            waitingListTable.Columns.Add("Process ID").ReadOnly = true;
            dgr_waiting.DataSource = waitingListTable;

            waitingDiskListTable.Columns.Add("Process ID").ReadOnly = true;
            dgr_waitingDisk.DataSource = waitingDiskListTable;

        }

        private void frm_sim_Paint(object sender, PaintEventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics();

            //new to rdy
            formGraphics.DrawLine(System.Drawing.Pens.Black, new Point(210, 282), new Point(280, 282));
            formGraphics.DrawLine(System.Drawing.Pens.Black, new Point(170, 282), new Point(280, 282));

            //rdy to running
            formGraphics.DrawLine(System.Drawing.Pens.Black, new Point(424, 282), new Point(534, 282));
            formGraphics.DrawEllipse(System.Drawing.Pens.Black, new Rectangle(535, 220, 120, 120));
            formGraphics.DrawString("Running", new Font("Arial", 15), System.Drawing.Brushes.Black, new Point(557, 268));

            //running to terminated + running to waiting and waiting to print
            //running to terminated
            formGraphics.DrawLine(System.Drawing.Pens.Black, new Point(710, 282), new Point(710, 150));
            formGraphics.DrawLine(System.Drawing.Pens.Black, new Point(710, 150), new Point(1200, 150));
            formGraphics.DrawLine(System.Drawing.Pens.Black, new Point(655, 282), new Point(850, 282));
            //waiting to print
            formGraphics.DrawLine(System.Drawing.Pens.Black, new Point(765, 479), new Point(655, 479));
            //print to ready
            formGraphics.DrawLine(System.Drawing.Pens.Black, new Point(400, 479), new Point(535, 479));
            formGraphics.DrawEllipse(System.Drawing.Pens.Black, new Rectangle(535, 415, 120, 120));           
            formGraphics.DrawString("Printing", new Font("Arial", 15), System.Drawing.Brushes.Black, new Point(559, 465));
            //running to waiting disk
            formGraphics.DrawLine(System.Drawing.Pens.Black, new Point(595, 220), new Point(595, 80));
            //waiting disk to using and ready
            formGraphics.DrawLine(System.Drawing.Pens.Black, new Point(410, 120), new Point(534, 120));
            formGraphics.DrawEllipse(System.Drawing.Pens.Black, new Rectangle(290, 60, 120, 120));
            formGraphics.DrawString("Disk", new Font("Arial", 15), System.Drawing.Brushes.Black, new Point(327, 110));
            formGraphics.DrawLine(System.Drawing.Pens.Black, new Point(350, 180), new Point(350, 212));
            //running to ready
            formGraphics.DrawLine(System.Drawing.Pens.Black, new Point(400, 360), new Point(595, 360));
            formGraphics.DrawLine(System.Drawing.Pens.Black, new Point(595, 340), new Point(595, 360));


        }     

        private void generateProcess()
        {
            Process p;
            int random = r.Next(1, 101);
            if (random <= probPrinterUse)
            {
                random = r.Next(5, duration);
                //calculate the program size
                int size = 0;
                size = r.Next(0, maxProgramSize);

                p = new Process(pCount, globalClock, random, true, r.Next(1, random - 1), r.Next(5, probPrinterUsingTime), size);
                //assign pages to disk
                int numPages = (int)Math.Ceiling(((double)size / (double)frameSize));
                p.setNumPages(numPages);
                for(int i = 0; i < numPages; i++)
                {
                    p.setPages(i, "D");
                }
                processesInSystem.Add(p);
            }
            else
            {
                //calculate the program size
                int size = 0;
                size = r.Next(0, maxProgramSize);

                p = new Process(pCount, globalClock, r.Next(5, duration), false, -1, -1, size);
                //assign pages to disk
                int numPages = (int)Math.Ceiling(((double)size / (double)frameSize));
                for (int i = 0; i < numPages; i++)
                {
                    p.setPages(i, "D");
                }
                processesInSystem.Add(p);
            }
            newListP.Add(p);
            pCount++;
            pInSystem++;
        }

        private void updatePCB()
        {
            PCB.Clear();          
            foreach (Process p in processesInSystem) {
                DataRow row = PCB.NewRow();
                row["ID"] = p.getID();
                row["Arrival time"] = p.getArrivalTime();
                row["Duration"] = p.getDuration();
                row["Progress"] = p.getProgress();
                row["Printer?"] = p.getPrinterUse();
                row["Need printer at"] = p.getNeedPrinterAt();
                row["Printer usage"] = p.getTotalPrintingTime();
                row["Program Size"] = p.getProgramSize() + " Kb";
                PCB.Rows.Add(row);
            }
        }

        private void updateTAP()
        {
            TAP.Clear();
            foreach (Process p in processesInSystem)
            {
                if(p.getTerminated() == false)
                {
                    DataRow row = TAP.NewRow();
                    row["ID"] = p.getID();
                    row["Page A"] = p.getPage(0) + " (Usage: " + p.getPageObj(0).getAllocationCount() +")";
                    row["Page B"] = p.getPage(1) + " (Usage: " + p.getPageObj(1).getAllocationCount() + ")";
                    row["Page C"] = p.getPage(2) + " (Usage: " + p.getPageObj(2).getAllocationCount() + ")";
                    row["Page D"] = p.getPage(3) + " (Usage: " + p.getPageObj(3).getAllocationCount() + ")";
                    row["Page E"] = p.getPage(4) + " (Usage: " + p.getPageObj(4).getAllocationCount() + ")";
                    row["Page F"] = p.getPage(5) + " (Usage: " + p.getPageObj(5).getAllocationCount() + ")";
                    TAP.Rows.Add(row);                 
                }
                visualizeTAP();
            }
        }

        private void visualizeTAP()
        {
            foreach (DataGridViewRow dr in dgr_TAP.Rows)
            {
                if (dr.Cells[0].Value != null)
                {
                    int processId = Int32.Parse(dr.Cells[0].Value.ToString());

                    Process p = processesInSystem[processId];

                    foreach (DataGridViewCell cell in dr.Cells)
                    {
                        if (cell.Value != null )
                        {
                            String t = cell.Value.ToString();
                            if (t.Contains("X"))
                            {
                                cell.Style.BackColor = Color.Black;

                            }
                        }
                    }

                    dr.Cells[p.getNextSwapPage() + 1].Style.BackColor = Color.LightYellow;
                }
            }
        }

        private void initRam()
        {

            if (processesInSystem.Count == 0)
            {
                ramSlots.Clear();
                for (int i = 0; i < numFrames; i++)
                {
                    ramSlots.Add(new Slot("Empty Slot " + i, globalClock));
                }
                memoryOS = (int)Math.Ceiling(((double)numFrames * .25));
                for (int i = 0; i < memoryOS; i++)
                {
                    ramSlots[i] = new Slot("OS", globalClock);
                }
            }
        }

        private void updateRAM()
        {

            RAM.Clear();
            foreach (Slot slot in ramSlots)
            {
                DataRow dr = RAM.NewRow();
                dr[0] = slot.getValue();
                RAM.Rows.Add(dr);
            }
            pageVisualization();
        }

        void pageVisualization()
        {
            
            foreach (DataGridViewRow dr in dgr_RAM.Rows)
            {
                
                if (dr.Cells[0].Value != null && dr.Cells[0].Value.ToString().Contains("OS"))
                {
                    dr.DefaultCellStyle.BackColor = Color.LightBlue;
                } else if (dr.Cells[0].Value != null && runningP != null
                    && dr.Cells[0].Value.ToString().Contains(runningP.getID().ToString())
                    && dr.Cells[0].Value.ToString().Contains(Convert.ToChar(65 + runningP.getCurrPage()).ToString()))
                {
                    dr.DefaultCellStyle.BackColor = Color.LightGreen;
                } else
                {
                    dr.DefaultCellStyle.BackColor = Color.LightPink;
                }

                //the one running
            }
        }

        private void paint()
        {
            lbl_worldClock.Text = "Clock: " + globalClock.ToString();
            List<Process> tempNew = newListP.ToList();
            List<Process> tempReady = readyListP.ToList();
            List<Process> tempWaiting = waitingListP.ToList();
            List<Process> tempTerminated = terminatedListP.ToList();
            List<Process> tempDisk = waitingDiskList.ToList();

            //newListP
            newListTable.Clear();
            if (tempNew.Count() > 0)
            {
                foreach (Process p in tempNew)
                {
                    DataRow row = newListTable.NewRow();
                    row["Process ID"] = p.getID();
                    newListTable.Rows.Add(row);
                }
            }

            //readyListP
            readyListTable.Clear();
            
            if (tempReady.Count() > 0)
            {
                foreach(Process p in tempReady)
                {
                    DataRow row = readyListTable.NewRow();
                    row["Process ID"] = p.getID();
                    readyListTable.Rows.Add(row);
                }
            }

            //runningP
            if (runningP != null)
            {
                lbl_running.Text = "P" + runningP.getID();

            }
            else
            {
                lbl_running.Text = "None";
            }

            //waiting disk
            waitingDiskListTable.Clear();
            if (tempDisk.Count() > 0)
            {
                foreach (Process p in tempDisk)
                {
                    DataRow row = waitingDiskListTable.NewRow();
                    row["Process ID"] = p.getID();
                    waitingDiskListTable.Rows.Add(row);
                }
            }

            //disk
            if (diskP != null)
            {
                lbl_disk.Text = "P" + diskP.getID();

            }
            else
            {
                lbl_disk.Text = "None";
            }

            //waitingListP
            waitingListTable.Clear();
            if (tempWaiting.Count() > 0)
            {
                foreach (Process p in tempWaiting)
                {
                    DataRow row = waitingListTable.NewRow();
                    row["Process ID"] = p.getID();
                    waitingListTable.Rows.Add(row);
                }
            }

            //printingP
            if (printingP != null)
            {
                lbl_printing.Text = "P" + printingP.getID();

            }
            else
            {
                lbl_printing.Text = "None";
            }

            //terminatedListP
            terminatedListTable.Clear();
            if (tempTerminated.Count() > 0)
            {
                foreach (Process p in tempTerminated)
                {
                    DataRow row = terminatedListTable.NewRow();
                    row["Process ID"] = p.getID();
                    row["Overall time"] = p.getTimeInSystem();
                    row["Working time"] = p.getWorkingTime();
                    row["Idle time"] = p.getIdleTime();
                    row["Performance"] = p.getPerformance(globalClock);
                    terminatedListTable.Rows.Add(row);
                }               
            }
            updatePCB();
            updateTAP();
            updateRAM();
        }

        private void wipeUniverse()
        {
            PCB.Clear();
            ramSlots.Clear();
            RAM.Clear();           
            terminatedListTable.Clear();
            readyListTable.Clear();
            waitingListTable.Clear();
            newListP.Clear();
            runningP = null;
            printingP = null;
            diskP = null;
            readyListP.Clear();
            waitingListP.Clear();
            terminatedListP.Clear();
            processesInSystem.Clear();
            waitingDiskList.Clear();
            lbl_worldClock.Text = "Clock: ";
            globalClock = 0;
            pCount = 0;
            pInSystem = 0;
            paint();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            ramSize = int.Parse(cbx_RAM.SelectedItem.ToString());
            frameSize = int.Parse(cbx_frame.SelectedItem.ToString());
            maxProgramSize = frameSize * 6;
            numFrames = ramSize / frameSize;
            btn_play.Enabled = false;
            trk_page.Enabled = false;
            trk_creation.Enabled = false;
            trk_duration.Enabled = false;
            trk_printerUse.Enabled = false;
            trk_printerUsingTime.Enabled = false;
            trk_quantum.Enabled = false;
            trk_speed.Enabled = false;
            trk_totalProcesses.Enabled = false;

            //change values based on trk.Value
            probChange = trk_page.Value;
            probCreation = trk_creation.Value;
            quantum = trk_quantum.Value;
            duration = trk_duration.Value;
            probPrinterUse = trk_printerUse.Value;
            probPrinterUsingTime = trk_printerUsingTime.Value;
            maxProcesses = trk_totalProcesses.Value;
            ramSize = int.Parse(cbx_RAM.SelectedItem.ToString());
            frameSize = int.Parse(cbx_frame.SelectedItem.ToString());
            maxProgramSize = frameSize * 6;
            trkSpd = trk_speed.Value;
            paused = false;
            initRam();
            tick();
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            paused = true;
            trk_page.Enabled = true;
            btn_play.Enabled = true;
            trk_creation.Enabled = true;
            trk_duration.Enabled = true;
            trk_printerUse.Enabled = true;
            trk_printerUsingTime.Enabled = true;
            trk_quantum.Enabled = true;
            trk_speed.Enabled = true;
            trk_totalProcesses.Enabled = true;
            cbx_frame.Enabled = false;
            cbx_RAM.Enabled = false;
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            paused = true;
            wipeUniverse();
            btn_play.Enabled = true;
            btn_play.Enabled = true;
            trk_creation.Enabled = true;
            trk_duration.Enabled = true;
            trk_printerUse.Enabled = true;
            trk_printerUsingTime.Enabled = true;
            trk_quantum.Enabled = true;
            trk_speed.Enabled = true;
            trk_totalProcesses.Enabled = true;
            cbx_frame.Enabled = true;
            cbx_RAM.Enabled = true;
        }

        private void tick()
        {
            bw.RunWorkerAsync();
        }

        private void bw_doWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if(trkSpd == 1)
            {
                Thread.Sleep(2000);
            }else if(trkSpd == 2)
            {
                Thread.Sleep(1000);
            }
            else if (trkSpd == 3)
            {
                Thread.Sleep(500);
            }
            else
            {
                Thread.Sleep(100);
            }
            
            if (printingP != null)
            {
                //if currPrintingTime == totalPrintingTime
                if (printingP.getCurrPrintingTime() == printingP.getTotalPrintingTime())
                {
                    //MOV printingP -> readyListP
                    //REMOVE printingP
                    printingP.setPrintingDone(true);
                    readyListP.Add(printingP);
                    printingP = null;
                }
                else
                {
                    printingP.increaseCurrPrintingTime();
                }
            }

            if (waitingListP.Count() > 0 && printingP == null)
            {
                //MOV waitingListP[0] -> printingP
                //REMOVE waitingListP[0]
                printingP = waitingListP.ElementAt(0);
                waitingListP.RemoveAt(0);
            }


            if (diskP != null)
            {
                //if getTimeInDisk == 3
                if (diskP.getTimeInDisk() == 3)
                {
                    //MOV diskP -> readyListP
                    //REMOVE diskP
                    //find next empty
                    int nextRamEmpty = 0;
                    for (int j = memoryOS; j < ramSlots.Count; j++)
                    {
                        if (ramSlots[j].getValue().Contains("Empty"))
                        {
                            nextRamEmpty = j;
                            break;
                        }
                    }

                    if (nextRamEmpty == 0)
                    {
                        //full
                        //oldest
                        int oldestVal = ramSlots[memoryOS].getArrivalTime();
                        int oldestIdx = memoryOS;
                        for(int f = memoryOS + 1; f < ramSlots.Count; f++)
                        {
                            if (ramSlots[f].getArrivalTime() < oldestVal)
                            {
                                oldestVal = ramSlots[f].getArrivalTime();
                                oldestIdx = f;
                            }
                        }

                        //replace
                        //move page to swap
                        Slot s = ramSlots[oldestIdx];
                        processesInSystem[s.getProcessIdx()].setPages(s.getPageIdx(), "S");

                        //switch slot to use new page
                        int i = diskP.memAlloc(oldestIdx);
                        
                        ramSlots[oldestIdx].setValue("P" + diskP.getID() + " - Page " + Convert.ToChar(65 + i).ToString());
                        ramSlots[oldestIdx].setArrivalTime(globalClock);
                        ramSlots[oldestIdx].setProcessIdx(diskP.getID());
                        ramSlots[oldestIdx].setPageIdx(i);
                        ramSlots[oldestIdx].resetUsageTime();
                        
                        readyListP.Add(diskP);
                        diskP = null;

                    } else
                    {
                        //memAlloc to next empty
                        int i = diskP.memAlloc(nextRamEmpty);

                        ramSlots[nextRamEmpty].setValue("P" + diskP.getID() + " - Page " + Convert.ToChar(65 + i).ToString());
                        ramSlots[nextRamEmpty].setArrivalTime(globalClock);
                        ramSlots[nextRamEmpty].setProcessIdx(diskP.getID());
                        ramSlots[nextRamEmpty].setPageIdx(i);
                        ramSlots[nextRamEmpty].resetUsageTime();

                        readyListP.Add(diskP);
                        diskP = null;
                    }
                }
                else
                {
                    diskP.increaseTimeInDisk();
                }
            }

            if (waitingDiskList.Count() > 0 && diskP == null)
            {
                //MOV waitingDiskList[0] -> diskP
                //REMOVE waitingDiskList[0]
                diskP = waitingDiskList.ElementAt(0);
                waitingDiskList.RemoveAt(0);
            }


            if (runningP != null)
            {
                Random r = new Random();
                //check if a page is in memory. IF not, then send to waiting disk
                if (!runningP.hasPageInMemory())
                {
                    if (runningP.getNumPages() > 1)
                    {
                        //swap
                        int res = r.Next(0, runningP.getNumPages());
                        runningP.setNextSwapPage(res);
                    }
                    //MOV running -> waiting DISK
                    waitingDiskList.Add(runningP);
                    runningP = null;
                    moveNewToReady();

                }
                else if (runningP.getNumPages() >  1 && r.Next(1,101) > probChange)
                {
                    //swap
                    int res = r.Next(0, runningP.getNumPages());
                    runningP.setNextSwapPage(res);
                    //MOV running -> waiting DISK
                    waitingDiskList.Add(runningP);
                    runningP = null;
                    moveNewToReady();
                }
                //if currProgress == timeToPrinter
                else if (runningP.getProgress() == runningP.getNeedPrinterAt() && runningP.getPrintingDone() == false)
                {
                    //MOV running -> waiting
                    waitingListP.Add(runningP);
                    runningP = null;
                    moveNewToReady();
                }
                //if currProgress == duration
                else if (runningP.getProgress() == runningP.getDuration())
                {
                    //MOV running -> terminated
                    runningP.setTimeInSystem(globalClock);
                    runningP.setTerminated(true);
                    terminatedListP.Add(runningP);
                    runningP = null;
                    moveNewToReady();
                    pInSystem--;
                }
                //runningP if currQuantum == quantum
                else if (runningP.getCurrQuantum() == quantum)
                {
                    //MOV running -> ready
                    readyListP.Add(runningP);
                    runningP.resetCurrQuantum();
                    runningP = null;
                    moveNewToReady();
                }
                else
                {
                    //runningP increase progress
                    runningP.increaseProgress();
                }
            }

            // move ready to running
            if (readyListP.Count() > 0 && runningP == null)
            {
                //move
                runningP = readyListP.ElementAt(0);
                readyListP.RemoveAt(0);
            }
            
            //Move new to ready
            if (runningP == null && newListP.Count > 0)
            {
                //move
                moveNewToReady();
            }

            //Chance to generate process
            if (pInSystem < maxProcesses)
            {
                int random = r.Next(1, 101);
                if (random <= probCreation)
                {
                    generateProcess();
                }
            }

            //increase idle time
            foreach (Process p in readyListP)
            {
                p.increaseIdleTime();
            }

            foreach (Process p in waitingListP)
            {
                p.increaseIdleTime();
            }

            foreach(Slot s in ramSlots)
            {
                if (!s.getValue().Contains("Empty") && !s.getValue().Contains("OS"))
                {
                    s.increaseUsageTime();
                }
            }

            globalClock++;
        }

        void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //UI update
            paint();
            //System.Threading.Thread.Sleep(10000);
            Update();
            Application.DoEvents();
            if (!paused)
                tick();
        }

        public void moveNewToReady()
        {         
            for(int i = 0; i < newListP.Count; i++)
            {
                readyListP.Add(newListP[i]);
                
            }
            newListP.Clear();
        }

        private void trk_creation_ValueChanged(object sender, EventArgs e)
        {
            lbl_creationProb.Text = "Creation Probability: " + ((TrackBar) sender).Value;
        }

        private void trk_quantum_ValueChanged(object sender, EventArgs e)
        {
            lbl_quantum.Text = "Quantum: " + ((TrackBar)sender).Value;
        }

        private void trk_duration_ValueChanged(object sender, EventArgs e)
        {
            lbl_processD.Text = "Process Duration: " + ((TrackBar)sender).Value;
        }

        private void trk_printerUse_ValueChanged(object sender, EventArgs e)
        {
            lbl_printerUse.Text = "Printer Use Probability: " + ((TrackBar)sender).Value;
        }

        private void trk_printerUsingTime_ValueChanged(object sender, EventArgs e)
        {
            lbl_printingTime.Text = "Printing Time: " + ((TrackBar)sender).Value;
        }

        private void trk_totalProcesses_ValueChanged(object sender, EventArgs e)
        {
            lbl_totalPro.Text = "Total Processes: " + ((TrackBar)sender).Value;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help h1 = new Help();
            h1.Show();
        }

        private void trk_page_ValueChanged(object sender, EventArgs e)
        {
            lbl_pageProb.Text = "Page Change Probability: " + ((TrackBar)sender).Value;
        }
    }
}
