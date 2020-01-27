using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionSystemWithSOLIDandDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var consoleLogger = new Logger();

            var converter = new NumberConverter(new TextFileLogger(),
                                                new Reader(consoleLogger),
                                                consoleLogger);

            converter.Convert();
        }
    }
}
