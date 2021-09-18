using System;
using System.Threading;

namespace ProjetoLocadora
{
    class Program
    {   
        
        static void Main(string[] args)
        {
            ProgramMenu();
        }


        enum Menu { CarroPopular = 1, CarroDeLuxo, CarroUtilitario, Sair }
        static void ProgramMenu()
        {

           

            bool EscolheuSair = !true;

            while (EscolheuSair != true)
            {
               
                Console.WriteLine("\n\t   LOCADORA DE VEÍCULOS  === Bart ===");
                Console.WriteLine("\n\t\t1- Carro Popular\n\t\t2- Carro de Luxo\n\t\t3- Carro Utilitário\n\t\t4-Sair");
                Console.Write("\n\t\tEscolha uma opção:  ");
                int opc = int.Parse(Console.ReadLine());

                Menu opEscolhida = (Menu)opc;

                if (opc > 0 && opc <= 4)
                {

                    switch (opEscolhida)
                    {
                        case Menu.CarroPopular:

                            SeguroDiarias CarPopular = new CarroPopular();
                            Console.WriteLine($"\n\t\t{opEscolhida} ");
                            Console.Write("\n\t\tInforme quantidade de diarias: ");
                            CarPopular.CalcSeg(int.Parse(Console.ReadLine()));

                            break;

                        case Menu.CarroDeLuxo:

                            SeguroDiarias carLuxo = new CarroDeLuxo();
                            Console.WriteLine($"\n\t\t{opEscolhida} ");
                            Console.Write("\n\t\tInforme quantidade de diarias: ");
                            carLuxo.CalcSeg(int.Parse(Console.ReadLine()));

                            break;

                        case Menu.CarroUtilitario:

                            SeguroDiarias carUtilitario = new CarroUtilitario();
                            Console.WriteLine($"\n\t\t{opEscolhida} ");
                            Console.Write("\n\t\tInforme quantidade de diarias: ");
                            carUtilitario.CalcSeg(int.Parse(Console.ReadLine()));

                            break;
                        case Menu.Sair:
                            EscolheuSair = !false;
                            Console.WriteLine($"\n\t\tATÉ BREVE.....");
                            Thread.Sleep(1000);
                            Console.Beep();
                            Console.Clear();
                            break;

                        default:
                            Console.WriteLine("\n\t\tEscolha Entre 1 e 3\n\t\tPressione para continuar..");
                            Console.ReadKey();
                            Console.Clear();
                            ProgramMenu();
                            break;
                    }

                }

                if (EscolheuSair != true)
                {
                    Console.ReadKey();
                }

                Console.Clear();
            }
    
            
        }
    }
}
