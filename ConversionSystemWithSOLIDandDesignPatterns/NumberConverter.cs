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
        None = 0
    }

    class NumberConverter
    { 
        public int DecimalNumber { get; set; }

        public void Convert()
        {
            Console.WriteLine("Program is starting...");
            Console.WriteLine("Enter the number to convert:");
            DecimalNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the base type (Ex: 2,8):");
            var baseType = (BaseType)int.Parse(Console.ReadLine());
            string result = String.Empty;
            switch (baseType)
            {
                case BaseType.Binary:
                    result = System.Convert.ToString(DecimalNumber, 2);
                    break;
                case BaseType.Octal:
                    result = System.Convert.ToString(DecimalNumber, 8);
                    break;
                default:
                    result = "No base found!";
                    break;
            }
            Console.WriteLine($"The result is: {result} ");
            Console.WriteLine("Program is ending..");
        }
    }
}

