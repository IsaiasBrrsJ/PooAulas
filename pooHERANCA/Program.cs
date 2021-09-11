using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio4
{
    class Program
    {
        static void Main(string[] args)
        {

            Caminhao caminhao = new Caminhao();

            caminhao.Nome = "DDR4";
            caminhao.Modelo = "V5";
            caminhao.QuantidadeDePortas = 2;
            caminhao.QuantidadeDeRodas = 12;
            caminhao.AnoFabricacao = 2020;
            caminhao.AnoModelo = 2021;
            caminhao.Potencia = 150;
            caminhao.Placa = "EXE256E";
            caminhao.TipoDeCombustivel = "Disel";
            caminhao.Cor = "Azul Branco";
            caminhao.preco = 250.0058;
            caminhao.Fabricante = "VOLVO";

            caminhao.ImprimirInfo();

            var moto = new Moto();

            moto.Nome = "TITAN";
            moto.Modelo = "TITAN160";
            moto.QuantidadeDeRodas = 2;
            moto.AnoFabricacao = 2019;
            moto.AnoModelo = 2020;
            moto.Potencia = 162;
            moto.Placa = "NXE682A";
            moto.TipoDeCombustivel = "Flex";
            moto.Cor = "AZUL";
            moto.preco = 15.000;
            moto.Fabricante = "HONDA";

            moto.ImprimirInfo();

            Carro carro = new Carro();

            carro.Nome = "ASTRA";
            carro.Modelo = "SEDAN";
            carro.QuantidadeDeRodas = 4;
            carro.AnoFabricacao = 2006;
            carro.AnoModelo = 2007;
            carro.Potencia = 128;
            carro.Placa = "NXEA3Q";
            carro.TipoDeCombustivel = "GASOLINA";
            carro.Cor = "LARANJA";
            carro.preco = 15.000;
            carro.Fabricante = "CHEVROLET";

            carro.ImprimirInfo();


        }
    }
}
