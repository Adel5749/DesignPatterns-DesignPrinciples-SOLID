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
        // Using Reflection with Factory Design Pattern and inversion of control
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
                return null;
            }
        }
    }
}
