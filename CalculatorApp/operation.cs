using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class operation
    {
        public double addition(numberchecking obj)
        {
            return Math.Round(obj.cinput1 + obj.cinput2,2);
        }

        public double subtraction(numberchecking obj)
        {
            return Math.Round(obj.cinput1 - obj.cinput2,2);
        }
        public double multiplication(numberchecking obj)
        {
            return Math.Round(obj.cinput1 * obj.cinput2,2);
        }
        public double division(numberchecking obj)
        {
            if(obj.cinput2 != 0)
            {
                return Math.Round(obj.cinput1 / obj.cinput2,2);
            }

            else
            {
                throw new Exception("Invalid Operation.(Div by 0)");
            }
        }
    }
}
