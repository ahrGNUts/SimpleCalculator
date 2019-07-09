using System;

public class InputConverter
{
    public double ConvertInputToNumeric(string argTextInput)
    {
        double convertedNumber;

        if (!Double.TryParse(argTextInput, out convertedNumber))
            throw new ArgumentException("Expected a numeric value");

        return convertedNumber;
    }
}
