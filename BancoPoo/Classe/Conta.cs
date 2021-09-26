using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoPpOO
{
    class Conta
    {
        
        public string nomeCliente { get; set; }
        public int numeroDaConta { get; set; }

        public double saldo { get; set; }

      
        public void Depositar(double depositar)
        {
            if (depositar >= 0)
            {
                this.saldo += depositar;
            }
            
        }

        public void Sacar(double sacar)
        {
            if (sacar <= this.saldo )
            {
                this.saldo -= sacar;
            }
        }
      
        

    }
}
