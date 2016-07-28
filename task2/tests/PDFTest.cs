using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using task2.Properties;

namespace pdf.Tests
{
    [TestClass]
    public class PDFTest
    {
        private PDFMeta _sut;

        [TestInitialize]
        public void Setup()
        {
            var pdf = Resources.task2;
            _sut = new PDFMeta(pdf);

        }

        [TestMethod]
        public void getAuthor()
        {
            var actual = _sut.getAuthor();
            var expected = "CUPS";

            Assert.AreEqual(expected, actual);
        }
    }
}