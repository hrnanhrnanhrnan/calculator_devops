using App.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace App
{
    public class Calculator : ICalculator
    {
        //Freddy wuz her 2
        //Robin wuz her, not again and again and again
      
        public double Addition(double valOne, double valTwo)
            => valOne + valTwo;

        public double Division(double valOne, double valTwo)
            => valOne / valTwo;


        public double Subtraction(double valOne, double valTwo)
            => valOne - valTwo;

        public double Multiplication(double valOne, double valTwo)
            => valOne * valTwo;

    }
}
