using MathCore;
using System;
public class AddOperation : IMathOperation
{
    public string OperatorSymbol => "+";
    public string Description => "Додавання";

    public double Calculate(double a, double b) => a + b;
}
