using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAppveyor.ClassLibrary.Tests
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void ToJson()
        {
            var user = new User() {
                Name = "Jonatas Saraiva"
            };

            var resultJson = user.ToJson();

            Assert.AreEqual<string>("{\r\n  \"Name\": \"Jonatas Saraiva\"\r\n}", resultJson);
        }
    }
}
