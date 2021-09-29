using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio8
{
    class Program
    {
        static void Main(string[] args)
        {


            new Gerente().ExibirGratificacao("Junin", 20085, 500);
            new Analista().ExibirGratificacao("Zé Inácio", 28854, 300);
            new Secretaria().ExibirGratificacao("Aricelia Mercado", 24687, 100);

            Console.ReadKey();

        }
    }
}
