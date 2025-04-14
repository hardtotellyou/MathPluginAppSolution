using MathCore;
using System;
public class PowerOperation : IMathOperation
{
    public string OperatorSymbol => "^";
    public string Description => "Піднесення до степеня";

    public double Calculate(double a, double b) => Math.Pow(a, b);
}
