using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignParttenersK19.AbstractFactory;
using DesignParttenersK19.CommonBusiness;
using DesignParttenersK19.FactoryMethod;

namespace DesignParttenersK19
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryMethodUse();

            AbstractFactoryUse();
        }



        private static void AbstractFactoryUse()
        {
            Card cartao = new Card();
            // Here the magic happens!
            ICommunicatorFactory factory = AbstractFactoryHelper.GetComunicadorFactory(cartao);

            String transacao = "A transaction";
            ISender emissor = factory.CreateSender();
            emissor.Send(transacao);
            
            IReceiver receptor = factory.CreateReceiver();
            String resposta = receptor.Receive();
        }

        static void FactoryMethodUse()
        {
            // Wrong.
            var message = "Design Partner Study";
            DesignParttenersK19.FactoryMethod.SMSSender smsSender = new SMSSender();
            smsSender.Send(message);

            DesignParttenersK19.FactoryMethod.EmailSender emailSender = new EmailSender();
            emailSender.Send(message);

            DesignParttenersK19.FactoryMethod.PushSender pushSender = new PushSender();
            pushSender.Send(message);

            // Right.
            DesignParttenersK19.FactoryMethod.SenderCreator creator = new SenderCreator();
            var sender = creator.Create(SenderType.Sms);
            sender.Send(message);
        }
    }
}
