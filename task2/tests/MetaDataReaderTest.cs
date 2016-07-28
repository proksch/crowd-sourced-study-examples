using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace task2.tests
{
    [TestClass]
    public class MetaDataReaderTest
    {
        private MetaDataReader _sut;

        [TestInitialize]
        public void Setup()
        {
            _sut = new MetaDataReader("task2.pdf");
        }

        [TestMethod]
        public void GetAuthor()
        {
            var actual = _sut.ReadEntry("Author");
            var expected = "CUPS";
            Assert.AreEqual(expected, actual);
        }
    }
}