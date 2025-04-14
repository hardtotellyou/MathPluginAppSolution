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
        foreach (var file in Directory.GetFiles("Operations", "*.dll"))
        {
            Assembly asm = Assembly.LoadFrom(file);
            foreach (var type in asm.GetTypes())
            {
                if (typeof(IMathOperation).IsAssignableFrom(type) && !type.IsInterface)
                {
                    var opInstance = (IMathOperation)Activator.CreateInstance(type);
                    operations.Add(opInstance);
                }
            }
        }
        Console.WriteLine($"Загружено {operations.Count} операций:");
        foreach (var operation in operations)
        {
            Console.WriteLine($"{operation.OperatorSymbol} ({operation.Description})");
        }
    }
}
