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
            Logger.Log("Enter the base type (Ex: 2,8, 16):");
            var baseType = (BaseType)Reader.ReadInteger();
            string result = String.Empty;

            // After applying Open-Closed principle (Open for extension and closed for modification)
            switch (baseType)
            {
                case BaseType.Binary:
                    var binaryConverter = new BinaryConverter(DecimalNumber);
                    result = binaryConverter.Convert();
                    break;
                case BaseType.Octal:
                    var octalConverter = new OctalConverter(DecimalNumber);
                    result = octalConverter.Convert();
                    break;
                case BaseType.Hexadecimal:
                    var hexadecimalConverter = new
                    HexadecimalConverter(DecimalNumber);
                    result = hexadecimalConverter.Convert();
                    break;
                default:
                    result = "No base found!";
                    break;
            }
            Logger.Log(result);
            Logger.Log("Program is ending..");
        }
    }

}

