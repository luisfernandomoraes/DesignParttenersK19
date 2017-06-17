using System;
using DesignParttenersK19.CommonBusiness;

namespace DesignParttenersK19.FactoryMethod
{
    public class EmailSender:ISender
    {
        public void Send(string message)
        {
            Console.WriteLine("Enviado por email a mensagem: ");
            Console.WriteLine(message);
        }
    }
}