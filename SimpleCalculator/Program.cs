using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputConverter inputConverter = new InputConverter();
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                Console.WriteLine("Enter a number: ");
                double firstNum = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                Console.WriteLine("Enter another number: ");
                double secondNum = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                Console.WriteLine("Enter the operation to perform ( [add | +] | [subtract | -] | [ multiply | x | *] | [ divide | /] ): ");
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNum, secondNum);
                Console.WriteLine(result);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
