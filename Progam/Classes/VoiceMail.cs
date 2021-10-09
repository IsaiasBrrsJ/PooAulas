using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio8._1
{
    class VoiceMail : Notificacao
    {
        public override void NotificacaoEnviada()
        {
            Console.WriteLine("VoiceMail Enviado");
        }
    }
}
