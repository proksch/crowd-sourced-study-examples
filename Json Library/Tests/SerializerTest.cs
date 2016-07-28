using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Json_Library.Tests
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
            var actual = _sut.Serialize(new Person());
            var expected = "{}";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValueIsSet()
        {
            var actual = _sut.Serialize(new Person {Name = "A"});
            var expected = "{\"Name\":\"A\"}";
            Assert.AreEqual(expected, actual);
        }
    }
}