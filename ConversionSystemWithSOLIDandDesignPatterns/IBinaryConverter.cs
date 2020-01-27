using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionSystemWithSOLIDandDesignPatterns
{
    public interface IBinaryConverter
    {
        string BinaryToText(string binary);
        string TextToBinary(string text);
    }
}
