﻿using System;
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


    // this class do multiple responsibilities logging, reading and converting
    // So, we need to apply Single Responsibility principle.
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
            Logger.Log("The result is: "+ result);
            Logger.Log("Program is ending..");
        }
    }
}
