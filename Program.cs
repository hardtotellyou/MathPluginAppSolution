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
        var operations = new List<IMathOperation>(){
            new PowerOperation(), new AddOperation()
         };
        Console.WriteLine($"Загружено {operations.Count} операцій:");
        foreach (var operation in operations)
        {
            Console.WriteLine($"{operation.OperatorSymbol} ({operation.Description})");
        }
        Console.Write("Введіть вираз (наприклад: 10 ^ 2): ");
        string input = Console.ReadLine(); 
        var parts = input.Split(' ');

        double a = double.Parse(parts[0]);
        string op = parts[1];
        double b = double.Parse(parts[2]);
        var operationToExecute = operations.FirstOrDefault(o => o.OperatorSymbol == op);
        if (operationToExecute == null)
        {
            Console.WriteLine($"Операція '{op}' не підтримується.");
            return;
        }
        double result = operationToExecute.Calculate(a, b);
        Console.WriteLine($"Результат: {result}");
    }
}
