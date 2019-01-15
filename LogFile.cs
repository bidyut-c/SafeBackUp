using System;
using System.IO;

namespace SafeBackUp
{
    class LogFile
    {
        private static string fileName = AppDomain.CurrentDomain.BaseDirectory + "LogFile.txt";


        public static bool writeLog(string txt)
        {
            StreamWriter writer;
            try
            {
                FileInfo logFile = new FileInfo(fileName);
                if (logFile.Exists)
                {
                    writer = new StreamWriter(fileName, true);
                }
                else
                {
                    writer = new StreamWriter(fileName, false);
                }
                writer.WriteLine(txt);
                writer.Close();
                return true;
            }
            catch (IOException exIO)
            {
                System.Windows.Forms.MessageBox.Show(exIO.Message);
                return false;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static void readLog(string txt)
        {
            try
            {
                FileInfo logFile=new FileInfo(fileName);
                if (logFile.Exists)
                {
                    StreamReader reader = logFile.OpenText();
                    txt=reader.ReadLine();
                    reader.Close();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Log File donot exits!!");
                }
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
