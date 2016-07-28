using iTextSharp.text.pdf;

namespace pdf.solution
{
    class PDFMetaSSolution
    {
        private byte[] pdf;

        public PDFMetaSSolution(byte[] pdf)
        {
            this.pdf = pdf;
        }

        public string getAuthor()
        {
            var reader = new PdfReader(pdf);
            var author = reader.Info["Author"];
            return author;
        }
    }
}
