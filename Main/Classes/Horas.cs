
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulaSa
{
    class Horas
    {
        private string _hora;

        public Horas (string hora)
        {
            _hora = hora;
        }

        public string hours
        {
            get =>  _hora;

            set
            {
               

                if ( hours == "18:00")
                    _hora = (value + " HORA(S), HORA DE IR PARA CASA");

                else if (hours == "6:00")
                    _hora = (value + " HORA(S), HORA DE IR PARA O TRABALHO");

                else
                  _hora = ("\nÉ EXATAMENTE " + value + " HORA(S)");   
            }
        }
        
    }
}
