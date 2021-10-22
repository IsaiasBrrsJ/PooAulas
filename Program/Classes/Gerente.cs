using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classeAbstraraTeste
{
    class Gerente : Gratificacao
    {
        public override decimal valeTransporte() => base.valeTransporte() * 0.12m;


    }


}
