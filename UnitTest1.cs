using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test_GB
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange (Inizializzo le variabili e il valore atteso)
            var x = 5;
            var y = 5;
            var expected = 25;

            // Act (Inizializzo il valore effettivo)
            var actual = x * y;

            // Assert (Confronto valore atteso e valore effettivo)
            Assert.AreEqual(expected, actual);
        }
    }
}
