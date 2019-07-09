using System;

public class CalculatorEngine
{
    public double Calculate(string argOperation, double argNum1, double argNum2)
    {
        double result;

        switch (argOperation.ToLower())
        {
            case "add":
            case "+":
                result = argNum1 + argNum2;
                break;
            case "subtract":
            case "-":
                result = argNum1 - argNum2;
                break;
            case "multiply":
            case "*":
            case "x":
                result = argNum1 * argNum2;
                break;
            case "divide":
            case "/":
                result = argNum1 / argNum2;
                break;
            default:
                throw new InvalidOperationException("Specified operation is not recognized");
        }

        return result;
    }
}
