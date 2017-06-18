using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignParttenersK19.AbstractFactory;
using DesignParttenersK19.Builder;
using DesignParttenersK19.CommonBusiness;
using DesignParttenersK19.FactoryMethod;
using DesignParttenersK19.Prototype;

namespace DesignParttenersK19
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryMethodUse();

            AbstractFactoryUse();

            BuilderUse();

            PrototypeUse();
        }

        private static void PrototypeUse()
        {
            Campaign campaign1 = new Campaign
            {
                Title = "k19 - C# Development",
                Description = "Come on to be a great C# developer with K19 courses.",
                InitDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(3)
            };

            Console.WriteLine(campaign1);

            Campaign campaign2 = (Campaign)campaign1.Clone();
            campaign2.EndDate = DateTime.Now.AddMonths(5);

            Console.WriteLine(campaign2);
        }

        private static void BuilderUse()    
        {
            ITicketBuilder ticketBuilder = new BbbTicktetBuilder();
            Ticket boleto = ticketBuilder.WithBarcode("7899754221212")
                .WithAssignor("Luís Fernando")
                .WithOurNumber(777)
                .WithTakenOut("k19")
                .WithdExpiration(new DateTime(2017, 12, 11))
                .WithLogo(null)
                .WithValue(59.90)
                .BuildBoleto();

            Console.WriteLine(boleto);
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
