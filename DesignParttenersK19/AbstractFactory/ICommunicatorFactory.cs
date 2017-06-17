using DesignParttenersK19.CommonBusiness;
using DesignParttenersK19.FactoryMethod;

namespace DesignParttenersK19.AbstractFactory
{
    public interface ICommunicatorFactory
    {
        /// <summary>
        /// Create a Sender object to machine card.
        /// </summary>
        /// <returns></returns>
        ISender CreateSender();

        /// <summary>
        /// Create a Receiver object to machine card.
        /// </summary>
        /// <returns></returns>
        IReceiver CreateReceiver();
    }
}