using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionSystemWithSOLIDandDesignPatterns
{
    class ConverterFactory
    {

        public static Converter Create(BaseType baseType, int decimalNumber)
        {
            try
            {
                return (
              Converter)
              Activator.CreateInstance(
              Type.GetType($"SolidSample.{baseType.ToString()}Converter"),
              new object[] { decimalNumber });
            }
            catch (Exception)
            {
                return new InvalidBaseConverter(decimalNumber);
            }
        }
    }
}
