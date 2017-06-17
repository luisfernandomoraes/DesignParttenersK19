using System;
using System.Drawing.Imaging;

namespace DesignParttenersK19.Builder
{
    public interface ITicketBuilder
    {
        ITicketBuilder WithTakenOut(string sacado);
        ITicketBuilder WithAssignor(string cedente);
        ITicketBuilder WithValue(double valor);
        ITicketBuilder WithdExpiration(DateTime vencimento);
        ITicketBuilder WithOurNumber(int nossoNumero);
        ITicketBuilder WithBarcode(string barcode);
        ITicketBuilder WithLogo(BitmapData logo);
        Ticket BuildBoleto();
    }

    public class Ticket
    {
        public string TakenOut { get; set; }
        public string Assignor { get; set; }
        public double Value { get; set; }
        public DateTime Expiration { get; set; }
        public int Number { get; set; }
        public string Barcode { get; set; }
        public BitmapData Logo { get; set; }
    }
}