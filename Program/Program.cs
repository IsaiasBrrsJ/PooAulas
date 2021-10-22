using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classeAbstraraTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            Gratificacao gerente = new Gerente();

            gerente.salario = 500m;
            
            Console.WriteLine(value: $"Gerente Tranporte: {gerente.valeTransporte():C2}");
            Console.WriteLine(value: $"Gerente Almoço: {gerente.ValeAlmoco():C2}");
            Console.WriteLine("\n");

            Gratificacao estagiario = new Estagiario();

            estagiario.salario = 1500m;
            Console.WriteLine(value: $"Estagiario Tranporte: {estagiario.valeTransporte():C2}");
            Console.WriteLine(value: $"Estagiario Almoço: {estagiario.ValeAlmoco():C2}");

            Console.ReadKey();
           

            
        }
    }
}
