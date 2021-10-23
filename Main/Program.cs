using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulaSa
{
    class Program
    {
        static void Main(string[] args)
        {



            Carro carro = new Carro();
            carro.Ano_Carro = 2001;
            Console.WriteLine(value: $"{carro.Ano_Carro} ");
            Console.WriteLine("\n=================================");


            Pessoa pessoa = new Pessoa('M', 68);
            pessoa.cadPessoa = "EDMUNBDO";
            Console.Write(pessoa.cadPessoa);

            Console.WriteLine("\n=================================");


            Pessoa pessoa1 = new Pessoa('F', 78);

            pessoa1.cadPessoa = "JOSEFA";
            Console.Write(pessoa1.cadPessoa);

            Console.WriteLine("\n=========================================");

            Horas hora = new Horas("18:00");
            hora.hours = hora.hours;

            Console.Write(value: $"{hora.hours}");

            Console.WriteLine("\n=========================================");

            Horas hora1 = new Horas("6:00");
            hora1.hours = hora1.hours;

            Console.Write(value: $"{hora1.hours}");

            Console.WriteLine("\n=========================================");

            Horas hora2 = new Horas("20:00");
            hora2.hours = hora2.hours;

            Console.Write(value: $"{hora2.hours}");

            Console.ReadKey();
        }
    }
}
