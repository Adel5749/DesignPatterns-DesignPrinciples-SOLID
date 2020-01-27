using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionSystemWithSOLIDandDesignPatterns
{
    public interface IConverter
    {
        string BinaryToText(string binary);
        string TextToBinary(string text);
        string HexadecimalToText(string text);
        string TextToHexadecimal(string text);
    }
}
