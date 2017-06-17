using DesignParttenersK19.CommonBusiness;

namespace DesignParttenersK19.AbstractFactory
{
    public class VisaCommunicatorFactory: ICommunicatorFactory
    {
        public ISender CreateSender()
        {
            // Create a Visa sender.
            return null;
        }

        public IReceiver CreateReceiver()
        {
            // Create a Visa receiver.
            return null;
        }
    }
}