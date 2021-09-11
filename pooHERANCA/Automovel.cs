using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio4
{
    class Automovel
    {
        public string Nome { get; set; }
        public string Modelo { get; set; }
        public int AnoModelo { get; set; }
        public int AnoFabricacao { get; set; }
        public string Fabricante { get; set; }
        public int QuantidadeDePortas { get; set;  }
        public int QuantidadeDeRodas { get; set; }
        public string TipoDeCombustivel { get; set; }
        public string Placa { get; set; }
        public int Potencia { get; set; }
        public string Cor { get; set; }
        public double preco { get; set; }

        public void ImprimirInfo()
        {
            Console.Write("==============================");

            Console.Write($"\nNome: {this.Nome}\nModelo: {this.Modelo}\nAno Modelo: {this.AnoModelo}\nAno Fabricaçao: {this.AnoFabricacao}\nPortas: {this.QuantidadeDePortas}");
            Console.Write($"\nRodas: {this.QuantidadeDeRodas}\nCombustivel: {this.TipoDeCombustivel}\nPlaca: {this.Placa}\nPotencia: {this.Potencia}\nCor: {this.Cor}\nPreço: {this.preco}\nFabricante: {this.Fabricante}");

            Console.Write("\n==============================");
            Console.ReadKey();
           
        }

       

    }
}
