using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionSystemWithSOLIDandDesignPatterns
{
    // Apply Null Object Design Pattern that serves Liskove Substitution Principle.
    public class InvalidBaseConverter : Converter
    {
        public InvalidBaseConverter(int decimalNumber) : base(decimalNumber)
        { }
        public override string Convert()
        {
            return $"This base type is not a valid base.";
        }
    }
}
