using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Technical_Requirement___intY
{
    //This class is only repsonsible for writing the logs to the .txt file
    public class TextLogger
    {
        private string filePath = "";
        private string logTest = "";

        //Takes the conversion string and adds it to the log file with a timestamp.
        public void LogConversion(string conversion)
        {
            SetFilePath();
            string log = conversion + " : " + DateTime.Now.ToString();

            using ( StreamWriter w = File.AppendText(filePath))
            {
                w.WriteLine(log);
            }
        }

        //The log file should be located in the project directories bin\Debug\netcoreapp3.1\logs.txt
        public void SetFilePath()
        {
            string thisDirectory = System.IO.Directory.GetCurrentDirectory();
            string fileName = "\\logs.txt";

            filePath = thisDirectory + fileName;
        }

        public string GetLog()
        {
            return logTest;
        }


    }
}
