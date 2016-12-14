using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestGeneričkeKolekcije : ConsoleTest
    {
        [TestMethod]
        public void GeneričkeKolekcije_TipskiNesigurneKolekcije()
        {
            try
            {
                GeneričkeKolekcije.TipskiNesigurnaKolekcija();
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(InvalidCastException));
                Assert.AreEqual(4, cw.Count);
                Assert.AreEqual("Ivica", cw.GetString());
                Assert.AreEqual("Marica", cw.GetString());
                Assert.AreEqual("Ivica", cw.GetString());
                Assert.AreEqual("Marica", cw.GetString());
            }
        }

        [TestMethod]
        public void GeneričkeKolekcije_GeneričkaKolekcija()
        {
            GeneričkeKolekcije.GeneričkaKolekcija();
            Assert.AreEqual(4, cw.Count);
            Assert.AreEqual("Ivica", cw.GetString());
            Assert.AreEqual("Marica", cw.GetString());
            Assert.AreEqual("Ivica", cw.GetString());
            Assert.AreEqual("Marica", cw.GetString());
        }
    }
}
