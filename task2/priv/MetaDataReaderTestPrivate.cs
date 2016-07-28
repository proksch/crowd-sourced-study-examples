using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace task2.priv
{
    [TestClass]
    public class MetaDataReaderTestPrivate
    {
        private MetaDataReader _sut;

        [TestInitialize]
        public void Setup()
        {
            _sut = new MetaDataReader("priv\\task2priv.pdf");
        }

        [TestMethod]
        public void GetAuthor()
        {
            var actual = _sut.ReadEntry("Author");
            var expected = "EVAL";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReadUnavailableEntry()
        {
            var actual = _sut.ReadEntry("Miau");
            var expected = "";
            Assert.AreEqual(expected, actual);
        }
    }
}