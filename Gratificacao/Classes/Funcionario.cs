using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio8
{
    class Funcionario
    {
        public string nomeFunc { get; set; }
        public int matriculaFunc { get; set; }
        
        public virtual void ExibirGratificacao(string nomeFunc, int matriculaFunc, double gratificacao)
        {

            Console.Write($"\nGerente: {nomeFunc}\nMatricula: {matriculaFunc}\nGratificação: {gratificacao.ToString("C")}\n");
            Console.WriteLine("====================================");
        }
    }
}
