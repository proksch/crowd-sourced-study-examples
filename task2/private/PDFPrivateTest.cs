using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using task2.Properties;
using pdf.solution;

namespace pdf.PrivateTests
{
    [TestClass]
    public class PDFTest
    {
        private PDFMetaSSolution _sut;

        [TestInitialize]
        public void Setup()
        {
            var pdf = Resources.task2;
            _sut = new PDFMetaSSolution(pdf);

        }

        [TestMethod]
        public void getAuthorPrivate()
        {
            var actual = _sut.getAuthor();
            var expected = "CUPS";

            Assert.AreEqual(expected, actual);
        }
    }
}