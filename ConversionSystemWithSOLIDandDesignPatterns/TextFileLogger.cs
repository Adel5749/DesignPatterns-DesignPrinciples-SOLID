using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConversionSystemWithSOLIDandDesignPatterns
{
    public class TextFileLogger : ILogger
    {
        public void Log(string message)
        {
            using (StreamWriter writer = File.AppendText("logFile.txt"))
            {
                writer.WriteLine(message);
            }
        }
    }
}
