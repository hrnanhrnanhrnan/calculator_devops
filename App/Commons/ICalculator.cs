using System;
using System.Collections.Generic;
using System.Text;

namespace App.Commons
{
    public interface ICalculator
    {
        double Addition(double valOne, double valTwo);
        double Division(double valOne, double valTwo);

        double Subtraction(double valOne, double valTwo);

        double Multiplication(double valOne, double valTwo);

    }
}
