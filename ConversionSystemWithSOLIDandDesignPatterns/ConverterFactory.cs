using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionSystemWithSOLIDandDesignPatterns
{
    // Apply Factory Design Pattern
    class ConverterFactory
    {
        public static Converter Create(BaseType baseType, int decimalNumber)
        {
            if (baseType == BaseType.Binary)
            {
                return new BinaryConverter(decimalNumber);
            }
            else if (baseType == BaseType.Octal)
            {
                return new OctalConverter(decimalNumber);
            }
            else if (baseType == BaseType.Hexadecimal)
            {
                return new HexadecimalConverter(decimalNumber);
            }
            else
            {
                return null;
            }
        }
    }
}
