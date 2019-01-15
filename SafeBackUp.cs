using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Diagnostics;
using System.IO;
//using System.Text;
using System.Windows.Forms;
using System.Threading;


///<remarks>
///     SafeBackUp - Software for regular backup of
///     selected directories/files
///     (c) Copyright - 2012 Bidyut Chakraborty
///     To be included:(18-8-2017): Check out cases where a folder is being copied in its subfolder
///</remarks>
namespace SafeBackUp
{
    public partial class SafeBackUp : Form
    {
        //private bool blDrvUpdt = false;
        private ArrayList alSrc;
        private ArrayList alDest;
        enum FullScreenMode { Yes, No };
        FullScreenMode fullScreenMode;
        FullScreen fullScreen = new FullScreen();
        int newFylCount = 0;
        int chngFylCount = 0;
        int alFylCount = 0;
        bool Analyzing = false;
        //bool Analyzed = false;
        //enum ClrAll {WOPath, WPath};

        //#region Modified/Commented
        /// <summary>
        /// Class to compare two files in decending order
        /// </summary>
        public class FileSorter : IComparer
        {
            int IComparer.Compare(object fyl1, object fyl2)
            {
                //FileInfo file1 = (FileInfo)fyl1;
                //FileInfo file2 = (FileInfo)fyl2;
                //if (file1.Length > file2.Length)
                //{
                //    return -1;
                //}
                //if (file1.Length < file2.Length)
                //{
                //    return 1;
                //}
                //return 0;
                return ((new CaseInsensitiveComparer()).Compare(fyl1,fyl2));
            }
        }
        //#endregion

        IComparer mySorter = new FileSorter();

        public SafeBackUp()
        {
            InitializeComponent();
            fullScreenMode = FullScreenMode.No;
        }
        #region Modified/Commented
        /// <summary>
        /// Fill the directory tree for either the Source or
        /// Target TreeView.
        /// </summary>
        /// <param name="tvw"></param>
        /// <param name="isSource"></param>
        //private void FillDirectoryTree(TreeView tvw, bool isSource)
        //{
        //    tvw.Nodes.Clear();
        //    string[] strDrives = Environment.GetLogicalDrives();
        //    foreach (string rootDirectoryName in strDrives)
        //    {
        //        if (rootDirectoryName != @"C:\")
        //            continue;
        //        try
        //        {
        //            DirectoryInfo dir = new DirectoryInfo(rootDirectoryName);
        //            dir.GetDirectories();
        //            TreeNode ndRoot = new TreeNode(rootDirectoryName);
        //            tvw.Nodes.Add(ndRoot);
        //            if (isSource)
        //            {
        //                //GetSubDirectoryNodes(ndRoot, ndRoot.Text, true);
        //            }
        //            else
        //            {
        //                //GetSubDirectoryNodes(ndRoot, ndRoot.Text, false);
        //            }
        //        }
        //        catch (Exception e)
        //        {
        //            MessageBox.Show(e.Message);
        //        }
        //    }
        //}

        ///// <summary>
        ///// Get the list of files within root and subdirectories (if any)
        ///// for back up, synchronise or copy
        ///// </summary>
        ///// <param name="strPath"></param>
        ///// <param name="isFile"></param>
        //private ArrayList GetFilesList(string strPath)
        //{
        //    ArrayList alFyles = new ArrayList();
        //    alFyles.Add(strPath);
        //    DirectoryInfo dir = new DirectoryInfo(strPath);
            
        //    FileInfo[] files = dir.GetFiles();
        //    foreach (FileInfo file in files)
        //    {
        //        alFyles.Add(file.FullName);
        //    }

        //    DirectoryInfo[] dirSubs = dir.GetDirectories();
        //    foreach (DirectoryInfo dirSub in dirSubs)
        //    {
        //        if ((dirSub.Attributes & FileAttributes.Hidden) != 0)
        //            continue;
        //        alFyles.Add(dirSub.FullName);
        //        GetSubDirectoryNodes(alFyles, dirSub.FullName);//, isFile);
        //    }
        //    return alFyles;
        //}


        ///// <summary>
        ///// Get all subdirctories below the passed directory node
        ///// Then add to Array List.
        ///// </summary>
        ///// <param name="alFyles"></param>
        ///// <param name="fullName"></param>
        //private void GetSubDirectoryNodes(ArrayList alFyles, string fullName)
        //{
        //    DirectoryInfo dir = new DirectoryInfo(fullName);
        //    DirectoryInfo[] dirSubs = dir.GetDirectories();

        //    foreach (DirectoryInfo dirSub in dirSubs)
        //    {
        //        if ((dirSub.Attributes & FileAttributes.Hidden) != 0)
        //            continue;
        //        alFyles.Add(dirSub.FullName);
        //        GetSubDirectoryNodes(alFyles, dirSub.FullName);//, getFileName);
        //    }

        //    FileInfo[] files = dir.GetFiles();
        //    foreach (FileInfo file in files)
        //    {
        //        alFyles.Add(file.FullName);
        //    }
        //}
        #endregion

        private void btnSrcDir_Click(object sender, EventArgs e)
        {
            //string strPathName="";
            //alSrc = new ArrayList();

            if (rbMovFyl.Checked && (ofdSelect.ShowDialog() == DialogResult.OK))
            {
                tbSrc.ForeColor = System.Drawing.Color.Black;
                tbSrc.Text = ofdSelect.FileName;
                //strPathName = ofdSelect.FileName;
            }
            else
                if (fbSelect.ShowDialog()==DialogResult.OK)
                {
                    tbSrc.ForeColor = System.Drawing.Color.Black;
                    tbSrc.Text = fbSelect.SelectedPath;
                    //strPathName = fbSelect.SelectedPath ;
                }
            if (tbSrc.Text == "ENTER FOLDER NAME" || tbSrc.Text == "ENTER FILE NAME")
            {
                return;
            }
            #region Modified/Commented
            //FileAttributes fAttr = File.GetAttributes(strPathName);
            //if (rbBackUp.Checked || rbSync.Checked || rbCpyDir.Checked)
            //    if ((fAttr & FileAttributes.Directory) == FileAttributes.Directory)
            //        alSrc = GetFilesList(strPathName);
            //    else
            //    {
            //        MessageBox.Show("For Back Up or Sync you have to enter directory");
            //        return;
            //    }
            //else
            //    if ((rbCpyFyl.Checked) &&
            //         (fAttr & FileAttributes.Directory) != FileAttributes.Directory)
            //        //flSrc = GetFilesList(strPathName);
            //        alSrc.Add(strPathName);
            //    else
            //    {
            //        MessageBox.Show("For File copy enter file name with full path");
            //        return;
            //    }
            #endregion
        }

