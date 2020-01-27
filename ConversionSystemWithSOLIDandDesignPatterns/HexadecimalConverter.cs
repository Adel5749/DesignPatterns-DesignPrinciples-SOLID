using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionSystemWithSOLIDandDesignPatterns
{
    public class HexadecimalConverter : Converter, IConverter
    {
        public HexadecimalConverter(int decimalNumber) : base(decimalNumber)
        { }
        public override string Convert()
        {
            return $"The result is: {DecimalNumber.ToString("X")}";
        }
        public string HexadecimalToText(string text)
        {
            text = text.Replace(" ", "");
            byte[] raw = new byte[text.Length / 2];
            for (int i = 0; i < raw.Length; i++)
            {
                raw[i] = System.Convert.ToByte(text.Substring(i * 2, 2), 16);
            }
            return Encoding.ASCII.GetString(raw); ;
        }
        public string TextToHexadecimal(string text)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(text);
            var hexString = BitConverter.ToString(bytes);
            hexString = hexString.Replace("-", "");
            return hexString;
        }

        // This method does not have implementation which means violate Liskove Substitution Principle.
        // The solution is to apply Interface Segregation Principle.
        public string TextToBinary(string text)
        {
            throw new NotImplementedException();
        }

        // This method does not have implementation which means violate Liskove Substitution Principle.
        // The solution is to apply Interface Segregation Principle.
        public string BinaryToText(string binary)
        {
            throw new NotImplementedException();
        }
    }
}

