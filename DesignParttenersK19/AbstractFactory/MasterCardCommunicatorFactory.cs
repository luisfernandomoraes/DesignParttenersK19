using DesignParttenersK19.CommonBusiness;

namespace DesignParttenersK19.AbstractFactory
{
    public class MasterCardCommunicatorFactory:ICommunicatorFactory
    {
        public ISender CreateSender()
        {
            // Create a MasterCard sender
            return null;
        }

        public IReceiver CreateReceiver()
        {
            // Create a MasterCard receiver.
            return null;
        }
    }
}