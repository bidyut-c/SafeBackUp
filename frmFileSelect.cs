using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SafeBackUp
{
    public partial class frmFileSelect : Form
    {
        public string strCopyDir { get; set; }
        public string strTarDir { get; set; }
        public bool blCpyFyl { get; set; }
        private bool setCheck = false;

        public class FileComparer : IComparer
        {  //Sort files as per lengths for compact copy
            public int Compare(object f1, object f2)
            {
                FileInfo file1 = (FileInfo)f1;
                FileInfo file2 = (FileInfo)f2;
                if (file1.Length > file2.Length)
                {
                    return -1;
                }
                else if (file1.Length < file2.Length)
                {
                    return 1;
                }
                return 0;
            }
        }

        public frmFileSelect()
        {
            InitializeComponent();
        }

        private void frmFileSelect_Load(object sender, EventArgs e)
        {
            lblTrgDir.Text = strTarDir;
            //if copy or move change button text
            if (blCpyFyl)
            {
                btnCopy.Text = "Copy";
            }
            else
            {
                btnCopy.Text = "Move";
            }
            FillDirectoryTree();
        }

        private void FillDirectoryTree()
        {
            //clear all nodes
            tvuFolder.Nodes.Clear();
            TreeNode ndRoot = new TreeNode(strCopyDir);
            ndRoot.Checked = true;
            tvuFolder.Nodes.Add(ndRoot);
            pbPr.Value = 0;
            //pbPr.MarqueeAnimationSpeed = 50;
            GetSubDirectoryNodes(ndRoot, ndRoot.Text);
            pbPr.Value = 100;
            //pbPr.MarqueeAnimationSpeed = 0;
        }

        private void GetSubDirectoryNodes(TreeNode parentNode, string fullName)
        {
            DirectoryInfo dir = new DirectoryInfo(fullName);
            DirectoryInfo[] dirSubs = dir.GetDirectories();
            foreach (DirectoryInfo dirSub in dirSubs)
            {
                //bypass hidden directories
                if ((dirSub.Attributes & FileAttributes.Hidden) != 0)
                {
                    continue;
                }
                TreeNode subNode = new TreeNode(dirSub.Name);
                subNode.Checked = true;
                parentNode.Nodes.Add(subNode);
                GetSubDirectoryNodes(subNode, dirSub.FullName);
            }
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                TreeNode fileNode = new TreeNode(file.Name);
                fileNode.Checked = true;
                parentNode.Nodes.Add(fileNode);
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            ArrayList fileList = GetFileList();
            int fileTot = fileList.Count;
            int fileCpy = 0;
            pbPr.Value = 0;
            //pbPr.MarqueeAnimationSpeed = 50;
            //Copy the files
            foreach (FileInfo file in fileList)
            {
                try
                {
                    //if directory and copy with sub directory checked then
                    //create directory (if file dont exist - then directory)
                    //else copy the file to its destination
                    string destPath = strTarDir;
                    
                    if (cbWSDir.Checked)
                    {
                        destPath +=  Path.GetDirectoryName(file.FullName).Substring(strCopyDir.Length);
                        if (!Directory.Exists(destPath))
                        {
                            Directory.CreateDirectory(destPath);
                        }
                    }
                    file.CopyTo(Path.Combine(destPath, file.Name), cbOvrWrite.Checked);
                    
                    //update the label to show progress
                    pbPr.Value = (++fileCpy * 100) / fileTot;
                    LogFile.writeLog(Path.Combine(destPath, file.Name) + " copied");
                    rtbLog.AppendText(Path.Combine(destPath,file.Name) + " copied\n");
                    Application.DoEvents();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File " + strTarDir + "\\" + file.Name + " could not be copied\n"
                        + ex.Message);
                    LogFile.writeLog(ex.Message);
                    rtbLog.AppendText(ex.Message + "\n");
                }
            }
            pbPr.Value = 100;
            //pbPr.MarqueeAnimationSpeed = 0;
            MessageBox.Show("Files Copied");
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            ArrayList fileList = GetFileList();
            int fileTot = fileList.Count;
            int fileCpy = 0;
            pbPr.Value = 0;
            string msg;

            // Use btnCopy_Click process to copy file to destination
            btnCopy_Click(sender, e);
            // From btnDel_Click function copy the deletion process from source
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            ArrayList fileList = GetFileList();
            int fileTot = fileList.Count;
            int fileCpy = 0;
            pbPr.Value = 0;
            string msg;

            msg = "Are you sure to delete all files";
            if (cbWSDir.Checked)
            {
                msg += " and folders";
            }
            msg += "??";
            System.Windows.Forms.DialogResult ans = MessageBox.Show(msg, "Delete Files/Folders",
                                                    MessageBoxButtons.OKCancel, 
                                                    MessageBoxIcon.Exclamation, 
                                                    MessageBoxDefaultButton.Button2);

            if (ans == DialogResult.OK)
            {
        //Check if directory is empty before deleting it
        //If there is subdirectory, recursively delete that first
                ArrayList dirList = new ArrayList();
                foreach (FileInfo file in fileList)
                {
                    dirList.Add(Path.GetDirectoryName(file.FullName));
                    try
                    {
                        if (file.Exists)
                        {
                            file.Delete();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    pbPr.Value = (++fileCpy * 100) / fileTot;
                    LogFile.writeLog(file.Name + " deleted");
                    rtbLog.AppendText(file.Name + " deleted\n");
                    Application.DoEvents();
                }

                if (cbWSDir.Checked)
                {
                    fileCpy = 0;
                    foreach (string dir in dirList)
                    {
                        try
                        {
                            if (Directory.Exists(dir))
                            {
                                Directory.Delete(dir);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        pbPr.Value = (++fileCpy * 100) / fileTot;
                        LogFile.writeLog(dir + " deleted");
                        rtbLog.AppendText(dir + " deleted\n");
                        Application.DoEvents();
                    }
                }

                MessageBox.Show("Deleted " + fileCpy.ToString() + " Files/Folders");
            }
        }

        private ArrayList GetFileList()
        {
            //create an unsorted array list for full filenames
            ArrayList fileNames = new ArrayList();
            
            //fill array list with fullnames of the files to be copied
            foreach (TreeNode theNode in tvuFolder.Nodes)
            {
                GetCheckedFiles(theNode, fileNames);
            }
            //Create a list to hold the fileinfo objects
            ArrayList fileList = new ArrayList();

            //add all the files (not directory) in filenames
            //to file list
            //but if copy with directory checked, then create directory
            foreach (string fileName in fileNames)
            {
                FileInfo file = new FileInfo(fileName);

                if (file.Exists)
                {
                    fileList.Add(file);
                }
            }

            IComparer comparer = (IComparer)new FileComparer();
            fileList.Sort(comparer);
            return fileList;
        }

        private void GetCheckedFiles(TreeNode node,ArrayList fileNames)
        {
            //if this is a leaf
            if (node.Nodes.Count == 0)
            {
                //if node was checked
                if (node.Checked)
                {
                    //get full path and add to array list
                    string fullPath = GetParentString(node);
                    fileNames.Add(fullPath);
                }
            }
            else //if this node is not a leaf
            {
                foreach (TreeNode n in node.Nodes)
                {
                    GetCheckedFiles(n, fileNames);
                }
            }
        }

        private string GetParentString(TreeNode node)
        {
            TreeNode nd = node;
            string path = "";
            while (nd != null)
            {
                path = nd.Text + (nd.Nodes.Count == 0 ? "" : "\\") + path;
                nd = nd.Parent;
            }
            return path;
        }
        
        void SetCheck(TreeNode node, bool check)
        {
            //static bool setCheck = false;
            if (!setCheck){
                setCheck=true;
                node.Checked = check;
            }
            else
                setCheck=false;
            foreach (TreeNode n in node.Nodes)
            {
                //if child is leaf just check or uncheck it
                //if (node.Nodes.Count == 0)
                if (n.Nodes.Count == 0)
                {
                    n.Checked = check;
                }
                    // recurse if child is a node in the tree
                else
                {
                    SetCheck(n, check);
                }
            }
        }

        private void tvuFolder_AfterCheck(object sender, TreeViewEventArgs e)
        {
            SetCheck(e.Node, e.Node.Checked);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            return;
        }

    }
}
