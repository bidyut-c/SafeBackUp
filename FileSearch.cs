using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafeBackUp
{
    public static class FileSearch
    {
        /// <summary>
        /// Get the list of files within root and subdirectories (if any)
        /// for back up, synchronise or copy
        /// </summary>
        /// <param name="strPath"></param>
        /// <param name="isFile"></param>
        public static ArrayList GetFilesList(string strPath)
        {
            ArrayList alFyles = new ArrayList();
            //alFyles.Add(strPath);
            DirectoryInfo dir = new DirectoryInfo(strPath);

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                alFyles.Add(file.FullName);
            }

            DirectoryInfo[] dirSubs = dir.GetDirectories();
            foreach (DirectoryInfo dirSub in dirSubs)
            {
                if ((dirSub.Attributes & FileAttributes.Hidden) != 0)
                    continue;
                alFyles.Add(dirSub.FullName);
                GetSubDirectoryNodes(alFyles, dirSub.FullName);
            }
            return alFyles;
        }


        /// <summary>
        /// Get all subdirctories below the passed directory node
        /// Then add to Array List.
        /// </summary>
        /// <param name="alFyles"></param>
        /// <param name="fullName"></param>
        public static void GetSubDirectoryNodes(ArrayList alFyles, string fullName)
        {
            DirectoryInfo dir = new DirectoryInfo(fullName);
            DirectoryInfo[] dirSubs = dir.GetDirectories();

            foreach (DirectoryInfo dirSub in dirSubs)
            {
                if ((dirSub.Attributes & FileAttributes.Hidden) != 0)
                    continue;
                alFyles.Add(dirSub.FullName);
                GetSubDirectoryNodes(alFyles, dirSub.FullName);
            }

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                alFyles.Add(file.FullName);
            }
        }
    }
}
