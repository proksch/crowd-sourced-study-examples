using iTextSharp.text.pdf;

namespace task2.priv
{
    class MetaDataReaderSolution
    {
        private readonly PdfReader _reader;

        public MetaDataReaderSolution(string pdfPath)
        {
            _reader = new PdfReader(pdfPath);
        }

        public string ReadEntry(string name)
        {
            var dictionary = _reader.Info;
            var result = dictionary.ContainsKey(name) ? dictionary[name] : "";
            return result;
        }
    }
}