using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classeAbstraraTeste
{
    public abstract class Gratificacao
    {
        public decimal salario { get; set; }

        public virtual decimal valeTransporte() => salario * 0.10m;

        public  decimal ValeAlmoco() => salario * 0.05m;

    }
}
