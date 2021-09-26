using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoPpOO
{
    class Program
    {   
       enum Menu { CadastrarClientes = 1, Saldo, Depositar, Sacar, Sair}
       
        static Conta conta = new Conta();
        static void Main(string[] args)
        {
            
            
            bool sair = false;

            while (sair == false)
            {
                Console.Write("\n\t\t1- Cadastrar Cliente\n\t\t2- Saldo\n\t\t3- Depositar\n\t\t4- Sacar\n\t\t5- Sair\n");
                Console.Write("\n\t\tOpção: ");
                 int opc = int.Parse(Console.ReadLine());

                Menu opcaoSelecionada = (Menu)opc;

                if(opc > 0 || opc <= 5)
                {

                    switch (opcaoSelecionada)
                    {
                        case Menu.CadastrarClientes:

                            cadastrarCliente();

                            break;
                        case Menu.Saldo:

                            if (conta.nomeCliente != " " && conta.numeroDaConta != 0)
                            {
                                Console.WriteLine("\n\t\t=== Saldo ===");
                                Console.Write($"\n\t\tSaldo: {conta.saldo}");
                            }
                            else
                                Console.WriteLine("Adcione um cliente para ver um saldo algo...");

                            break;
                        case Menu.Depositar:

                            if (conta.nomeCliente != " " && conta.numeroDaConta != 0)
                            {
                                Console.WriteLine("\n\t\t=== Depositar ===");
                                Console.Write("\n\t\tInsira o valor: ");
                                double valor = double.Parse(Console.ReadLine());
                                conta.Depositar(valor);
                                if(valor < 0)
                                {
                                    Console.Write("VAlor não depositado, informe um valor maior que zero.");
                                }
                            }
                            else
                                Console.WriteLine("Adcione um cliente para depositar algo...");
                           
                            break;
                        case Menu.Sacar:

                            bool sim = false;
                            double valorSaque =0;
                            if (conta.nomeCliente != " " && conta.numeroDaConta != 0)
                            {
                                Console.WriteLine("\n\t\t=== Saque ===");
                                Console.Write("\n\t\tInforme o valor: ");
                                valorSaque = double.Parse(Console.ReadLine());
                            }
                            else
                            {
                                sim = true;
                                Console.WriteLine("Adcione um cliente para realizar um saque...");
                            }
                            
                            if (valorSaque > 0 && valorSaque <= conta.saldo)
                            {
                                conta.Sacar(valorSaque);

                                Console.WriteLine("\n\t\tSaque Efetuado Com Sucesso, Valor: " + valorSaque);

                                break;
                            }

                              if(valorSaque < 0 || conta.saldo == 0 || valorSaque < conta.saldo || valorSaque > conta.saldo)
                              {
                                if (sim != true)
                                {
                                    Console.WriteLine($"\n\t\tSaque não efetuado, valor disponivel: {conta.saldo}");
                                }
                                break;
                              }

                            break;
                        case Menu.Sair:

                            sair = true;
                            break; 
                    }

                    if (sair == false)
                    {
                        Console.ReadKey();
                    }
                    Console.Clear();

                }

            }
        }
        static void cadastrarCliente()
        {
            string nomeCli = " ";
            int numConta = 0;
            double saldoCli = -75;
           
            try
            {
                while (saldoCli < 0 && nomeCli == " ")
                {
                    Console.Write("\n\t\tNome do cliente: ");
                    nomeCli = Console.ReadLine();

                    Console.Write("\n\t\tNúmero da conta: ");
                    numConta = int.Parse(Console.ReadLine());

                    Console.Write("\n\t\tSaldo: ");
                    saldoCli = double.Parse(Console.ReadLine());

                    if(saldoCli < 0)
                    {
                        Console.Write("Informe saldo maior ou igual a zero, tente novamente...");
                        Console.ReadKey();
                        Console.Clear();
                        cadastrarCliente();
                    }
                    if(nomeCli == " ")
                    {
                        Console.Write("Informe um nome válido, tente novamente....");
                    }

                }

                if (saldoCli >= 0)
                {
                    
                    conta.nomeCliente = nomeCli;
                    conta.numeroDaConta = numConta;
                    conta.saldo = saldoCli;
                }
            }
            catch
            {
                Console.WriteLine("Algo de errado tente novamente...");
                Console.ReadKey();
                Console.Clear();
                cadastrarCliente();
            }

            

        }
    }
}
