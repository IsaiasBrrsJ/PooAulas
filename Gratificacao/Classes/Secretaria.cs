using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio8
{
    class Secretaria : Funcionario
    {

        public override void ExibirGratificacao(string nomeFunc, int matriculaFunc, double gratificacao)
        {

            Console.Write($"\nSecretária: {nomeFunc}\nMatricula: {matriculaFunc}\nGratificação: {gratificacao.ToString("C")} \n");

            Console.WriteLine("====================================");
        }
    }
}
