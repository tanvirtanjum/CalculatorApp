using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class numberchecking
    {
        public double cinput1;
        public double cinput2;
        public bool checking(string input1, string input2)
        {
            bool ok1 = Double.TryParse(input1, out cinput1);
            bool ok2 = Double.TryParse(input2, out cinput2);

            if(ok1 == true && ok2 == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
