using System;
using System.IO;

namespace Logger
{
    public class StackLog
    {
        private static StackLog Instance = null;
        private string FileUrl = "";

        private StackLog()
        {
            //creates directory and/or file if not exist in the debug directory of the calling application
            FileUrl = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/StackLogs";
            Directory.CreateDirectory(FileUrl);
            FileUrl += "/StackLog.txt";
            try
            {
                File.AppendAllText(FileUrl, String.Format("\n=================================================\n"
              + "{0}: Started!", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")));
            }
            catch {  }
        }

        /// <summary>
        /// Returns an instance of this class, creates one if it doesn't exist
        /// </summary>
        /// <returns>StackLog</returns>
        public static StackLog GetInstance()
        {
            if (Instance == null) Instance = new StackLog();
            return Instance;
        }

        /// <summary>
        /// Writes text to a log file
        /// </summary>
        /// <param name="text"></param>
        public void Log(string text)
        {
            try { File.AppendAllText(FileUrl, String.Format("\n{0}: {1}", DateTime.Now.ToString("HH:mm:ss"), text)); }
            catch (IOException ) { }
        }

        //Runs when the object is destroyed, this is to finalize the log file
        ~StackLog()
        {
            try { File.AppendAllText(FileUrl, String.Format("\n{0}: StackLog Exit With Exit Code 0", DateTime.Now.ToString("HH:mm:ss"))); }
            catch { }
        }
    }
}
