using DesignParttenersK19.CommonBusiness;

namespace DesignParttenersK19.Decorator
{
    public abstract class SenderDecorator:ISender
    {
        private ISender _sender;

        public SenderDecorator(ISender sender)
        {
            _sender = sender;
        }

        public ISender Sender
        {
            get { return _sender; }
        }

        public abstract void Send(string message);

    }
}