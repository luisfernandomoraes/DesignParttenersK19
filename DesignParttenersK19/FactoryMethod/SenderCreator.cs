﻿using System;
using DesignParttenersK19.CommonBusiness;

namespace DesignParttenersK19.FactoryMethod
{
    public class SenderCreator
    {
        public virtual ISender Create(SenderType senderType)
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

    public enum SenderType
    {
        Sms,
        Email, 
        Push
    }
}