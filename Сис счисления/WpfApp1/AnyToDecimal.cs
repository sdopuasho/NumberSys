using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class AnyToDecimal
    {
        public int alltodecimal(string number, int sischiscase)
        {
            int oper = sischiscase;
            string Numbr = number;
            int returnedvalue = 0;
            switch (oper)
            {
                case 2:
                    returnedvalue = Convert.ToInt32(Numbr, 2);
                    break;
                case 4:
                    string str = Numbr;
                    int lnght = str.Length;
                    double res = 0;
                    int SistChisl = 4;
                    for (int i = 0; i < lnght; i++)
                    {
                        res += (int)Char.GetNumericValue(str[lnght - 1 - i]) * Math.Pow(SistChisl, i);
                    }
                    returnedvalue = Convert.ToInt32(res);
                    break;
                case 6:
                    string str2 = Numbr;
                    int lnght2 = str2.Length;
                    double res2 = 0;
                    int SistChisl2 = 6;
                    for (int i = 0; i < lnght2; i++)
                    {
                        res2 += (int)Char.GetNumericValue(str2[lnght2 - 1 - i]) * Math.Pow(SistChisl2, i);
                    }
                    returnedvalue = Convert.ToInt32(res2);
                    break;
                case 8:
                    returnedvalue = Convert.ToInt32(Numbr, 8);
                    break;
            }
            return returnedvalue;
        }
    }
}
