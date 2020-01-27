using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionSystemWithSOLIDandDesignPatterns
{
    public enum BaseType
    {
        Binary = 2,
        Octal = 8,
        Hexadecimal = 16,
        None = 0
    }

    class NumberConverter
    {
        public int DecimalNumber { get; set; }
        public Logger Logger { get; set; } = new Logger();
        public Reader Reader { get; set; } = new Reader();

        public void Convert()
        {
            Logger.Log("Program is starting...");
            Logger.Log("Enter the number to convert:");
            DecimalNumber = Reader.ReadInteger();
            Logger.Log("Enter the base type (Ex: 2,8):");
            var baseType = (BaseType)Reader.ReadInteger();
            var type = ConverterFactory.Create(Base, DecimalNumber);
            string result = type.Convert();
            Logger.Log(result);
            Logger.Log("Program is ending..");
        }
    }

}