        private void btnDestDir_Click(object sender, EventArgs e)
        {
            //string strPathName = "";
            //alDest = new ArrayList();
            if (fbSelect.ShowDialog() == DialogResult.OK)
            {
                tbDest.ForeColor = System.Drawing.Color.Black;
                tbDest.Text = fbSelect.SelectedPath;
                //strPathName = fbSelect.SelectedPath;
            }
            if (tbDest.Text == "ENTER FOLDER NAME")
                return;
            #region Modified/Commented
            //FileAttributes fAttr = File.GetAttributes(strPathName);
            //if ((fAttr & FileAttributes.Directory) == FileAttributes.Directory)
            //    if (rbBackUp.Checked || rbSync.Checked)
            //        alDest = GetFilesList(strPathName);
            //    else
            //        alDest.Add(strPathName);
            //else
            //    return;
             #endregion        
       }
        //private void tbDrvSrc_TextChanged(object sender, EventArgs e)
        //{
        //    if (blDrvUpdt)
        //    {
        //        blDrvUpdt = false;
        //        return;
        //    }
        //    blDrvUpdt = true;
        //    tbDrvSrc.Text = tbDrvSrc.Text.Substring(0, 1).ToUpper() + ":\\";
        //    CheckDrive(tbDrvSrc.Text);
        //}

        //private void tbDrvDest_TextChanged(object sender, EventArgs e)
        //{
        //    if (blDrvUpdt)
        //    {
        //        blDrvUpdt = false;
        //        return;
        //    }
        //    blDrvUpdt = true;
        //    tbDrvDest.Text = tbDrvDest.Text.Substring(0, 1).ToUpper() + ":\\";
        //    CheckDrive(tbDrvDest.Text);
        //    frmFileSelect frmFyl = new frmFileSelect();
        //}

        //private bool CheckDrive(string strdrv)
        //{
        //    string[] strDrives = Environment.GetLogicalDrives();
        //    foreach (string drv in strDrives)
        //    {
        //        if (drv == strdrv)
        //        {
        //            return true;
        //        }
        //    }
        //    MessageBox.Show("No drive named: " + strdrv);
        //    return false;
        //}

        private void tbDest_Click(object sender, EventArgs e)
        {
            tbDest.Text = "";
            tbDest.ForeColor = System.Drawing.Color.Black;
        }

        private void tbSrc_Click(object sender, EventArgs e)
        {
            tbSrc.Text = "";
            tbSrc.ForeColor = System.Drawing.Color.Black;
        }

        //private void rbCpyFyl_CheckedChanged(object sender, EventArgs e)
        //{
        //    tbSrc.Text = "Enter File Name";
        //    //this.btnAnalyse.Enabled = false;
        //}

        private void rbBackUp_CheckedChanged(object sender, EventArgs e)
        {
            tbSrc.Text = "Enter Folder Name";
            if (rbBackUp.Checked)
                lblAllFyl.Text = "All Files";
        }

        private void rbSync_CheckedChanged(object sender, EventArgs e)
        {
            tbSrc.Text = "Enter Folder Name";
            if (rbSync.Checked)
                lblAllFyl.Text = "Delete Files: Following files will be deleted";
        }

        //private void rbCpyDir_CheckedChanged(object sender, EventArgs e)
        //{
        //    tbSrc.Text = "Enter Folder Name";
        //}

        private void btnExit_Click(object sender, EventArgs e)
        {
            LogFile.writeLog(DateTime.Now + " - Exit");
            this.Close();
        }

        private void ReturnBack() {
            btnAnalyse.Enabled=true;
            return;
        }

