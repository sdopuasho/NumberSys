using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class DecimalToAny
    {
        public string DecimalToAn(string a, string b) // из десятичной во все
        {
            string resulted;
            int num = Convert.ToInt32(a);
            int sys = Convert.ToInt32(b);

            List<int> result = new List<int>();

            while (num > 0)
            {
                result.Add(num % sys);
                num /= sys;
            }
            result.Reverse();
            return resulted = string.Join("", result);
        }
    }
}
