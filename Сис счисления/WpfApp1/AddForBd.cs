using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class AddForBd
    {
        DecimalToAny DTA = new DecimalToAny();
        Check CHK = new Check();
        shiaEntities SHIA = new shiaEntities();
        public void insertSisSchis(int number)
        {
            int Binary = Convert.ToInt32( DTA.DecimalToAn(number.ToString(), "2")), 
                Quaternary = Convert.ToInt32(DTA.DecimalToAn(number.ToString(), "4")), 
                Hexadecimal = Convert.ToInt32(DTA.DecimalToAn(number.ToString(), "6")), 
                Octal = Convert.ToInt32(DTA.DecimalToAn(number.ToString(), "8")), 
                Decimal = number;
            SisSchis sisIschis = new SisSchis()
            {
                Binary = Binary,
                Quaternary = Quaternary,
                Hexadecimal = Hexadecimal,
                Octal = Octal,
                Decimal = Decimal
            };
            SHIA.SisSchis.Add(sisIschis);
            SHIA.SaveChanges();
        }

        public void insertOperWith(int number1, int SisSchis1, int number2, int SisSchis2, int number3, int SisSchis3, string math)
        {
            int first = CHK.check(number1, SisSchis1), 
                second = CHK.check(number2, SisSchis2),
                result = CHK.check(number3, SisSchis3),
                idmath = SHIA.Operation.Where(w=>w.Operation1 == math).Select(s=>s.id).FirstOrDefault();
            OperOnChiss oper = new OperOnChiss()
            {
                id_num = first,
                id_num2 = second,
                Resulters = result,
                id_oper = idmath
            };
            SHIA.OperOnChiss.Add(oper);
            SHIA.SaveChanges();

        }
    }
}
