using App.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace App
{
    public static class CalculatorExtension
    {
        public static event EventHandler<string> ErrorEvent;
        public static double Operation(this ICalculator calc, string operation, double valOne, string valTwo)
        {
            try
            {
                double parsedValTwo = double.Parse(valTwo);

                switch (operation)
                {
                    case "+":
                        return calc.Addition(valOne, parsedValTwo);

                    case "-":
                        throw new NotImplementedException();

                    case "*":
                        return calc.Multiplication(valOne, parsedValTwo);

                    case "/":
                        return calc.Division(valOne, parsedValTwo);

                    // default just returns the value that is in the resultTextbox
                    //Freddy wuz her
                    default:
                        return parsedValTwo;
                }
            }
            catch (Exception e)
            {
                // if any operation fails or the parsing of the valTwo param, the error event is invoked and the error message is passed to the eventhandler
                // and then NaN is returned so the form can handled the logic for when a error has happened
                ErrorEvent?.Invoke(null, e.Message);
                return double.NaN;
            }
        }
    }
}
