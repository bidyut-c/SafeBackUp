namespace SafeBackUp
{
    partial class SafeBackUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbOverwrite = new System.Windows.Forms.CheckBox();
            this.btnAnalyse = new System.Windows.Forms.Button();
            this.btnProc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.rtLogView = new System.Windows.Forms.RichTextBox();
            this.lblNewFyl = new System.Windows.Forms.Label();
            this.lblChngFyl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDrvSrc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDrvDest = new System.Windows.Forms.TextBox();
            this.clbNFiles = new System.Windows.Forms.CheckedListBox();
            this.clbCFiles = new System.Windows.Forms.CheckedListBox();
            this.pbOP = new System.Windows.Forms.ProgressBar();
            this.tbDest = new System.Windows.Forms.TextBox();
            this.tbSrc = new System.Windows.Forms.TextBox();
            this.btnSrcDir = new System.Windows.Forms.Button();
            this.btnDestDir = new System.Windows.Forms.Button();
            this.fbSelect = new System.Windows.Forms.FolderBrowserDialog();
            this.gbProc = new System.Windows.Forms.GroupBox();
            this.rbMovFyl = new System.Windows.Forms.RadioButton();
            this.rbSync = new System.Windows.Forms.RadioButton();
            this.rbCpyDir = new System.Windows.Forms.RadioButton();
            this.rbBackUp = new System.Windows.Forms.RadioButton();
            this.ofdSelect = new System.Windows.Forms.OpenFileDialog();
            this.lblAllFyl = new System.Windows.Forms.Label();
            this.clbAFiles = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelTask = new System.Windows.Forms.Button();
            this.btnSaveTask = new System.Windows.Forms.Button();
            this.btnCallTask = new System.Windows.Forms.Button();
            this.btnFullScreen = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.clbNDFiles = new System.Windows.Forms.CheckedListBox();
            this.clbCDFiles = new System.Windows.Forms.CheckedListBox();
            this.clbADFiles = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblProg = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbNDselct = new System.Windows.Forms.CheckBox();
            this.cbCDeslct = new System.Windows.Forms.CheckBox();
            this.cbADeslct = new System.Windows.Forms.CheckBox();
            this.lblDelFyl = new System.Windows.Forms.Label();
            this.cbOnlyRecent = new System.Windows.Forms.CheckBox();
            this.gbProc.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(31, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Source ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(474, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Destination";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Thistle;
            this.btnClear.Location = new System.Drawing.Point(49, 669);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 29);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbOverwrite
            // 
            this.cbOverwrite.AutoSize = true;
            this.cbOverwrite.Location = new System.Drawing.Point(819, 607);
            this.cbOverwrite.Name = "cbOverwrite";
            this.cbOverwrite.Size = new System.Drawing.Size(127, 17);
            this.cbOverwrite.TabIndex = 7;
            this.cbOverwrite.Text = "Overwrite if exists";
            this.cbOverwrite.UseVisualStyleBackColor = true;
            // 
            // btnAnalyse
            // 
            this.btnAnalyse.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAnalyse.Location = new System.Drawing.Point(48, 605);
            this.btnAnalyse.Name = "btnAnalyse";
            this.btnAnalyse.Size = new System.Drawing.Size(89, 29);
            this.btnAnalyse.TabIndex = 3;
            this.btnAnalyse.Text = "Analyse";
            this.btnAnalyse.UseVisualStyleBackColor = false;
            this.btnAnalyse.Click += new System.EventHandler(this.btnAnalyse_Click);
            // 
            // btnProc
            // 
            this.btnProc.BackColor = System.Drawing.Color.Violet;
            this.btnProc.Location = new System.Drawing.Point(49, 637);
            this.btnProc.Name = "btnProc";
            this.btnProc.Size = new System.Drawing.Size(89, 29);
            this.btnProc.TabIndex = 4;
            this.btnProc.Text = "Process";
            this.btnProc.UseVisualStyleBackColor = false;
            this.btnProc.Click += new System.EventHandler(this.btnProc_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LawnGreen;
            this.btnExit.Location = new System.Drawing.Point(49, 701);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 29);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rtLogView
            // 
            this.rtLogView.BackColor = System.Drawing.Color.LightCyan;
            this.rtLogView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtLogView.Location = new System.Drawing.Point(161, 640);
            this.rtLogView.Name = "rtLogView";
            this.rtLogView.ReadOnly = true;
            this.rtLogView.Size = new System.Drawing.Size(779, 94);
            this.rtLogView.TabIndex = 10;
            this.rtLogView.Text = "";
            this.rtLogView.WordWrap = false;
            // 
            // lblNewFyl
            // 
            this.lblNewFyl.AutoSize = true;
            this.lblNewFyl.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblNewFyl.Location = new System.Drawing.Point(32, 99);
            this.lblNewFyl.Name = "lblNewFyl";
            this.lblNewFyl.Size = new System.Drawing.Size(66, 13);
            this.lblNewFyl.TabIndex = 12;
            this.lblNewFyl.Text = "New Files:";
            // 
            // lblChngFyl
            // 
            this.lblChngFyl.AutoSize = true;
            this.lblChngFyl.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblChngFyl.Location = new System.Drawing.Point(32, 245);
            this.lblChngFyl.Name = "lblChngFyl";
            this.lblChngFyl.Size = new System.Drawing.Size(95, 13);
            this.lblChngFyl.TabIndex = 16;
            this.lblChngFyl.Text = "Changed  Files:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Drive";
            // 
            // tbDrvSrc
            // 
            this.tbDrvSrc.Location = new System.Drawing.Point(419, 67);
            this.tbDrvSrc.Name = "tbDrvSrc";
            this.tbDrvSrc.Size = new System.Drawing.Size(38, 20);
            this.tbDrvSrc.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(854, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Drive";
            // 
            // tbDrvDest
            // 
            this.tbDrvDest.Location = new System.Drawing.Point(901, 67);
            this.tbDrvDest.Name = "tbDrvDest";
            this.tbDrvDest.Size = new System.Drawing.Size(38, 20);
            this.tbDrvDest.TabIndex = 2;
            // 
            // clbNFiles
            // 
            this.clbNFiles.BackColor = System.Drawing.Color.PapayaWhip;
            this.clbNFiles.CheckOnClick = true;
            this.clbNFiles.FormattingEnabled = true;
            this.clbNFiles.HorizontalScrollbar = true;
            this.clbNFiles.Location = new System.Drawing.Point(48, 115);
            this.clbNFiles.Name = "clbNFiles";
            this.clbNFiles.Size = new System.Drawing.Size(440, 109);
            this.clbNFiles.TabIndex = 20;
            // 
            // clbCFiles
            // 
            this.clbCFiles.BackColor = System.Drawing.Color.LemonChiffon;
            this.clbCFiles.CheckOnClick = true;
            this.clbCFiles.FormattingEnabled = true;
            this.clbCFiles.HorizontalScrollbar = true;
            this.clbCFiles.Location = new System.Drawing.Point(48, 261);
            this.clbCFiles.Name = "clbCFiles";
            this.clbCFiles.Size = new System.Drawing.Size(440, 109);
            this.clbCFiles.TabIndex = 21;
            // 
            // pbOP
            // 
            this.pbOP.ForeColor = System.Drawing.Color.Red;
            this.pbOP.Location = new System.Drawing.Point(403, 617);
            this.pbOP.Name = "pbOP";
            this.pbOP.Size = new System.Drawing.Size(323, 17);
            this.pbOP.TabIndex = 22;
            // 
            // tbDest
            // 
            this.tbDest.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbDest.ForeColor = System.Drawing.Color.Silver;
            this.tbDest.Location = new System.Drawing.Point(581, 67);
            this.tbDest.Name = "tbDest";
            this.tbDest.Size = new System.Drawing.Size(228, 20);
            this.tbDest.TabIndex = 23;
            this.tbDest.Text = "ENTER FOLDER NAME";
            this.tbDest.Click += new System.EventHandler(this.tbDest_Click);
            // 
            // tbSrc
            // 
            this.tbSrc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSrc.ForeColor = System.Drawing.Color.Silver;
            this.tbSrc.Location = new System.Drawing.Point(103, 67);
            this.tbSrc.Name = "tbSrc";
            this.tbSrc.Size = new System.Drawing.Size(228, 20);
            this.tbSrc.TabIndex = 24;
            this.tbSrc.Text = "ENTER FOLDER NAME";
            this.tbSrc.Click += new System.EventHandler(this.tbSrc_Click);
            // 
            // btnSrcDir
            // 
            this.btnSrcDir.Location = new System.Drawing.Point(335, 65);
            this.btnSrcDir.Name = "btnSrcDir";
            this.btnSrcDir.Size = new System.Drawing.Size(35, 22);
            this.btnSrcDir.TabIndex = 25;
            this.btnSrcDir.Text = "...";
            this.btnSrcDir.UseVisualStyleBackColor = true;
            this.btnSrcDir.Click += new System.EventHandler(this.btnSrcDir_Click);
            // 
            // btnDestDir
            // 
            this.btnDestDir.Location = new System.Drawing.Point(816, 67);
            this.btnDestDir.Name = "btnDestDir";
            this.btnDestDir.Size = new System.Drawing.Size(35, 22);
            this.btnDestDir.TabIndex = 26;
            this.btnDestDir.Text = "...";
            this.btnDestDir.UseVisualStyleBackColor = true;
            this.btnDestDir.Click += new System.EventHandler(this.btnDestDir_Click);
            // 
            // gbProc
            // 
            this.gbProc.Controls.Add(this.rbMovFyl);
            this.gbProc.Controls.Add(this.rbSync);
            this.gbProc.Controls.Add(this.rbCpyDir);
            this.gbProc.Controls.Add(this.rbBackUp);
            this.gbProc.Location = new System.Drawing.Point(48, 25);
            this.gbProc.Name = "gbProc";
            this.gbProc.Size = new System.Drawing.Size(513, 34);
            this.gbProc.TabIndex = 27;
            this.gbProc.TabStop = false;
            this.gbProc.Text = "Select Process";
            // 
            // rbMovFyl
            // 
            this.rbMovFyl.AutoSize = true;
            this.rbMovFyl.Location = new System.Drawing.Point(406, 12);
            this.rbMovFyl.Name = "rbMovFyl";
            this.rbMovFyl.Size = new System.Drawing.Size(101, 17);
            this.rbMovFyl.TabIndex = 3;
            this.rbMovFyl.TabStop = true;
            this.rbMovFyl.Text = "Move Folders";
            this.rbMovFyl.UseVisualStyleBackColor = true;
            this.rbMovFyl.CheckedChanged += new System.EventHandler(this.rbCpyFyl_CheckedChanged);
            // 
            // rbSync
            // 
            this.rbSync.AutoSize = true;
            this.rbSync.Location = new System.Drawing.Point(136, 12);
            this.rbSync.Name = "rbSync";
            this.rbSync.Size = new System.Drawing.Size(53, 17);
            this.rbSync.TabIndex = 2;
            this.rbSync.TabStop = true;
            this.rbSync.Text = "Sync";
            this.rbSync.UseVisualStyleBackColor = true;
            // 
            // rbCpyDir
            // 
            this.rbCpyDir.AutoSize = true;
            this.rbCpyDir.Location = new System.Drawing.Point(227, 12);
            this.rbCpyDir.Name = "rbCpyDir";
            this.rbCpyDir.Size = new System.Drawing.Size(141, 17);
            this.rbCpyDir.TabIndex = 1;
            this.rbCpyDir.TabStop = true;
            this.rbCpyDir.Text = "Copy/Delete Folders";
            this.rbCpyDir.UseVisualStyleBackColor = true;
            this.rbCpyDir.CheckedChanged += new System.EventHandler(this.rbCpyDir_CheckedChanged);
            // 
            // rbBackUp
            // 
            this.rbBackUp.AutoSize = true;
            this.rbBackUp.Checked = true;
            this.rbBackUp.Location = new System.Drawing.Point(28, 12);
            this.rbBackUp.Name = "rbBackUp";
            this.rbBackUp.Size = new System.Drawing.Size(70, 17);
            this.rbBackUp.TabIndex = 0;
            this.rbBackUp.TabStop = true;
            this.rbBackUp.Text = "BackUp";
            this.rbBackUp.UseVisualStyleBackColor = true;
            // 
            // lblAllFyl
            // 
            this.lblAllFyl.AutoSize = true;
            this.lblAllFyl.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblAllFyl.Location = new System.Drawing.Point(32, 389);
            this.lblAllFyl.Name = "lblAllFyl";
            this.lblAllFyl.Size = new System.Drawing.Size(51, 13);
            this.lblAllFyl.TabIndex = 28;
            this.lblAllFyl.Text = "All Files";
            // 
            // clbAFiles
            // 
            this.clbAFiles.CausesValidation = false;
            this.clbAFiles.FormattingEnabled = true;
            this.clbAFiles.HorizontalScrollbar = true;
            this.clbAFiles.Location = new System.Drawing.Point(49, 405);
            this.clbAFiles.Name = "clbAFiles";
            this.clbAFiles.Size = new System.Drawing.Size(440, 184);
            this.clbAFiles.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelTask);
            this.groupBox1.Controls.Add(this.btnSaveTask);
            this.groupBox1.Controls.Add(this.btnCallTask);
            this.groupBox1.Location = new System.Drawing.Point(687, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 34);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Task";
            // 
            // btnDelTask
            // 
            this.btnDelTask.BackColor = System.Drawing.Color.Khaki;
            this.btnDelTask.ForeColor = System.Drawing.Color.Black;
            this.btnDelTask.Location = new System.Drawing.Point(105, 9);
            this.btnDelTask.Name = "btnDelTask";
            this.btnDelTask.Size = new System.Drawing.Size(52, 22);
            this.btnDelTask.TabIndex = 2;
            this.btnDelTask.Text = "Delete";
            this.btnDelTask.UseVisualStyleBackColor = false;
            // 
            // btnSaveTask
            // 
            this.btnSaveTask.BackColor = System.Drawing.Color.Khaki;
            this.btnSaveTask.Location = new System.Drawing.Point(170, 9);
            this.btnSaveTask.Name = "btnSaveTask";
            this.btnSaveTask.Size = new System.Drawing.Size(52, 22);
            this.btnSaveTask.TabIndex = 1;
            this.btnSaveTask.Text = "Save";
            this.btnSaveTask.UseVisualStyleBackColor = false;
            // 
            // btnCallTask
            // 
            this.btnCallTask.BackColor = System.Drawing.Color.Khaki;
            this.btnCallTask.ForeColor = System.Drawing.Color.Black;
            this.btnCallTask.Location = new System.Drawing.Point(39, 9);
            this.btnCallTask.Name = "btnCallTask";
            this.btnCallTask.Size = new System.Drawing.Size(52, 22);
            this.btnCallTask.TabIndex = 0;
            this.btnCallTask.Text = "Call";
            this.btnCallTask.UseVisualStyleBackColor = false;
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.BackColor = System.Drawing.Color.White;
            this.btnFullScreen.Location = new System.Drawing.Point(74, 2);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Size = new System.Drawing.Size(86, 22);
            this.btnFullScreen.TabIndex = 31;
            this.btnFullScreen.Text = "Full Screen";
            this.btnFullScreen.UseVisualStyleBackColor = false;
            this.btnFullScreen.Click += new System.EventHandler(this.btnFullScreen_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(762, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "(CD-Date Written/Ln-Length)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(417, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "SOURCE";
            // 
            // clbNDFiles
            // 
            this.clbNDFiles.BackColor = System.Drawing.Color.PapayaWhip;
            this.clbNDFiles.CausesValidation = false;
            this.clbNDFiles.ForeColor = System.Drawing.SystemColors.WindowText;
            this.clbNDFiles.HorizontalScrollbar = true;
            this.clbNDFiles.Location = new System.Drawing.Point(499, 115);
            this.clbNDFiles.Name = "clbNDFiles";
            this.clbNDFiles.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.clbNDFiles.Size = new System.Drawing.Size(440, 109);
            this.clbNDFiles.TabIndex = 34;
            // 
            // clbCDFiles
            // 
            this.clbCDFiles.BackColor = System.Drawing.Color.LemonChiffon;
            this.clbCDFiles.CausesValidation = false;
            this.clbCDFiles.ForeColor = System.Drawing.SystemColors.WindowText;
            this.clbCDFiles.FormattingEnabled = true;
            this.clbCDFiles.HorizontalScrollbar = true;
            this.clbCDFiles.Location = new System.Drawing.Point(499, 261);
            this.clbCDFiles.Name = "clbCDFiles";
            this.clbCDFiles.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.clbCDFiles.Size = new System.Drawing.Size(440, 109);
            this.clbCDFiles.TabIndex = 35;
            // 
            // clbADFiles
            // 
            this.clbADFiles.CausesValidation = false;
            this.clbADFiles.FormattingEnabled = true;
            this.clbADFiles.HorizontalScrollbar = true;
            this.clbADFiles.Location = new System.Drawing.Point(500, 405);
            this.clbADFiles.Name = "clbADFiles";
            this.clbADFiles.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.clbADFiles.Size = new System.Drawing.Size(440, 184);
            this.clbADFiles.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(829, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 17);
            this.label9.TabIndex = 37;
            this.label9.Text = "DESTINATION";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(496, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Following Folders/Files will be created";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(496, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Following Files will be overwritten";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label12.Location = new System.Drawing.Point(320, 245);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(171, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "(CD-Date Written/Ln-Length)";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // lblProg
            // 
            this.lblProg.AutoSize = true;
            this.lblProg.Location = new System.Drawing.Point(472, 601);
            this.lblProg.Name = "lblProg";
            this.lblProg.Size = new System.Drawing.Size(0, 13);
            this.lblProg.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PeachPuff;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(426, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 23);
            this.label3.TabIndex = 40;
            this.label3.Text = "SAFEBACKUP";
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(183, 2);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(51, 22);
            this.btnAbout.TabIndex = 41;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.about_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(3, 2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(51, 22);
            this.btnHelp.TabIndex = 42;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Handwriting", 6F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(558, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "BC";
            // 
            // cbNDselct
            // 
            this.cbNDselct.AutoSize = true;
            this.cbNDselct.ForeColor = System.Drawing.Color.DarkRed;
            this.cbNDselct.Location = new System.Drawing.Point(218, 96);
            this.cbNDselct.Name = "cbNDselct";
            this.cbNDselct.Size = new System.Drawing.Size(94, 17);
            this.cbNDselct.TabIndex = 44;
            this.cbNDselct.Text = "Deselect All";
            this.cbNDselct.UseVisualStyleBackColor = true;
            this.cbNDselct.Click += new System.EventHandler(this.cbNDselct_Click);
            // 
            // cbCDeslct
            // 
            this.cbCDeslct.AutoSize = true;
            this.cbCDeslct.ForeColor = System.Drawing.Color.DarkRed;
            this.cbCDeslct.Location = new System.Drawing.Point(218, 242);
            this.cbCDeslct.Name = "cbCDeslct";
            this.cbCDeslct.Size = new System.Drawing.Size(94, 17);
            this.cbCDeslct.TabIndex = 45;
            this.cbCDeslct.Text = "Deselect All";
            this.cbCDeslct.UseVisualStyleBackColor = true;
            this.cbCDeslct.Click += new System.EventHandler(this.cbCDeslct_Click);
            // 
            // cbADeslct
            // 
            this.cbADeslct.AutoSize = true;
            this.cbADeslct.ForeColor = System.Drawing.Color.DarkRed;
            this.cbADeslct.Location = new System.Drawing.Point(706, 386);
            this.cbADeslct.Name = "cbADeslct";
            this.cbADeslct.Size = new System.Drawing.Size(94, 17);
            this.cbADeslct.TabIndex = 46;
            this.cbADeslct.Text = "Deselect All";
            this.cbADeslct.UseVisualStyleBackColor = true;
            this.cbADeslct.Click += new System.EventHandler(this.cbADeslct_Click);
            // 
            // lblDelFyl
            // 
            this.lblDelFyl.AutoSize = true;
            this.lblDelFyl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelFyl.Location = new System.Drawing.Point(496, 391);
            this.lblDelFyl.Name = "lblDelFyl";
            this.lblDelFyl.Size = new System.Drawing.Size(200, 13);
            this.lblDelFyl.TabIndex = 47;
            this.lblDelFyl.Text = "Following files will be deleted from source";
            // 
            // cbOnlyRecent
            // 
            this.cbOnlyRecent.AutoSize = true;
            this.cbOnlyRecent.Checked = true;
            this.cbOnlyRecent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOnlyRecent.Location = new System.Drawing.Point(849, 370);
            this.cbOnlyRecent.Name = "cbOnlyRecent";
            this.cbOnlyRecent.Size = new System.Drawing.Size(96, 17);
            this.cbOnlyRecent.TabIndex = 48;
            this.cbOnlyRecent.Text = "Only Recent";
            this.cbOnlyRecent.UseVisualStyleBackColor = true;
            // 
            // SafeBackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(986, 741);
            this.Controls.Add(this.cbOnlyRecent);
            this.Controls.Add(this.lblDelFyl);
            this.Controls.Add(this.cbADeslct);
            this.Controls.Add(this.cbCDeslct);
            this.Controls.Add(this.cbNDselct);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblProg);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.clbADFiles);
            this.Controls.Add(this.clbCDFiles);
            this.Controls.Add(this.clbNDFiles);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnFullScreen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clbAFiles);
            this.Controls.Add(this.lblAllFyl);
            this.Controls.Add(this.gbProc);
            this.Controls.Add(this.btnDestDir);
            this.Controls.Add(this.btnSrcDir);
            this.Controls.Add(this.tbSrc);
            this.Controls.Add(this.tbDest);
            this.Controls.Add(this.clbCFiles);
            this.Controls.Add(this.clbNFiles);
            this.Controls.Add(this.tbDrvDest);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbDrvSrc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblChngFyl);
            this.Controls.Add(this.lblNewFyl);
            this.Controls.Add(this.rtLogView);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnProc);
            this.Controls.Add(this.btnAnalyse);
            this.Controls.Add(this.cbOverwrite);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbOP);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "SafeBackUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Safe BackUp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SafeBackUp_Load);
            this.gbProc.ResumeLayout(false);
            this.gbProc.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox cbOverwrite;
        private System.Windows.Forms.Button btnAnalyse;
        private System.Windows.Forms.Button btnProc;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RichTextBox rtLogView;
        private System.Windows.Forms.Label lblNewFyl;
        private System.Windows.Forms.Label lblChngFyl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDrvSrc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDrvDest;
        private System.Windows.Forms.CheckedListBox clbNFiles;
        private System.Windows.Forms.CheckedListBox clbCFiles;
        private System.Windows.Forms.ProgressBar pbOP;
        private System.Windows.Forms.TextBox tbDest;
        private System.Windows.Forms.TextBox tbSrc;
        private System.Windows.Forms.Button btnSrcDir;
        private System.Windows.Forms.Button btnDestDir;
        private System.Windows.Forms.FolderBrowserDialog fbSelect;
        private System.Windows.Forms.GroupBox gbProc;
        private System.Windows.Forms.RadioButton rbBackUp;
        private System.Windows.Forms.RadioButton rbSync;
        private System.Windows.Forms.RadioButton rbCpyDir;
        private System.Windows.Forms.OpenFileDialog ofdSelect;
        private System.Windows.Forms.RadioButton rbMovFyl;
        private System.Windows.Forms.Label lblAllFyl;
        private System.Windows.Forms.CheckedListBox clbAFiles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaveTask;
        private System.Windows.Forms.Button btnCallTask;
        private System.Windows.Forms.Button btnFullScreen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox clbNDFiles;
        private System.Windows.Forms.CheckedListBox clbCDFiles;
        private System.Windows.Forms.CheckedListBox clbADFiles;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblProg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelTask;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbNDselct;
        private System.Windows.Forms.CheckBox cbCDeslct;
        private System.Windows.Forms.CheckBox cbADeslct;
        private System.Windows.Forms.Label lblDelFyl;
        private System.Windows.Forms.CheckBox cbOnlyRecent;
    }
}

