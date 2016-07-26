using System.IO;
using System.Text;
using NUnit.Framework;

namespace Json_Library.Tests
{
    public class SerializerTest
    {
        private Serializer _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new Serializer();

        }

        [Test]
        public void DefaultObject()
        {
            var actual = _sut.Serialize(new Person());
            var expected = "{}";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValueIsSet()
        {
            var actual = _sut.Serialize(new Person {Name = "A"});
            var expected = "{\"Name\":\"A\"}";
            Assert.AreEqual(expected, actual);
        }
    }
}