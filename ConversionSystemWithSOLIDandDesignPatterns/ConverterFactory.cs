﻿using System;
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
                // Apply Null Object Design Pattern that serves Liskove Substitution Principle.
                // because if exception arises, that violates Liskove Substitution Principle.
                return new InvalidBaseConverter(decimalNumber);
            }
        }
    }
}
