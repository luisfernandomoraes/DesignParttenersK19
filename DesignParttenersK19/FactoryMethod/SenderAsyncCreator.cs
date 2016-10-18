using System;

namespace DesignParttenersK19.FactoryMethod
{
    public class SenderAsyncCreator:SenderCreator
    {
        public override ISender Create(SenderType senderType)
        {
            switch (senderType)
            {
                case SenderType.Sms:
                    return new SMSSender();
                case SenderType.Email:
                    return new EmailSender();
                case SenderType.Push:
                    return new PushSender();
                default:
                    throw new ArgumentOutOfRangeException(nameof(senderType), senderType, "Informe um argumento valido");
            }
        }
    }
}