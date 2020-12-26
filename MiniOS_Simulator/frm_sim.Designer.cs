namespace MiniOS_Simulator
{
    partial class frm_sim
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_sim));
            this.dgr_terminated = new System.Windows.Forms.DataGridView();
            this.dgr_pcb = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgr_ready = new System.Windows.Forms.DataGridView();
            this.dgr_waiting = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_running = new System.Windows.Forms.Label();
            this.lbl_printing = new System.Windows.Forms.Label();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbl_worldClock = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgr_new = new System.Windows.Forms.DataGridView();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.dgr_TAP = new System.Windows.Forms.DataGridView();
            this.label23 = new System.Windows.Forms.Label();
            this.dgr_RAM = new System.Windows.Forms.DataGridView();
            this.label24 = new System.Windows.Forms.Label();
            this.dgr_waitingDisk = new System.Windows.Forms.DataGridView();
            this.cbx_RAM = new System.Windows.Forms.ComboBox();
            this.lbl_disk = new System.Windows.Forms.Label();
            this.lbl_ram = new System.Windows.Forms.Label();
            this.lbl_frame = new System.Windows.Forms.Label();
            this.cbx_frame = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_pageProb = new System.Windows.Forms.Label();
            this.trk_page = new System.Windows.Forms.TrackBar();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.trk_totalProcesses = new System.Windows.Forms.TrackBar();
            this.trk_creation = new System.Windows.Forms.TrackBar();
            this.trk_quantum = new System.Windows.Forms.TrackBar();
            this.trk_duration = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_creationProb = new System.Windows.Forms.Label();
            this.lbl_quantum = new System.Windows.Forms.Label();
            this.lbl_processD = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.trk_printerUsingTime = new System.Windows.Forms.TrackBar();
            this.label19 = new System.Windows.Forms.Label();
            this.trk_printerUse = new System.Windows.Forms.TrackBar();
            this.label20 = new System.Windows.Forms.Label();
            this.lbl_printerUse = new System.Windows.Forms.Label();
            this.lbl_totalPro = new System.Windows.Forms.Label();
            this.lbl_printingTime = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.trk_speed = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_terminated)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_pcb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_ready)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_waiting)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_new)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_TAP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_RAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_waitingDisk)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trk_page)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_totalProcesses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_creation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_quantum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_duration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_printerUsingTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_printerUse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_speed)).BeginInit();
            this.SuspendLayout();
            // 
            // dgr_terminated
            // 
            this.dgr_terminated.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgr_terminated.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_terminated.Location = new System.Drawing.Point(1124, 113);
            this.dgr_terminated.Name = "dgr_terminated";
            this.dgr_terminated.Size = new System.Drawing.Size(472, 437);
            this.dgr_terminated.TabIndex = 0;
            // 
            // dgr_pcb
            // 
            this.dgr_pcb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_pcb.Location = new System.Drawing.Point(11, 575);
            this.dgr_pcb.Name = "dgr_pcb";
            this.dgr_pcb.Size = new System.Drawing.Size(846, 191);
            this.dgr_pcb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1120, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Terminated";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 552);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "PCB";
            // 
            // dgr_ready
            // 
            this.dgr_ready.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_ready.Location = new System.Drawing.Point(279, 213);
            this.dgr_ready.Name = "dgr_ready";
            this.dgr_ready.Size = new System.Drawing.Size(144, 337);
            this.dgr_ready.TabIndex = 4;
            // 
            // dgr_waiting
            // 
            this.dgr_waiting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_waiting.Location = new System.Drawing.Point(764, 213);
            this.dgr_waiting.Name = "dgr_waiting";
            this.dgr_waiting.Size = new System.Drawing.Size(144, 337);
            this.dgr_waiting.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(760, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Waiting I/O";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(275, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ready";
            // 
            // lbl_running
            // 
            this.lbl_running.AutoSize = true;
            this.lbl_running.Location = new System.Drawing.Point(583, 293);
            this.lbl_running.Name = "lbl_running";
            this.lbl_running.Size = new System.Drawing.Size(33, 13);
            this.lbl_running.TabIndex = 9;
            this.lbl_running.Text = "None";
            // 
            // lbl_printing
            // 
            this.lbl_printing.AutoSize = true;
            this.lbl_printing.Location = new System.Drawing.Point(583, 490);
            this.lbl_printing.Name = "lbl_printing";
            this.lbl_printing.Size = new System.Drawing.Size(33, 13);
            this.lbl_printing.TabIndex = 10;
            this.lbl_printing.Text = "None";
            // 
            // btn_play
            // 
            this.btn_play.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_play.Location = new System.Drawing.Point(908, 871);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(148, 68);
            this.btn_play.TabIndex = 11;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pause.Location = new System.Drawing.Point(1099, 871);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(131, 68);
            this.btn_pause.TabIndex = 12;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stop.Location = new System.Drawing.Point(1275, 871);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(137, 68);
            this.btn_stop.TabIndex = 13;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lbl_worldClock
            // 
            this.lbl_worldClock.AutoSize = true;
            this.lbl_worldClock.Location = new System.Drawing.Point(39, 34);
            this.lbl_worldClock.Name = "lbl_worldClock";
            this.lbl_worldClock.Size = new System.Drawing.Size(37, 13);
            this.lbl_worldClock.TabIndex = 46;
            this.lbl_worldClock.Text = "Clock:";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1608, 24);
            this.menuStrip2.TabIndex = 51;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::MiniOS_Simulator.Properties.Resources.penguin;
            this.pictureBox1.Location = new System.Drawing.Point(57, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 117);
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // dgr_new
            // 
            this.dgr_new.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_new.Location = new System.Drawing.Point(40, 213);
            this.dgr_new.Name = "dgr_new";
            this.dgr_new.Size = new System.Drawing.Size(144, 337);
            this.dgr_new.TabIndex = 58;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(36, 190);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(40, 20);
            this.label21.TabIndex = 59;
            this.label21.Text = "New";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(11, 772);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(39, 20);
            this.label22.TabIndex = 61;
            this.label22.Text = "TAP";
            // 
            // dgr_TAP
            // 
            this.dgr_TAP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_TAP.Location = new System.Drawing.Point(11, 795);
            this.dgr_TAP.Name = "dgr_TAP";
            this.dgr_TAP.Size = new System.Drawing.Size(743, 191);
            this.dgr_TAP.TabIndex = 60;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(943, 192);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(45, 20);
            this.label23.TabIndex = 63;
            this.label23.Text = "RAM";
            // 
            // dgr_RAM
            // 
            this.dgr_RAM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_RAM.Location = new System.Drawing.Point(944, 213);
            this.dgr_RAM.Name = "dgr_RAM";
            this.dgr_RAM.Size = new System.Drawing.Size(145, 337);
            this.dgr_RAM.TabIndex = 62;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(687, 27);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(97, 20);
            this.label24.TabIndex = 65;
            this.label24.Text = "Waiting Disk";
            // 
            // dgr_waitingDisk
            // 
            this.dgr_waitingDisk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_waitingDisk.Location = new System.Drawing.Point(527, 27);
            this.dgr_waitingDisk.Name = "dgr_waitingDisk";
            this.dgr_waitingDisk.Size = new System.Drawing.Size(145, 183);
            this.dgr_waitingDisk.TabIndex = 64;
            // 
            // cbx_RAM
            // 
            this.cbx_RAM.FormattingEnabled = true;
            this.cbx_RAM.Items.AddRange(new object[] {
            "32",
            "64",
            "128",
            "256"});
            this.cbx_RAM.Location = new System.Drawing.Point(23, 35);
            this.cbx_RAM.Name = "cbx_RAM";
            this.cbx_RAM.Size = new System.Drawing.Size(121, 21);
            this.cbx_RAM.TabIndex = 66;
            this.cbx_RAM.Text = "128";
            // 
            // lbl_disk
            // 
            this.lbl_disk.AutoSize = true;
            this.lbl_disk.Location = new System.Drawing.Point(339, 132);
            this.lbl_disk.Name = "lbl_disk";
            this.lbl_disk.Size = new System.Drawing.Size(33, 13);
            this.lbl_disk.TabIndex = 67;
            this.lbl_disk.Text = "None";
            // 
            // lbl_ram
            // 
            this.lbl_ram.AutoSize = true;
            this.lbl_ram.Location = new System.Drawing.Point(46, 19);
            this.lbl_ram.Name = "lbl_ram";
            this.lbl_ram.Size = new System.Drawing.Size(76, 13);
            this.lbl_ram.TabIndex = 68;
            this.lbl_ram.Text = "RAM Size (Kb)";
            // 
            // lbl_frame
            // 
            this.lbl_frame.AutoSize = true;
            this.lbl_frame.Location = new System.Drawing.Point(45, 71);
            this.lbl_frame.Name = "lbl_frame";
            this.lbl_frame.Size = new System.Drawing.Size(81, 13);
            this.lbl_frame.TabIndex = 70;
            this.lbl_frame.Text = "Frame Size (Kb)";
            // 
            // cbx_frame
            // 
            this.cbx_frame.FormattingEnabled = true;
            this.cbx_frame.Items.AddRange(new object[] {
            "4",
            "8",
            "16",
            "32",
            "64"});
            this.cbx_frame.Location = new System.Drawing.Point(23, 87);
            this.cbx_frame.Name = "cbx_frame";
            this.cbx_frame.Size = new System.Drawing.Size(121, 21);
            this.cbx_frame.TabIndex = 69;
            this.cbx_frame.Text = "16";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbx_RAM);
            this.groupBox2.Controls.Add(this.lbl_ram);
            this.groupBox2.Controls.Add(this.cbx_frame);
            this.groupBox2.Controls.Add(this.lbl_frame);
            this.groupBox2.Location = new System.Drawing.Point(1431, 577);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 133);
            this.groupBox2.TabIndex = 74;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Memory Parameters";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_pageProb);
            this.groupBox3.Controls.Add(this.trk_page);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.trk_totalProcesses);
            this.groupBox3.Controls.Add(this.trk_creation);
            this.groupBox3.Controls.Add(this.trk_quantum);
            this.groupBox3.Controls.Add(this.trk_duration);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.lbl_creationProb);
            this.groupBox3.Controls.Add(this.lbl_quantum);
            this.groupBox3.Controls.Add(this.lbl_processD);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.trk_printerUsingTime);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.trk_printerUse);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.lbl_printerUse);
            this.groupBox3.Controls.Add(this.lbl_totalPro);
            this.groupBox3.Controls.Add(this.lbl_printingTime);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.trk_speed);
            this.groupBox3.Location = new System.Drawing.Point(887, 575);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(537, 280);
            this.groupBox3.TabIndex = 75;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Process Parameters";
            // 
            // lbl_pageProb
            // 
            this.lbl_pageProb.AutoSize = true;
            this.lbl_pageProb.Location = new System.Drawing.Point(320, 210);
            this.lbl_pageProb.Name = "lbl_pageProb";
            this.lbl_pageProb.Size = new System.Drawing.Size(141, 13);
            this.lbl_pageProb.TabIndex = 60;
            this.lbl_pageProb.Text = "Page Change Probability: 80";
            // 
            // trk_page
            // 
            this.trk_page.Location = new System.Drawing.Point(287, 228);
            this.trk_page.Maximum = 100;
            this.trk_page.Name = "trk_page";
            this.trk_page.Size = new System.Drawing.Size(185, 45);
            this.trk_page.TabIndex = 57;
            this.trk_page.Value = 80;
            this.trk_page.ValueChanged += new System.EventHandler(this.trk_page_ValueChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(476, 230);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(25, 13);
            this.label25.TabIndex = 58;
            this.label25.Text = "100";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(276, 229);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(13, 13);
            this.label26.TabIndex = 59;
            this.label26.Text = "0";
            // 
            // trk_totalProcesses
            // 
            this.trk_totalProcesses.Location = new System.Drawing.Point(42, 41);
            this.trk_totalProcesses.Maximum = 80;
            this.trk_totalProcesses.Minimum = 10;
            this.trk_totalProcesses.Name = "trk_totalProcesses";
            this.trk_totalProcesses.Size = new System.Drawing.Size(185, 45);
            this.trk_totalProcesses.TabIndex = 53;
            this.trk_totalProcesses.Value = 20;
            this.trk_totalProcesses.ValueChanged += new System.EventHandler(this.trk_totalProcesses_ValueChanged);
            // 
            // trk_creation
            // 
            this.trk_creation.Location = new System.Drawing.Point(34, 104);
            this.trk_creation.Maximum = 100;
            this.trk_creation.Name = "trk_creation";
            this.trk_creation.Size = new System.Drawing.Size(185, 45);
            this.trk_creation.TabIndex = 26;
            this.trk_creation.Value = 50;
            this.trk_creation.ValueChanged += new System.EventHandler(this.trk_creation_ValueChanged);
            // 
            // trk_quantum
            // 
            this.trk_quantum.Location = new System.Drawing.Point(34, 165);
            this.trk_quantum.Maximum = 20;
            this.trk_quantum.Name = "trk_quantum";
            this.trk_quantum.Size = new System.Drawing.Size(185, 45);
            this.trk_quantum.TabIndex = 27;
            this.trk_quantum.Value = 7;
            this.trk_quantum.ValueChanged += new System.EventHandler(this.trk_quantum_ValueChanged);
            // 
            // trk_duration
            // 
            this.trk_duration.Location = new System.Drawing.Point(33, 227);
            this.trk_duration.Maximum = 100;
            this.trk_duration.Minimum = 5;
            this.trk_duration.Name = "trk_duration";
            this.trk_duration.Size = new System.Drawing.Size(185, 45);
            this.trk_duration.TabIndex = 28;
            this.trk_duration.Value = 20;
            this.trk_duration.ValueChanged += new System.EventHandler(this.trk_duration_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(218, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "100";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "0";
            // 
            // lbl_creationProb
            // 
            this.lbl_creationProb.AutoSize = true;
            this.lbl_creationProb.Location = new System.Drawing.Point(73, 88);
            this.lbl_creationProb.Name = "lbl_creationProb";
            this.lbl_creationProb.Size = new System.Drawing.Size(115, 13);
            this.lbl_creationProb.TabIndex = 31;
            this.lbl_creationProb.Text = "Creation Probability: 50";
            // 
            // lbl_quantum
            // 
            this.lbl_quantum.AutoSize = true;
            this.lbl_quantum.Location = new System.Drawing.Point(101, 149);
            this.lbl_quantum.Name = "lbl_quantum";
            this.lbl_quantum.Size = new System.Drawing.Size(62, 13);
            this.lbl_quantum.TabIndex = 32;
            this.lbl_quantum.Text = "Quantum: 7";
            // 
            // lbl_processD
            // 
            this.lbl_processD.AutoSize = true;
            this.lbl_processD.Location = new System.Drawing.Point(82, 213);
            this.lbl_processD.Name = "lbl_processD";
            this.lbl_processD.Size = new System.Drawing.Size(106, 13);
            this.lbl_processD.TabIndex = 33;
            this.lbl_processD.Text = "Process Duration: 20";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(223, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "20";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "5";
            // 
            // trk_printerUsingTime
            // 
            this.trk_printerUsingTime.Location = new System.Drawing.Point(287, 102);
            this.trk_printerUsingTime.Maximum = 80;
            this.trk_printerUsingTime.Minimum = 10;
            this.trk_printerUsingTime.Name = "trk_printerUsingTime";
            this.trk_printerUsingTime.Size = new System.Drawing.Size(185, 45);
            this.trk_printerUsingTime.TabIndex = 38;
            this.trk_printerUsingTime.Value = 10;
            this.trk_printerUsingTime.ValueChanged += new System.EventHandler(this.trk_printerUsingTime_ValueChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(17, 41);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(19, 13);
            this.label19.TabIndex = 56;
            this.label19.Text = "10";
            // 
            // trk_printerUse
            // 
            this.trk_printerUse.Location = new System.Drawing.Point(287, 40);
            this.trk_printerUse.Maximum = 100;
            this.trk_printerUse.Name = "trk_printerUse";
            this.trk_printerUse.Size = new System.Drawing.Size(185, 45);
            this.trk_printerUse.TabIndex = 39;
            this.trk_printerUse.Value = 50;
            this.trk_printerUse.ValueChanged += new System.EventHandler(this.trk_printerUse_ValueChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(223, 41);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(19, 13);
            this.label20.TabIndex = 55;
            this.label20.Text = "80";
            // 
            // lbl_printerUse
            // 
            this.lbl_printerUse.AutoSize = true;
            this.lbl_printerUse.Location = new System.Drawing.Point(328, 23);
            this.lbl_printerUse.Name = "lbl_printerUse";
            this.lbl_printerUse.Size = new System.Drawing.Size(128, 13);
            this.lbl_printerUse.TabIndex = 40;
            this.lbl_printerUse.Text = "Printer Use Probability: 50";
            // 
            // lbl_totalPro
            // 
            this.lbl_totalPro.AutoSize = true;
            this.lbl_totalPro.Location = new System.Drawing.Point(77, 25);
            this.lbl_totalPro.Name = "lbl_totalPro";
            this.lbl_totalPro.Size = new System.Drawing.Size(101, 13);
            this.lbl_totalPro.TabIndex = 54;
            this.lbl_totalPro.Text = "Total Processes: 20";
            // 
            // lbl_printingTime
            // 
            this.lbl_printingTime.AutoSize = true;
            this.lbl_printingTime.Location = new System.Drawing.Point(338, 89);
            this.lbl_printingTime.Name = "lbl_printingTime";
            this.lbl_printingTime.Size = new System.Drawing.Size(86, 13);
            this.lbl_printingTime.TabIndex = 41;
            this.lbl_printingTime.Text = "Printing Time: 10";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(471, 40);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 13);
            this.label17.TabIndex = 42;
            this.label17.Text = "100";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(338, 146);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 13);
            this.label18.TabIndex = 52;
            this.label18.Text = "Program Speed";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(477, 105);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 13);
            this.label16.TabIndex = 43;
            this.label16.Text = "80";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(359, 194);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 50;
            this.label13.Text = "Normal";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(270, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 13);
            this.label15.TabIndex = 44;
            this.label15.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(469, 162);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "Fast";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(270, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 13);
            this.label14.TabIndex = 45;
            this.label14.Text = "10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(259, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "Slow";
            // 
            // trk_speed
            // 
            this.trk_speed.Location = new System.Drawing.Point(287, 162);
            this.trk_speed.Maximum = 4;
            this.trk_speed.Minimum = 1;
            this.trk_speed.Name = "trk_speed";
            this.trk_speed.Size = new System.Drawing.Size(185, 45);
            this.trk_speed.TabIndex = 47;
            this.trk_speed.Value = 2;
            // 
            // frm_sim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1608, 995);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbl_disk);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.dgr_waitingDisk);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.dgr_RAM);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.dgr_TAP);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.dgr_new);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_worldClock);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.lbl_printing);
            this.Controls.Add(this.lbl_running);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgr_waiting);
            this.Controls.Add(this.dgr_ready);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgr_pcb);
            this.Controls.Add(this.dgr_terminated);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_sim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulator";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frm_sim_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgr_terminated)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_pcb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_ready)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_waiting)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_new)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_TAP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_RAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_waitingDisk)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trk_page)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_totalProcesses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_creation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_quantum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_duration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_printerUsingTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_printerUse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_speed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgr_terminated;
        private System.Windows.Forms.DataGridView dgr_pcb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgr_ready;
        private System.Windows.Forms.DataGridView dgr_waiting;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_running;
        private System.Windows.Forms.Label lbl_printing;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lbl_worldClock;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgr_new;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DataGridView dgr_TAP;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridView dgr_RAM;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DataGridView dgr_waitingDisk;
        private System.Windows.Forms.ComboBox cbx_RAM;
        private System.Windows.Forms.Label lbl_disk;
        private System.Windows.Forms.Label lbl_ram;
        private System.Windows.Forms.Label lbl_frame;
        private System.Windows.Forms.ComboBox cbx_frame;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TrackBar trk_totalProcesses;
        private System.Windows.Forms.TrackBar trk_creation;
        private System.Windows.Forms.TrackBar trk_quantum;
        private System.Windows.Forms.TrackBar trk_duration;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_creationProb;
        private System.Windows.Forms.Label lbl_quantum;
        private System.Windows.Forms.Label lbl_processD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trk_printerUsingTime;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TrackBar trk_printerUse;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbl_printerUse;
        private System.Windows.Forms.Label lbl_totalPro;
        private System.Windows.Forms.Label lbl_printingTime;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TrackBar trk_speed;
        private System.Windows.Forms.Label lbl_pageProb;
        private System.Windows.Forms.TrackBar trk_page;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
    }
}

