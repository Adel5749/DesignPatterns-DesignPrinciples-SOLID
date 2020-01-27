using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionSystemWithSOLIDandDesignPatterns
{
    public class HexadecimalConverter : Converter
    {
        public HexadecimalConverter(int decimalNumber) : base(decimalNumber)
        { }
        public override string Convert()
        {
            return $"The result is: {DecimalNumber.ToString("X")}";
        }
    }
}
