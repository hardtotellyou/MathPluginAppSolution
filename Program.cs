using MathCore;
using System.Collections.Generic;
using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace MathCore
{
    public interface IMathOperation
    {
            string OperatorSymbol { get; }
            string Description { get; }
            double Calculate(double a, double b);
        }
}
    internal class Program
    {
        static void Main(string[] args)
        {
            var operations = new List<IMathOperation>();
        }
    }
