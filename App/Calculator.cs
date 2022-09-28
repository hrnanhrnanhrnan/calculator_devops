using App.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace App
{
    public class Calculator : ICalculator
    {
        public double Addition(double valOne, double valTwo)
            => valOne + valTwo;
    }
}
