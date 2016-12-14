using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestGeneričkeKolekcijeSaČlanovimaRažličitihTipova : ConsoleTest
    {
        [TestMethod]
        public void GeneričkeKolekcijeSaČlanovimaRažličitihTipova()
        {
            GeneričkeKolekcijeSaČlanovimaRazličitihTipova.KretanjeŽivotinja();
            Assert.AreEqual(4, cw.Count);
            Assert.AreEqual("Letim", cw.GetString());
            Assert.AreEqual("Gmižem", cw.GetString());
            Assert.AreEqual("Trčim", cw.GetString());
            Assert.AreEqual("Plivam", cw.GetString());
        }
    }
}
