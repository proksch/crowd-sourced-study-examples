using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace task1.priv
{
    [TestClass]
    public class SerializerTest
    {
        private Serializer _sut;

        [TestInitialize]
        public void Setup()
        {
            _sut = new Serializer();

        }

        [TestMethod]
        public void DefaultObject()
        {
            var actual = _sut.Serialize(new PersonPrivate());
            var expected = "{}";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValueIsSet()
        {
            var actual = _sut.Serialize(new PersonPrivate { Name = "B" });
            var expected = "{\"Name\":\"B\"}";
            Assert.AreEqual(expected, actual);
        }
    }
}