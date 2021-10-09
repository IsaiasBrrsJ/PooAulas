using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Notificacao voice = new VoiceMail();
            voice.NotificacaoEnviada();

            Notificacao sms = new SMS();
            sms.NotificacaoEnviada();

            Notificacao email = new Email();
            email.NotificacaoEnviada();

            Console.Read();
        }
    }
}
