using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniOS_Simulator
{
    public class Process
    {
        private int ID = 0;
        private int arrivalTime = 0;
        private int duration = 0;
        private int progress = 0;
        private bool printerUse = false;
        private int NeedPrinterAt = 0;
        private int totalPrintingTime = 0;
        private int idleTime = 0;
        private int currQuantum = 0;
        private int currPrintingTime = 0;
        private bool printingDone = false;
        private int timeInSystem = 0;
        private int programSize = 0;
        private int currDiskTime = 0;
        private bool firstMemAlloc = true;
        private List<Page> pages = new List<Page> {new Page(), new Page(), new Page(), new Page(), new Page(), new Page()};
        private int numPages = 0;
        private int nextSwapPage = 0;
        private int currPage = 0;
        private bool terminated = false;
        //private List<int> swapCount = new List<int> { 0, 0, 0, 0, 0, 0 };


        public Process(int ID, int arrivalTime, int duration, bool printerUse, int NeedPrinterAt, int printerUsingTime, int programSize)
        {
            this.ID = ID;
            this.arrivalTime = arrivalTime;
            this.duration = duration;
            this.printerUse = printerUse;
            this.NeedPrinterAt = NeedPrinterAt;
            this.totalPrintingTime = printerUsingTime;
            this.programSize = programSize;
        }

        public int getID()
        {
            return ID;
        }

        public int getArrivalTime()
        {
            return arrivalTime;
        }

        public int getProgress()
        {
            return progress;
        }

        public int getDuration()
        {
            return duration;
        }

        public bool getPrinterUse()
        {
            return printerUse;
        }

        public int getNeedPrinterAt()
        {
            return NeedPrinterAt;
        }

        public int getTotalPrintingTime()
        {
            return totalPrintingTime;
        }

        public void setTimeInSystem(int overallTime)
        {
            timeInSystem = overallTime;
        }

        public int getTimeInSystem()
        {
            return timeInSystem;
        }

        public int getWorkingTime()
        {
            if(totalPrintingTime == -1)
            {
                return duration;
            }
            return totalPrintingTime + duration;
        }

        public string getPerformance(int worldClock)
        {
            float workingTime = getWorkingTime();
            float timeInSystem = getTimeInSystem();
            float finalResult = (workingTime / timeInSystem) * 100;         
            return finalResult.ToString("0.##");
        }

        public int getCurrPrintingTime()
        {
            return currPrintingTime;
        }
        
        public void increaseCurrPrintingTime()
        {
            currPrintingTime++;
        }

        public void increaseIdleTime()
        {
            idleTime++;
        }

        public int getIdleTime()
        {
            return idleTime;
        }

        public void increaseProgress()
        {
            progress++;
            currQuantum++;
        }

        public int getCurrQuantum()
        {
            return currQuantum;
        }
        
        public void resetCurrQuantum()
        {
            currQuantum = 0;
        }

        public bool getPrintingDone()
        {
            return printingDone;
        }

        public void setPrintingDone(bool pdone)
        {
            printingDone = pdone;
        }

        public void setProgramSize(int programSize)
        {
            this.programSize = programSize;
        }

        public int getProgramSize()
        {
            return programSize;
        }

        public void setPages(int index, string page)
        {
            this.pages[index].setValue(page);
        }

        public string getPage(int index)
        {
            return pages[index].getValue();
        }

        public Page getPageObj(int index)
        {
            return pages[index];
        }

        public void setNumPages(int pages)
        {
            numPages = pages;
        }

        public int getNumPages()
        {
            return numPages;
        }

        public void setNextSwapPage(int i)
        {
            nextSwapPage = i;
        }

        public bool hasPageInMemory()
        {
            foreach (Page p in pages)
            {
                if (p.getValue().Contains("M"))
                {
                    return true;
                }
            }
            return false;
        }

        public int getTimeInDisk()
        {
            return currDiskTime;
        }

        public void increaseTimeInDisk()
        {
            currDiskTime++;
        }

        public int getCurrPage()
        {
            return currPage;
        }

        public int memAlloc(int nextRamEmpty)
        {
            currDiskTime = 0;
            if (firstMemAlloc)
            {
                firstMemAlloc = false;
                setPages(0, "M-" + nextRamEmpty);
                currPage = 0;
                pages[0].increaseAllocationCount();
                return 0;
            } else
            {
                //10 = A, 11 = B [...]
                setPages(nextSwapPage, "M-" + nextRamEmpty);
                currPage = nextSwapPage;
                pages[nextSwapPage].increaseAllocationCount();
                return nextSwapPage;
            }
        }

        public void setTerminated(bool finished)
        {
            terminated = finished;
        }

        public bool getTerminated()
        {
            return terminated;
        }

        public int getNextSwapPage()
        {
            return nextSwapPage;
        }
    }
}
