using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionSystemWithSOLIDandDesignPatterns
{
    public class Reader : IReader
    {
        public Reader(ILogger logger)
        {
            Logger = logger;
        }

        public ILogger Logger { get; }

        public int ReadInteger()
        {
            try
            {
                string value = Console.ReadLine();
                return int.Parse(value);
            }
            catch (Exception)
            {
                Logger.Log("The entered value is invalid.");
                return 0;
            }

        }
    }
}
