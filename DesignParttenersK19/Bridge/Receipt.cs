namespace DesignParttenersK19.Bridge
{
    public class Receipt:IDocument
    {
        private double _value;
        private IDocumentGenerate _documentGenerate;

        public Receipt(IDocumentGenerate documentGenerate)
        {
            _documentGenerate = documentGenerate;
        }

        public void BuildDocument()
        {
            // Creates a document with data of this receipt in a supported format.
            // ...
            _documentGenerate.GenerateDocument("receipt content");
        }
    }
}