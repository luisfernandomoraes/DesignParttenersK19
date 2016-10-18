using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignParttenersK19.FactoryMethod;

namespace DesignParttenersK19
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryMethod();
        }

        static void FactoryMethod()
        {
            // Errado.
            var message = "Estudo de padrões de projeto.";
            DesignParttenersK19.FactoryMethod.SMSSender smsSender = new SMSSender();
            smsSender.Send(message);

            DesignParttenersK19.FactoryMethod.EmailSender emailSender = new EmailSender();
            emailSender.Send(message);

            DesignParttenersK19.FactoryMethod.PushSender pushSender = new PushSender();
            pushSender.Send(message);

            // Certo.
            DesignParttenersK19.FactoryMethod.SenderCreator creator = new SenderCreator();
            var sender = creator.Create(SenderType.Sms);
            sender.Send(message);
        }
    }
}
