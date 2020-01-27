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
            string result = String.Empty;

            // Adding new feature (Hexadecimal) without using Open-Closed Principle.
            switch (baseType)
            {
                case BaseType.Binary:
                    result = System.Convert.ToString(DecimalNumber, 2);
                    break;
                case BaseType.Octal:
                    result = System.Convert.ToString(DecimalNumber, 8);
                    break;
                case BaseType.Hexadecimal:
                    result = DecimalNumber.ToString("X");
                    break;
                default:
                    result = "No base found!";
                    break;
            }
            Logger.Log("The result is: "+ result);
            Logger.Log("Program is ending..");
        }
    }
}

