using System;
using System.Text;
using DesignParttenersK19.CommonBusiness;

namespace DesignParttenersK19.Decorator
{
    public class SenderWithCriptDecorator:SenderDecorator
    {
        public SenderWithCriptDecorator(ISender sender) : base(sender)
        {
        }

        public override void Send(string message)
        {
            Console.WriteLine("Sending encrypted message");
            this.Sender.Send(Encrypt(message));
        }

        private string Encrypt(string message)
        {
            StringBuilder builder = new StringBuilder();
            foreach (var m in message)
            {
                builder.Append(char.GetNumericValue(m));
            }
            return builder.ToString();
        }
    }

    public class SenderWithCompressionDecorator:SenderDecorator
    {
        public SenderWithCompressionDecorator(ISender sender) : base(sender)
        {
        }

        public override void Send(string message)
        {
            Console.WriteLine("Sending encrypted message");
            this.Sender.Send(Compress(message));
        }

        private string Compress(string message)
        {
            return message.Trim().Replace(" ",string.Empty);
        }
    }
}