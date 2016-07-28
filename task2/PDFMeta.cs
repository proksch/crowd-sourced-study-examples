using iTextSharp.text.pdf;

namespace pdf
{
    class PDFMeta
    {
        private byte[] pdf;

        public PDFMeta(byte[] pdf)
        {
            this.pdf = pdf;
        }

        public string getAuthor()
        {
            // TODO: Implement this method
            var author = "";
            return author;
        }
    }
}
