using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class LoadAtBd
    {
        shiaEntities shia = new shiaEntities();
        int result;
        public int ReturnSisSchis(int num, int SisScis)
        {
            switch (SisScis)
            {
                case 2:
                    result = shia.SisSchis.Where(x => x.id == num).Select(x => x.Binary).FirstOrDefault();
                    break;
                case 4:
                    result = shia.SisSchis.Where(x => x.id == num).Select(x => x.Quaternary).FirstOrDefault();
                    break;
                case 6:
                    result = shia.SisSchis.Where(x => x.id == num).Select(x => x.Hexadecimal).FirstOrDefault();
                    break;
                case 8:
                    result = shia.SisSchis.Where(x => x.id == num).Select(x => x.Octal).FirstOrDefault();
                    break;
                case 10:
                    result = shia.SisSchis.Where(x => x.id == num).Select(x => x.Decimal).FirstOrDefault();
                    break;
            }
            return result;
        }

        public int ReturnResultMathOper(int num1, int num2, int SisIsch)
        {
            switch (SisIsch)
            {
                case 2:

                    result = shia.OperOnChiss.Include(i => i.SisSchis).Where(w => w.id_num == num1 && w.id_num2 == num2).Select(s => s.SisSchis.Binary).FirstOrDefault();
                    break;
                case 4:
                    result = shia.OperOnChiss.Include(i => i.SisSchis).Where(w => w.id_num == num1 && w.id_num2 == num2).Select(s => s.SisSchis.Quaternary).FirstOrDefault();
                    break;
                case 6:
                    result = shia.OperOnChiss.Include(i => i.SisSchis).Where(w => w.id_num == num1 && w.id_num2 == num2).Select(s => s.SisSchis.Hexadecimal).FirstOrDefault();
                    break;
                case 8:
                    result = shia.OperOnChiss.Include(i => i.SisSchis).Where(w => w.id_num == num1 && w.id_num2 == num2).Select(s => s.SisSchis.Octal).FirstOrDefault();
                    break;
                case 10:
                    result = shia.OperOnChiss.Include(i => i.SisSchis).Where(w => w.id_num == num1 && w.id_num2 == num2).Select(s => s.SisSchis.Decimal).FirstOrDefault();
                    break;
            }
            return result;
        }
    }
}
