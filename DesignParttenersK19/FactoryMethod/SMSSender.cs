using System;
using DesignParttenersK19.CommonBusiness;

namespace DesignParttenersK19.FactoryMethod
{
    public class SMSSender:ISender
    {
        public void Send(string message)
        {
            Console.WriteLine("Enviando por SMS a mensagem: ");
            Console.WriteLine(message);
        }
    }
}