using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLocadora
{
    class CarroUtilitario : SeguroDiarias
    {

        public override void CalcSeg(int dias)
        {
            const float valDiaria = (float)400.00;
            const float valPercent = (float)0.25;
            float calc = (valDiaria * dias) * valPercent;
            Console.Write($"\n\t\tValor da diária: {valDiaria.ToString("C")} \n\t\tQuantidade De Diarias: {dias}\n\t\tValor do seguro: {calc.ToString("C")}");
        }
    }
}
