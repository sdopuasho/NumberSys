using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class CheckForAnyInconsistency
    {
        bool test = false;
        public bool interstelar(string a)
        {
            int[] str = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < str.Length; j++)
                {
                    if ((int)Char.GetNumericValue(a[i]) == str[j])
                    {
                        test = true;
                        break;
                    }
                    else
                    {
                        test = false;
                    }
                }
            }
            return test;
        }

        bool resasdulted;
        public bool checkerd(string a, string sis, bool boool)
        {
            if (boool == true) {
                int i = 0;
                int[] afcorse = new int[a.Length];
                for (i = 0; i < a.Length; i++)
                {
                    int b = (int)Char.GetNumericValue(a[i]);
                    afcorse[i] = b;
                }
                int afc = Convert.ToInt32(sis);


                for (i = 0; i < a.Length; i++)
                {
                    if (afcorse[i] > afc || afcorse[i] == afc)
                    {
                        resasdulted = false;
                        break;
                    }
                    else
                    {
                        resasdulted = true;
                    }
                }
            }
            else
            {
                resasdulted = false;
            }
            return resasdulted;
        }
    }
}
