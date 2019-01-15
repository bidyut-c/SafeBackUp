namespace SafeBackUp
{
    partial class frmFileSelect
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
            this.tvuFolder = new System.Windows.Forms.TreeView();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnCancell = new System.Windows.Forms.Button();
            this.lblDir = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTrgDir = new System.Windows.Forms.Label();
            this.cbOvrWrite = new System.Windows.Forms.CheckBox();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.pbPr = new System.Windows.Forms.ProgressBar();
            this.cbWSDir = new System.Windows.Forms.CheckBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tvuFolder
            // 
            this.tvuFolder.CheckBoxes = true;
            this.tvuFolder.Location = new System.Drawing.Point(52, 35);
            this.tvuFolder.Name = "tvuFolder";
            this.tvuFolder.Size = new System.Drawing.Size(306, 319);
            this.tvuFolder.TabIndex = 0;
            this.tvuFolder.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvuFolder_AfterCheck);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(52, 573);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(62, 20);
            this.btnCopy.TabIndex = 1;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnCancell
            // 
            this.btnCancell.Location = new System.Drawing.Point(214, 573);
            this.btnCancell.Name = "btnCancell";
            this.btnCancell.Size = new System.Drawing.Size(62, 20);
            this.btnCancell.TabIndex = 2;
            this.btnCancell.Text = "Cancell";
            this.btnCancell.UseVisualStyleBackColor = true;
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDir.Location = new System.Drawing.Point(49, 19);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(293, 13);
            this.lblDir.TabIndex = 3;
            this.lblDir.Text = "Source (Deselect ones not to be copied or moved)";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(160, 599);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 20);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Target Directory";
            // 
            // lblTrgDir
            // 
            this.lblTrgDir.AutoSize = true;
            this.lblTrgDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTrgDir.Location = new System.Drawing.Point(156, 382);
            this.lblTrgDir.Name = "lblTrgDir";
            this.lblTrgDir.Size = new System.Drawing.Size(37, 15);
            this.lblTrgDir.TabIndex = 6;
            this.lblTrgDir.Text = "label2";
            // 
            // cbOvrWrite
            // 
            this.cbOvrWrite.AutoSize = true;
            this.cbOvrWrite.Location = new System.Drawing.Point(256, 354);
            this.cbOvrWrite.Name = "cbOvrWrite";
            this.cbOvrWrite.Size = new System.Drawing.Size(108, 17);
            this.cbOvrWrite.TabIndex = 7;
            this.cbOvrWrite.Text = "Overwrite if exists";
            this.cbOvrWrite.UseVisualStyleBackColor = true;
            // 
            // rtbLog
            // 
            this.rtbLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbLog.Location = new System.Drawing.Point(52, 447);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(306, 117);
            this.rtbLog.TabIndex = 8;
            this.rtbLog.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Log";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(133, 573);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(62, 20);
            this.btnDel.TabIndex = 11;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // pbPr
            // 
            this.pbPr.Location = new System.Drawing.Point(52, 410);
            this.pbPr.Name = "pbPr";
            this.pbPr.Size = new System.Drawing.Size(305, 10);
            this.pbPr.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbPr.TabIndex = 12;
            // 
            // cbWSDir
            // 
            this.cbWSDir.AutoSize = true;
            this.cbWSDir.Location = new System.Drawing.Point(52, 354);
            this.cbWSDir.Name = "cbWSDir";
            this.cbWSDir.Size = new System.Drawing.Size(123, 17);
            this.cbWSDir.TabIndex = 13;
            this.cbWSDir.Text = "With Sub Directories";
            this.cbWSDir.UseVisualStyleBackColor = true;
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(295, 573);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(62, 20);
            this.btnMove.TabIndex = 14;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // frmFileSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(410, 628);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.cbWSDir);
            this.Controls.Add(this.pbPr);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.cbOvrWrite);
            this.Controls.Add(this.lblTrgDir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblDir);
            this.Controls.Add(this.btnCancell);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.tvuFolder);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFileSelect";
            this.Text = "Copy Selected Files";
            this.Load += new System.EventHandler(this.frmFileSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvuFolder;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnCancell;
        public System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTrgDir;
        private System.Windows.Forms.CheckBox cbOvrWrite;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.ProgressBar pbPr;
        private System.Windows.Forms.CheckBox cbWSDir;
        private System.Windows.Forms.Button btnMove;
    }
}