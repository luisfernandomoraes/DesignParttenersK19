using System;
using System.Drawing.Imaging;

namespace DesignParttenersK19.Builder
{
    public class BbbTicktetBuilder:ITicketBuilder
    {
        private Ticket _ticket;
        public BbbTicktetBuilder()
        {
            _ticket = new Ticket();
        }
        public ITicketBuilder WithTakenOut(string sacado)
        {
            _ticket.TakenOut = sacado;
            return this;
        }

        public ITicketBuilder WithAssignor(string cedente)
        {
            _ticket.Assignor = cedente;
            return this;
        }

        public ITicketBuilder WithValue(double valor)
        {
            _ticket.Value = valor;
            return this;
        }

        public ITicketBuilder WithdExpiration(DateTime vencimento)
        {
            _ticket.Expiration = vencimento;
            return this;
        }

        public ITicketBuilder WithOurNumber(int nossoNumero)
        {
            _ticket.Number = nossoNumero;
            return this;
        }

        public ITicketBuilder WithBarcode(string barcode)
        {
            _ticket.Barcode = barcode;
            return this;
        }

        public ITicketBuilder WithLogo(BitmapData logo)
        {
            _ticket.Logo = logo;
            return this;
        }

        public Ticket BuildBoleto()
        {
            return _ticket;
        }
    }
}