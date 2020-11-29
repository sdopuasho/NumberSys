using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class MathOpertionSwitch
    {
        int casesumm;
        public int mathoper(int tanswitch, int first, int second)
        {
            switch (tanswitch)
            {
                case 1:
                    casesumm = first + second;
                    break;
                case 2:
                    casesumm = first - second;
                    break;
                case 3:
                    casesumm = first * second;
                    break;
                case 4:
                    casesumm = first / second;
                    break;
            }
            return casesumm;

        }
    }
}