        private void ReturnBack(string Msg)
        {
            MessageBox.Show(Msg, "Warning",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            btnAnalyse.Enabled = true;
            return;
        }

        private void btnAnalyse_Click(object sender, EventArgs e)
        {
            if (rbCpyDir.Checked)
            {
                LogFile.writeLog(DateTime.Now + " CopyFolder started");
                rtLogView.AppendText(DateTime.Now + "  CopyFolder started...\n");
            }
            else if (rbMovFyl.Checked)
            {
                LogFile.writeLog(DateTime.Now + " MoveFolder started");
                rtLogView.AppendText(DateTime.Now + "  MoveFolder started...\n");
            }
            else
            {
                LogFile.writeLog(DateTime.Now + " Analysis started");
                rtLogView.AppendText(DateTime.Now + "  Analysis started...\n");
            }
            btnAnalyse.Enabled = false;
            //if (Analyzed)
            //{
            //    if (backgroundWorker1.IsBusy)
            //        backgroundWorker1.CancelAsync();
            string prevSrcPath = tbSrc.Text;
            string prevDestPath = tbDest.Text;
            clearAll();
            cbOnlyRecent.Checked = true;
            tbDest.Text = prevDestPath;
            tbSrc.Text = prevSrcPath;
            Application.DoEvents();
            //}
            //Analyzed = true;

            if (Analyzing)
            {
                ReturnBack();
                return;
            }
            Analyzing = true;
            if (tbSrc.Text == "" || tbSrc.Text=="ENTER FOLDER NAME")
            {
                ReturnBack("No Source directory selected!!");
                return;
            }
            if (tbDest.Text == "" || tbDest.Text == "ENTER FOLDER NAME")
            {
                ReturnBack("No Target directory selected!!");
                return;
            }
            if (tbDest.Text == tbSrc.Text)
            {
                ReturnBack("Source and Destination directories/folders path should be different");
                return;
            }
            
            FileAttributes fAttr;

            #region Commented Lines
            //if (rbBackUp.Checked || rbSync.Checked || rbCpyDir.Checked)
            //    if ((fAttr & FileAttributes.Directory) == FileAttributes.Directory)
            //    {
            //        alSrc = new ArrayList();
            //        alSrc = FileSearch.GetFilesList(tbSrc.Text);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Select required source directory/folder only");
            //        return;
            //    }
            //else
            //    if (rbCpyFyl.Checked)
            //        if ((fAttr & FileAttributes.Directory) == FileAttributes.Directory)
            //        {
            //            MessageBox.Show("Process not ready. Contact application designer");
            //            //Nothing to be done here
            //            return;
            //        }
            //        else
            //        {
            //            MessageBox.Show("For File copy enter source directory/folder only");
            //            return;
            //        }
            //    else
            //    {
            //        MessageBox.Show("Select a specific process through radio buttons");
            //        return;
            //    }
            #endregion

            //Creation of directory - modified on 18/8/2017
            if (!Directory.Exists(tbDest.Text))
            {
                Directory.CreateDirectory(tbDest.Text);
            }

            if (rbBackUp.Checked || rbSync.Checked)
            {
                fAttr = File.GetAttributes(tbSrc.Text);
                if ((fAttr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    alSrc = new ArrayList();
                    alSrc = FileSearch.GetFilesList(tbSrc.Text);
                }
                else
                {
                    ReturnBack("Select required source directory/folder only");
                    return;
                }
            }

            if (rbSync.Checked)
            {
                clbADFiles.SelectionMode = SelectionMode.One;
                clbAFiles.SelectionMode = SelectionMode.None;
                lblAllFyl.Text = "Delete Files";
                lblDelFyl.Visible = true;
                cbADeslct.Visible = true;
            }
            if (rbBackUp.Checked)
            {
                clbAFiles.SelectionMode = SelectionMode.One;
                clbADFiles.SelectionMode = SelectionMode.None;
                lblAllFyl.Text = "All Files";
                lblDelFyl.Visible = false;
                cbADeslct.Visible = false;
            }

            #region commented lines
            //if (rbBackUp.Checked || rbSync.Checked || rbCpyDir.Checked)
            //    if ((fAttr & FileAttributes.Directory) == FileAttributes.Directory)
            //    {
            //        alDest = new ArrayList();
            //        alDest = FileSearch.GetFilesList(tbDest.Text);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Select required target directory/folder only");
            //        return;
            //    }
            //if (rbCpyFyl.Checked)
            //    if ((fAttr & FileAttributes.Directory) == FileAttributes.Directory)
            //    {
            //        //frmFileSelect frmFylSel = new frmFileSelect();
            //        //call frmFileSelect method for process
            //        return;
            //    }
            //    else
            //    {
            //        MessageBox.Show("To copy files destination directory/folder should be given");
            //        return;
            //    }
            #endregion

            if (rbSync.Checked || rbBackUp.Checked)
            {
                fAttr = File.GetAttributes(tbDest.Text);
                if ((fAttr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    alDest = new ArrayList();
                    alDest = FileSearch.GetFilesList(tbDest.Text);
                }
                else
                {
                    ReturnBack("Select required target directory/folder only");
                    return;
                }
            }
            #region Backup and Sync
            //if (!backgroundWorker1.IsBusy)
            //    backgroundWorker1.RunWorkerAsync();

            if (rbBackUp.Checked || rbSync.Checked)
            {
                var newFyles = clbNFiles.Items;
                var chngFyles = clbCFiles.Items;
                var alFyles = clbAFiles.Items;
                var newDFyles = clbNDFiles.Items;
                var chngDFyles = clbCDFiles.Items;
                var alDFyles = clbADFiles.Items;
                int newFylCount = 0;
                int chngFylCount = 0;
                int alFylCount = 0;
                int s = 0, d = 0;
                int srcFylCount = 0;
                int SrcFylCur = 0;
                FileInfo sfl;
                FileInfo dfl;
                string sflName, dflName;
                int ProgVal;
                //bool OnlyRecent = true;

                DialogResult drOnlyRecent = MessageBox.Show("Want to Restrict copy of recent files only?", "Warning", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (drOnlyRecent == DialogResult.No)
                {
                    //OnlyRecent = false;
                    cbOnlyRecent.Checked = false;
                }

                //Sort entries in source and target array lists 
                alSrc.Sort(mySorter);
                alDest.Sort(mySorter);
                srcFylCount = alSrc.Count > alDest.Count ? alSrc.Count : alDest.Count;
                for (s = 0, d = 0; s < alSrc.Count && d < alDest.Count; )
                {
                    sfl = new FileInfo(alSrc[s].ToString());
                    dfl = new FileInfo(alDest[d].ToString());
                    sflName = alSrc[s].ToString().Substring(tbSrc.Text.Length + 1); //sfl.FullName;
                    dflName = alDest[d].ToString().Substring(tbDest.Text.Length + 1); //dfl.FullName;

                    //if (!backgroundWorker1.IsBusy)
                    //    backgroundWorker1.RunWorkerAsync();

                    if (String.Compare(dflName, sflName, true) == 0)  //(dflName == sflName)
                    {
                        //Check and bypass if directory
                        fAttr = File.GetAttributes(alSrc[s].ToString());
                        if ((fAttr & FileAttributes.Directory) != FileAttributes.Directory)
                        {
                            //if date of modification or length is different then add to changed file list
                            if (sfl.Length != dfl.Length || sfl.LastWriteTime != dfl.LastWriteTime)
                            {
                                //clbCDFiles.ForeColor = System.Drawing.Color.Cyan;
                                string sMsg = "; [CD-" + sfl.LastWriteTime.ToString() + " Ln-";
                                string dMsg = "; [CD-" + dfl.LastWriteTime.ToString() + " Ln-";
                                if (sfl.Length > 999 && sfl.Length < 1000000)
                                {
                                    sMsg += sfl.Length / 1000 + "KB]";
                                    dMsg += dfl.Length / 1000 + "KB]";
                                }
                                else
                                {
                                    sMsg += sfl.Length / 1000000 + "MB]";// = sLen / 1000000;
                                    dMsg += dfl.Length / 1000000 + "MB]";
                                }
                                chngFyles.Add(sfl.FullName + sMsg,true); // "; [CD-" + sfl.LastWriteTime.ToString() + " Ln-" + sfl.Length / 1000 + "KB]", true);
                                chngDFyles.Add(dfl.FullName + dMsg, false); //"; [CD-" + dfl.LastWriteTime.ToString() + " Ln-" + dfl.Length / 1000 + "KB]", false);

                                if (cbOnlyRecent.Checked == false)
                                {
                                    if (sfl.LastWriteTime < dfl.LastWriteTime || sfl.CreationTime < dfl.CreationTime)
                                    {
                                        LogFile.writeLog("Destination - " + alDest[d].ToString() + " - is more recent than the source file!");
                                        rtLogView.SelectionColor = Color.Red;
                                        rtLogView.AppendText("Destination - " + alDest[d].ToString() + " - is more recent than the source file! Check it\n");
                                        DialogResult Res = MessageBox.Show("Destination file - " + alDest[d].ToString() + " - is more recent file!!"
                                            + "\nDo you want to copy older file??", "Critical Warning", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                                        if (Res == DialogResult.No)
                                        {
                                            LogFile.writeLog("Copy of " + alDest[d].ToString() + " is discarded by user");
                                            rtLogView.AppendText("Copy of " + alDest[d].ToString() + " is discarded by user\n");
                                            clbCFiles.SetItemCheckState(clbCFiles.Items.Count - 1, CheckState.Unchecked);
                                        }
                                        rtLogView.SelectionColor = Color.Black;
                                    }
                                }
                                lblChngFyl.Text = "Changed Files: (" + (++chngFylCount).ToString() + ")";
                            }
                            if (rbBackUp.Checked)
                            {
                                alDFyles.Add(dfl.FullName, false);
                                alFyles.Add(sfl.FullName, true);
                            }
                            if (rbBackUp.Checked)
                                lblAllFyl.Text = "All Files   (" + (++alFylCount).ToString() + ")";
                        }
                        ++s;
                        ++d;
                        ProgVal = (++SrcFylCur * 100) / srcFylCount;
                        pbOP.Value = ProgVal;
                        this.Text = "SafeBackUp " + ProgVal.ToString() + "%";
                        lblProg.Text = "Analyzing... " + ProgVal.ToString() + "%";
                        Application.DoEvents();
                        //if (!backgroundWorker1.CancellationPending)
                        //    backgroundWorker1.ReportProgress(SrcFylCur * 100 / srcFylCount, "Analysing...");
                    }
                    else if (String.Compare(dflName, sflName, true) > 0) //(dflName. > sflName) //new file
                    {
                        newFyles.Add(sfl.FullName, true);
                        newDFyles.Add(tbDest.Text + alSrc[s].ToString().Substring(tbSrc.Text.Length), false);
                        if (rbBackUp.Checked)
                        {
                            alDFyles.Add(sfl.FullName, false);
                            alFyles.Add(sfl.FullName, true);
                        }
                        if (rbBackUp.Checked)
                            lblAllFyl.Text = "All Files   (" + (++alFylCount).ToString() + ")";
                        lblNewFyl.Text = "New Files: (" + (++newFylCount).ToString() + ")";
                        ++s;
                        ProgVal = (++SrcFylCur * 100) / ++srcFylCount;
                        pbOP.Value = ProgVal;
                        this.Text = "SafeBackUp " + ProgVal.ToString() + "%";
                        lblProg.Text = "Analyzing... " + ProgVal.ToString() + "%";
                        Application.DoEvents();

                        //if (!backgroundWorker1.CancellationPending)
                        //    backgroundWorker1.ReportProgress(SrcFylCur * 100 / srcFylCount, "Analysing...");
                    }
                    else //destFyl < srcFyl - file not in source - deleted file
                    {
                        //Add to del file list
                        if (rbBackUp.Checked)
                        {   //Inform deleted files - no action
                            alDFyles.Add(dfl.ToString() + " - Not in source - no action", false);
                            lblAllFyl.Text = "All Files   (" + (++alFylCount).ToString() + ")";
                        }
                        else if (rbSync.Checked) //list files to be deleted
                        {
                            alDFyles.Add(dfl.ToString(), true);
                            lblAllFyl.Text = "Delete Files(" + (++alFylCount).ToString() + ")";
                        }
                        ++d;
                        //if (!backgroundWorker1.CancellationPending)
                        //    backgroundWorker1.ReportProgress(SrcFylCur * 100 / srcFylCount, "Analysing...");
                        ProgVal = (++SrcFylCur * 100) / srcFylCount;
                        pbOP.Value = ProgVal;
                        this.Text = "SafeBackUp " + ProgVal.ToString() + "%";
                        lblProg.Text = "Analyzing... " + ProgVal.ToString() + "%";
                        Application.DoEvents();
                    }
                }

                while (s < alSrc.Count)
                {

                    //show rest of the source files as new and display
                    newFyles.Add(alSrc[s].ToString(), true);
                    //*********** Dest dir to be added to src file names
                    newDFyles.Add(tbDest.Text + alSrc[s].ToString().Substring(tbSrc.Text.Length), false);
                    if (rbBackUp.Checked)
                    {
                        alFyles.Add(alSrc[s].ToString(), true);
                    }
                    ++s;
                    lblNewFyl.Text = "New Files: (" + (++newFylCount).ToString() + ")";
                    if (rbBackUp.Checked)
                        lblAllFyl.Text = "All Files   (" + (++alFylCount).ToString() + ")";
                    //if (!backgroundWorker1.CancellationPending)
                    //    backgroundWorker1.ReportProgress(SrcFylCur * 100 / srcFylCount, "Analysing...");
                    ProgVal = (++SrcFylCur * 100) / ++srcFylCount;
                    pbOP.Value = ProgVal;
                    this.Text = "SafeBackUp " + ProgVal.ToString() + "%";
                    lblProg.Text = "Analyzing... " + ProgVal.ToString() + "%";
                    Application.DoEvents();
                }
                while (d < alDest.Count)
                {
                    //show rest of the dest files as deleted and show
                    if (rbBackUp.Checked)
                    {   //Inform deleted files - no action
                        alDFyles.Add(alDest[d].ToString() + " - Not in source - no action", false);
                        lblAllFyl.Text = "All Files   (" + (++alFylCount).ToString() + ")";
                    }
                    else if (rbSync.Checked) //list files to be deleted
                    {
                        alDFyles.Add(alDest[d].ToString(), true);
                        lblAllFyl.Text = "Delete Files(" + (++alFylCount).ToString() + ")";
                    }
                    ++d;
                    //if (!backgroundWorker1.CancellationPending)
                    //    backgroundWorker1.ReportProgress(SrcFylCur * 100 / srcFylCount, "Analysing...");
                    ProgVal = (++SrcFylCur * 100) / srcFylCount;
                    pbOP.Value = ProgVal;
                    this.Text = "SafeBackUp " + ProgVal.ToString() + "%";
                    lblProg.Text = "Analyzing... " + ProgVal.ToString() + "%";
                    Application.DoEvents();
                }
                endOfAnalysis();
            }
            #endregion

            #region commented
            //backgroundWorker1.RunWorkerAsync();
            //this.Text = "SafeBackUp";
            //lblProg.Text = "Analyzed... 100%";
            //pbOP.Value = 100;
            //rtLogView.AppendText(DateTime.Now + "  Analysis done...\n");
            //Application.DoEvents();
            //MessageBox.Show("Analysis Complete");
            //Analyzing = false;
            //btnAnalyse.Enabled = true;
            #endregion

            if (rbCpyDir.Checked || rbMovFyl.Checked)
            {
                // call frmFileSelect
                frmFileSelect SelectFyl = new frmFileSelect();
                SelectFyl.strCopyDir = tbSrc.Text;
                SelectFyl.strTarDir = tbDest.Text;
                if (rbCpyDir.Checked)
                    SelectFyl.blCpyFyl = true;
                else
                    SelectFyl.blCpyFyl = false;
                SelectFyl.ShowDialog();  //for modal form show
                endOfAnalysis();
            }
        }

        private void endOfAnalysis()
        {
            this.Text = "SafeBackUp";
            if (rbBackUp.Checked || rbSync.Checked)
            {
                lblProg.Text = "Analyzed... 100%";
                MessageBox.Show("Analysis Complete");
                LogFile.writeLog(DateTime.Now + " Analysis done");
                rtLogView.AppendText(DateTime.Now + "  Analysis done...\n");
            }
            else if (rbCpyDir.Checked)
            {
                lblProg.Text = "Copied... 100%";
                MessageBox.Show("CopyFolder Complete");
                LogFile.writeLog(DateTime.Now + " CopyFolder done");
                rtLogView.AppendText(DateTime.Now + "  CopyFolder done...\n");
            }
            else if (rbMovFyl.Checked)
            {
                lblProg.Text = "Moved... 100%";
                MessageBox.Show("MoveFolder Complete");
                LogFile.writeLog(DateTime.Now + " MoveFolder done");
                rtLogView.AppendText(DateTime.Now + "  MoveFolder done...\n");
            }
            pbOP.Value = 100;
            
            Application.DoEvents();
            Analyzing = false;
            btnAnalyse.Enabled = true;
        }

        private void btnProc_Click(object sender, EventArgs e)
        {
            pbOP.Value = 0;
            lblProg.Text = "";

            rtLogView.AppendText(DateTime.Now + " Copying Started...\n");
            LogFile.writeLog(DateTime.Now + " Copying Started");
            Application.DoEvents();
            if (rbMovFyl.Checked)
            {
                //Copy file to destination directory}
                foreach (string file in alSrc)
                {
                    try
                    {
                        FileInfo fyl = new FileInfo(file);

                        rtLogView.AppendText("Copying file " + fyl.Name + "...\n");
                        LogFile.writeLog("Copying file " + fyl.Name);
                        fyl.CopyTo(tbDest.Text + "\\" + fyl.Name, cbOverwrite.Checked);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                MessageBox.Show("File copy done...");
                return;
            }
            if (rbBackUp.Checked || rbSync.Checked)
            {
                string DstPath = "";
                string SrcPath = "";
                FileAttributes fAttr;
                FileInfo Srcfyl;
                FileInfo Dstfyl;
                int totItems = clbNFiles.Items.Count;

                //copy the checked files from source to destination
                foreach (int chk in clbNFiles.CheckedIndices)
                {
                    DstPath = clbNDFiles.Items[chk].ToString();
                    SrcPath = clbNFiles.Items[chk].ToString();
                    fAttr = File.GetAttributes(SrcPath);
                    if ((fAttr & FileAttributes.Directory) == FileAttributes.Directory)
                    {
                        try
                        {
                            if (!Directory.Exists(DstPath))
                            {
                                Directory.CreateDirectory(DstPath);
                                clbNDFiles.SetItemCheckState(chk, CheckState.Checked);
                                LogFile.writeLog("Created folder " + DstPath);
                                rtLogView.AppendText("Created folder " + DstPath + "\n");
                                pbOP.Value = (chk + 1) * 100 / totItems;
                                lblProg.Text = "New File Copied " + pbOP.Value + "%";
                                Application.DoEvents();
                            }

                        }
                        catch (UnauthorizedAccessException uEx)
                        {
                            MessageBox.Show("File access not authorised for " + clbNFiles.Items[chk].ToString());
                            LogFile.writeLog("Access denied for " + clbNFiles.Items[chk].ToString());
                            rtLogView.AppendText("Access denied for " + clbNFiles.Items[chk].ToString() + "\n");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            LogFile.writeLog(ex.Message + " for " + clbNFiles.Items[chk].ToString());
                            rtLogView.AppendText(ex.Message + " for " + clbNFiles.Items[chk].ToString() + "\n");
                        }
                    }
                    else
                    {
                        try
                        {
                            Srcfyl = new FileInfo(SrcPath);
                            Srcfyl.CopyTo(DstPath, false);
                            Dstfyl = new FileInfo(DstPath);
                            Dstfyl.CreationTime = Srcfyl.CreationTime;
                            Dstfyl.LastWriteTime = Srcfyl.LastWriteTime;
                            Dstfyl.LastAccessTime = Dstfyl.LastAccessTime;
                            LogFile.writeLog("Copied file    " + Srcfyl.FullName + " to " + Dstfyl.FullName);
                            rtLogView.AppendText("Copied file    " + Srcfyl.FullName + " to " + Dstfyl.FullName + "\n");
                            clbNDFiles.SetItemCheckState(chk, CheckState.Checked);
                            pbOP.Value = (chk + 1) * 100 / totItems;
                            lblProg.Text = "New File Copied " + pbOP.Value + "%";
                            Application.DoEvents();
                        }
                        catch (UnauthorizedAccessException uEx)
                        {
                            LogFile.writeLog("Access denied for " + clbNFiles.Items[chk].ToString());
                            rtLogView.AppendText("Access denied for " + clbNFiles.Items[chk].ToString() + "\n");
                            MessageBox.Show("Access not authorised for file " + clbNFiles.Items[chk].ToString() + "\n");
                        }
                        catch (Exception ex)
                        {
                            LogFile.writeLog(ex.Message + " for " + clbNFiles.Items[chk].ToString());
                            rtLogView.AppendText(ex.Message + " for " + clbNFiles.Items[chk].ToString() + "\n");
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                lblProg.Text = "New File Copied 100%";
                WasteTimer();
                totItems = clbCFiles.Items.Count;
                foreach (int chk in clbCFiles.CheckedIndices)
                {
                    DstPath = clbCDFiles.Items[chk].ToString().Substring(0,clbCDFiles.Items[chk].ToString().IndexOf(';'));
                    SrcPath = clbCFiles.Items[chk].ToString().Substring(0, clbCFiles.Items[chk].ToString().IndexOf(';'));
                    try
                    {
                        Srcfyl = new FileInfo(SrcPath);
                        Srcfyl.CopyTo(DstPath, true);
                        Dstfyl = new FileInfo(DstPath);
                        Dstfyl.CreationTime = Srcfyl.CreationTime;
                        Dstfyl.LastWriteTime = Srcfyl.LastWriteTime;
                        Dstfyl.LastAccessTime = Dstfyl.LastAccessTime;
                        LogFile.writeLog("Copied file    " + Srcfyl.FullName + " to " + Dstfyl.FullName);
                        rtLogView.AppendText("Copied file    " + Srcfyl.FullName + " to " + Dstfyl.FullName + "\n");
                        clbCDFiles.SetItemCheckState(chk, CheckState.Checked);
                        pbOP.Value = (chk + 1) * 100 / totItems;
                        lblProg.Text = "Changed File Copied " + pbOP.Value + "%";
                        Application.DoEvents();
                    }
                    catch (UnauthorizedAccessException uEx)
                    {
                        LogFile.writeLog("Access denied for " + clbCFiles.Items[chk].ToString());
                        rtLogView.AppendText("Access denied for " + clbCFiles.Items[chk].ToString() + "\n");
                        MessageBox.Show("Access denied for file " + clbCFiles.Items[chk].ToString());
                    }
                    catch (Exception ex)
                    {
                        LogFile.writeLog(ex.Message + " for " + clbCFiles.Items[chk].ToString());
                        rtLogView.AppendText(ex.Message + " for " + clbCFiles.Items[chk].ToString() + "\n");
                        MessageBox.Show(ex.Message);
                    }
                }
                lblProg.Text = "Changed File Copied 100%";
                WasteTimer();
                totItems = clbADFiles.Items.Count;
                if (rbSync.Checked)
                {
                    foreach (int chk in clbADFiles.CheckedIndices)
                    {
                        try
                        {
                            Srcfyl = new FileInfo(clbADFiles.Items[chk].ToString());
                            Srcfyl.Delete();
                            LogFile.writeLog("Deleted file   " + Srcfyl.FullName);
                            rtLogView.AppendText("Deleted file   " + Srcfyl.FullName + "\n");
                            pbOP.Value = (chk + 1) * 100 / totItems;
                            lblProg.Text = "Deleted files " + pbOP.Value + "%";
                            Application.DoEvents();
                        }
                        catch (UnauthorizedAccessException uEx)
                        {
                            LogFile.writeLog("Access denied for " + clbADFiles.Items[chk].ToString());
                            rtLogView.AppendText("Access denied for " + clbADFiles.Items[chk].ToString() + "\n");
                            MessageBox.Show("The file " + clbADFiles.Items[chk].ToString() + " cannot be deleted - not authorized!\n" + uEx.Message);
                        }
                        catch (Exception ex)
                        {
                            LogFile.writeLog(ex.Message + " for " + clbADFiles.Items[chk].ToString());
                            rtLogView.AppendText(ex.Message + " for " + clbADFiles.Items[chk].ToString()+"\n");
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            LogFile.writeLog(DateTime.Now + " Copying Done");
            rtLogView.AppendText(DateTime.Now + " Copying Done...\n");
            MessageBox.Show("Copy Done");
        }

        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            if (fullScreenMode == FullScreenMode.No)  // FullScreenMode is an enum
            {
                fullScreen.EnterFullScreenMode(this);
                fullScreenMode = FullScreenMode.Yes;
            }
            else
            {
                fullScreen.LeaveFullScreenMode(this);
                fullScreenMode = FullScreenMode.No;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void clearAll() {
            tbDest.Text = "";
            tbSrc.Text = "";
            int count;
            clbADFiles.Items.Clear();
            clbAFiles.Items.Clear();
            clbCDFiles.Items.Clear();
            clbCFiles.Items.Clear();
            clbNDFiles.Items.Clear();
            clbNFiles.Items.Clear();
            count = clbCDFiles.Items.Count;
            pbOP.Value = 0;
            lblAllFyl.Text = "All Files:   ";
            lblChngFyl.Text = "Change Files:";
            lblNewFyl.Text = "New Files:";
            lblProg.Text = "";
            Analyzing = false;
            //backgroundWorker1.CancelAsync();
        }
        
        private void clrClbItems(int count, CheckedListBox clb)
        {
            int i;
            for (i = count; i > 0; --i)
                clb.Items.RemoveAt(i - 1);
        }

        private void SafeBackUp_Load(object sender, EventArgs e)
        {
            //backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int srcFylCount = 0;
            int SrcFylCur = 0;
            
            //Thread.Sleep(100);
            //BackgroundWorker bgw = sender as BackgroundWorker;
            //if (bgw == null)
            //    backgroundWorker1.RunWorkerAsync();
            //if (!backgroundWorker1.CancellationPending)
            //    backgroundWorker1.ReportProgress(SrcFylCur * 100 / srcFylCount,"Analysing...");
//**************************
            if (rbBackUp.Checked || rbSync.Checked)
            {
                var newFyles = clbNFiles.Items;
                var chngFyles = clbCFiles.Items;
                var alFyles = clbAFiles.Items;
                var newDFyles = clbNDFiles.Items;
                var chngDFyles = clbCDFiles.Items;
                var alDFyles = clbADFiles.Items;
                //int newFylCount = 0;
                //int chngFylCount = 0;
                //int alFylCount = 0;
                int s = 0, d = 0;
                FileInfo sfl;
                FileInfo dfl;
                string sflName, dflName;

                //Sort entries in source and target array lists 
                alSrc.Sort();
                alDest.Sort();
                srcFylCount = alSrc.Count > alDest.Count ? alSrc.Count : alDest.Count;
                for (s = 0, d = 0; s < alSrc.Count && d < alDest.Count; )
                {
                    sfl = new FileInfo(alSrc[s].ToString());
                    dfl = new FileInfo(alDest[d].ToString());
                    sflName = sfl.Name;
                    dflName = dfl.Name;

                    if (String.Compare(dflName, sflName) == 0)  //(dflName == sflName)
                    {
                        //Check and bypass if directory
                        FileAttributes fAttr = File.GetAttributes(alSrc[s].ToString());
                        if ((fAttr & FileAttributes.Directory) != FileAttributes.Directory)
                        {
                            //if date of creation or length is different then add to changed file list
                            if (sfl.Length != dfl.Length || sfl.CreationTime != dfl.CreationTime)
                            {
                                //clbCDFiles.ForeColor = System.Drawing.Color.Cyan;
                                chngFyles.Add(sfl.FullName + "; [CD-" + sfl.CreationTime.ToString() + " Ln-" + sfl.Length / 1000 + "KB]", true);
                                chngDFyles.Add(dfl.FullName + "; [CD-" + dfl.CreationTime.ToString() + " Ln-" + dfl.Length / 1000 + "KB]", false);
                            }
                            if (rbBackUp.Checked)
                            {
                                alDFyles.Add(dfl.FullName, false);
                                alFyles.Add(sfl.FullName, true);
                            }
                            ++chngFylCount;
                            if (rbBackUp.Checked)
                                ++alFylCount;
                            //lblChngFyl.Text = "Changed Files: (" + (++chngFylCount).ToString() + ")";
                            //if (rbBackUp.Checked)
                            //    lblAllFyl.Text = "All Files   (" + (++alFylCount).ToString() + ")";
                            //Application.DoEvents();
                        }
                        ++s;
                        ++d;
                        ++SrcFylCur;
                        if (!backgroundWorker1.CancellationPending)
                            backgroundWorker1.ReportProgress(SrcFylCur * 100 / srcFylCount, "Analysing...");
                    }
                    else if (String.Compare(dflName, sflName) > 1) //(dflName. > sflName) //new file
                    {
                        newFyles.Add(sfl.FullName, true);
                        newDFyles.Add(tbDest.Text + alSrc[s].ToString().Substring(tbSrc.Text.Length), false);
                        if (rbBackUp.Checked)
                        {
                            alDFyles.Add(sfl.FullName, false);
                            alFyles.Add(sfl.FullName, true);
                            ++alFylCount;
                        }
                        //if (rbBackUp.Checked)
                        //    lblAllFyl.Text = "All Files   (" + (++alFylCount).ToString() + ")";
                        //lblNewFyl.Text = "New Files: (" + (++newFylCount).ToString() + ")";
                        //Application.DoEvents();
                        ++s;
                        ++SrcFylCur;
                        ++newFylCount;
                        if (!backgroundWorker1.CancellationPending)
                            backgroundWorker1.ReportProgress(SrcFylCur * 100 / srcFylCount, "Analysing...");
                    }
                    else //destFyl < srcFyl - file not in source - deleted file
                    {
                        //Add to del file list
                        if (rbBackUp.Checked)
                        {   //Inform deleted files - no action
                            alDFyles.Add(dfl.ToString() + " - Not in source - no action", false);
                            //lblAllFyl.Text = "All Files   (" + (++alFylCount).ToString() + ")";
                        }
                        else if (rbSync.Checked) //list files to be deleted
                        {
                            alDFyles.Add(dfl.ToString(), true);
                            //lblAllFyl.Text = "Delete Files(" + (++alFylCount).ToString() + ")";
                        }
                        ++d;
                        ++SrcFylCur;
                        ++alFylCount;
                        if (!backgroundWorker1.CancellationPending)
                            backgroundWorker1.ReportProgress(SrcFylCur * 100 / srcFylCount, "Analysing...");
                    }
                }

                while (s < alSrc.Count)
                {

                    //show rest of the source files as new and display
                    newFyles.Add(alSrc[s].ToString(), true);
                    //*********** Dest dir to be added to src file names
                    newDFyles.Add(tbDest.Text + alSrc[s].ToString().Substring(tbSrc.Text.Length), false);
                    //newDFyles.Add(alSrc[s].ToString(), true);
                    if (rbBackUp.Checked)
                    {
                        alFyles.Add(alSrc[s].ToString(), true);
                        //alDFyles.Add(alSrc[s].ToString(), true);
                        ++alFylCount;
                    }
                    ++s;
                    ++SrcFylCur;
                    ++newFylCount;
                    //lblNewFyl.Text = "New Files: (" + (++newFylCount).ToString() + ")";
                    //if (rbBackUp.Checked)
                    //    lblAllFyl.Text = "All Files   (" + (++alFylCount).ToString() + ")";
                    //Application.DoEvents();
                    if (!backgroundWorker1.CancellationPending)
                        backgroundWorker1.ReportProgress(SrcFylCur * 100 / srcFylCount, "Analysing...");
                }
                while (d < alDest.Count)
                {
                    //show rest of the dest files as deleted and show
                    //if (rbBackUp.Checked)    //Inform deleted files - no action
                    //    alFyles.Add("Target-" + alDest[d].ToString() + " - Not in source - no action", false);
                    //else if (rbSync.Checked) //list files to be deleted
                    //    alFyles.Add(alDest[d].ToString(), true);
                    if (rbBackUp.Checked)
                    {   //Inform deleted files - no action
                        alDFyles.Add(alDest[d].ToString() + " - Not in source - no action", false);
                        //lblAllFyl.Text = "All Files   (" + (++alFylCount).ToString() + ")";
                    }
                    else if (rbSync.Checked) //list files to be deleted
                    {
                        alDFyles.Add(alDest[d].ToString(), true);
                        //lblAllFyl.Text = "Delete Files(" + (++alFylCount).ToString() + ")";
                    }
                    ++alFylCount;
                    ++SrcFylCur;
                    ++d;
                    //Application.DoEvents();
                    if (!backgroundWorker1.CancellationPending)
                        backgroundWorker1.ReportProgress(SrcFylCur * 100 / srcFylCount, "Analysing...");
                }
            }

//**************************
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
	        // Change the value of the ProgressBar to the BackgroundWorker progress.
	        pbOP.Value = e.ProgressPercentage;
            if (rbBackUp.Checked)
                lblAllFyl.Text = "Delete Files(" + (alFylCount).ToString() + ")";
            if (rbSync.Checked)
                lblAllFyl.Text = "All Files   (" + (alFylCount).ToString() + ")";
            lblNewFyl.Text = "New Files: (" + (newFylCount).ToString() + ")";
            lblChngFyl.Text = "Changed Files: (" + (chngFylCount).ToString() + ")";
            this.Text = "SafeBackUp " + e.ProgressPercentage.ToString() + "%";
            lblProg.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //if (e.Error==null && !!e.Cancelled)
            //backgroundWorker1.ReportProgress(100, "Analysis Complete...");
            this.Text = "SafeBackUp";
            lblProg.Text = "100%";
            //Application.DoEvents();
            rtLogView.AppendText(DateTime.Now + "  Analysis done...\n");
            MessageBox.Show("Analysis Complete");
            Analyzing = false;
        }

        private void cbNDselct_Click(object sender, EventArgs e)
        {
            if (cbNDselct.Checked.Equals(true))
            {
                foreach (int chk in clbNFiles.CheckedIndices)
                    clbNFiles.SetItemCheckState(chk, CheckState.Unchecked);
            }
            else
            {
                for (int chk = clbNFiles.Items.Count; chk > 0; --chk)
                    clbNFiles.SetItemCheckState(chk - 1, CheckState.Checked);
            }
        }

        private void cbCDeslct_Click(object sender, EventArgs e)
        {
            if (cbCDeslct.Checked.Equals(true))
            {
                foreach (int chk in clbCFiles.CheckedIndices)
                    clbCFiles.SetItemCheckState(chk, CheckState.Unchecked);
            }
            else
            {
                for (int chk = clbCFiles.Items.Count; chk > 0; --chk)
                    clbCFiles.SetItemCheckState(chk - 1, CheckState.Checked);
            }
        }

        private void cbADeslct_Click(object sender, EventArgs e)
        {
            if (cbADeslct.Checked.Equals(true))
            {
                foreach (int chk in clbADFiles.CheckedIndices)
                    clbADFiles.SetItemCheckState(chk, CheckState.Unchecked);
            }
            else
            {
                for (int chk = clbADFiles.Items.Count; chk > 0; --chk)
                    clbADFiles.SetItemCheckState(chk - 1, CheckState.Checked);
            }
        }

        //private void clbADFiles_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SafeBackUp V1.01\nDesigned and Developed by\nBidyut Chakraborty","About SafeBackUp");
        }

        private void WasteTimer()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; ; ++i)
            {
                if (i % 1000 == 0)
                {
                    sw.Stop();
                    if (sw.ElapsedMilliseconds == 5000)
                        break;
                    else
                        sw.Start();
                }
            }
        }

        private void rbCpyDir_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCpyDir.Checked)
            {
                btnAnalyse.Text = "Go Copy";
            }
            else
            {
                btnAnalyse.Text = "Analyse";
            }
        }

        private void rbCpyFyl_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMovFyl.Checked)
            {
                btnAnalyse.Text = "Go Move";
            }
            else
            {
                btnAnalyse.Text = "Analyse";
            }
        }

            
        //private void cbNDselct_CheckedChanged(object sender, EventArgs e)
        //{
        //    clbNFiles.ClearSelected();
        //}
        //private void clbNDFiles_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    clbADFiles.SelectionMode = SelectionMode.None;
        //}
    }
}