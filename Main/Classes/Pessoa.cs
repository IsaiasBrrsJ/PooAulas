using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulaSa
{
    class Pessoa
    {
        private string _nome;
        private char _sexo;
        private int _idade;

        public Pessoa(char sexo, int idade)
        {

            _sexo = sexo;
            _idade = idade;
        }
        public string cadPessoa
        {
            get => $"\nNome: { _nome}" + $"\nSexo: {_sexo}" + $"\nIdade: {_idade}\n";

            set
            {   
                if (_sexo.Equals('F'))
                    _nome = "Senhora " + value;

                if (_sexo.Equals('M'))
                   _nome = "Senhor " + value;
            }

        }
     
    }
}
