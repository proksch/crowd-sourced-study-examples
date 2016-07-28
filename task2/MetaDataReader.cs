using iTextSharp.text.pdf;

namespace task2
{
    internal class MetaDataReader
    {
        private readonly PdfReader _reader;

        public MetaDataReader(string pdfPath)
        {
            _reader = new PdfReader(pdfPath);
        }

        public string ReadEntry(string name)
        {
            return null;
        }
    }
}