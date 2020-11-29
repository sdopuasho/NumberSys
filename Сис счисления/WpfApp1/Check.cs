using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    
    class Check
    {
        shiaEntities SHIA = new shiaEntities(); int result;
        public int CheckMathOperInBD (int number1, int Sisschis1, int number2, int Sisschis2, string mathoper)
        {

            int FirstCheck = check(number1, Sisschis1) , SecondCheck = check(number2, Sisschis2), result, idMathOper = SHIA.Operation.Where(w => w.Operation1 == mathoper).Select(s => s.id).FirstOrDefault();
            if(FirstCheck > 0 && SecondCheck > 0)
            {
                result = SHIA.OperOnChiss.Where(w => w.id_num == FirstCheck && w.id_num2 == SecondCheck && w.id_oper == idMathOper).Select(s => s.id).FirstOrDefault();
            }
            else
            {
                result = 0;
            }
            return result;
        }
        public int check(int number, int SisSchis)
        {
            switch (SisSchis)
            {
                case 2:
                    result = SHIA.SisSchis.Where(x => x.Binary == number ).Select(x => x.id).FirstOrDefault();
                    break;
                case 4:
                    result = SHIA.SisSchis.Where(x => x.Quaternary == number).Select(x => x.id).FirstOrDefault();
                    break;
                case 6:
                    result = SHIA.SisSchis.Where(x => x.Hexadecimal == number ).Select(x => x.id).FirstOrDefault();
                    break;
                case 8:
                    result = SHIA.SisSchis.Where(x => x.Octal == number).Select(x => x.id).FirstOrDefault();
                    break;
                case 10:
                    result = SHIA.SisSchis.Where(x => x.Decimal == number).Select(x => x.id).FirstOrDefault();
                    break;
            }
            return result;
        }
    }
}
