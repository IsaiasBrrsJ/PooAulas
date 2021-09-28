using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio8
{
    class Funcionario
    {

        public virtual void ExibirGratificacao(double grat)
        {

            Console.Write("Gratificação\n"+ $"\nGerente = {grat.ToString("C")}\n");
            

        }


            


    }
}
