using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio8
{
    class Secretaria : Funcionario
    {

        public override void ExibirGratificacao(double grat)
        {

            Console.Write($"\nSecretaria = {grat.ToString("C")} \n");


        }
    }
}
