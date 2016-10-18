using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignParttenersK19.FactoryMethod
{
    class PushSender:ISender
    {
        public void Send(string message)
        {
            Console.WriteLine("Enviando por Push a mensagem: ");
            Console.WriteLine(message);
        }
    }
}
