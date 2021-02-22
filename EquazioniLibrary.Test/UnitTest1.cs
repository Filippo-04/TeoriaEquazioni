using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMet_1()
        {
            double a = 6.2;
            bool risulatato_effettivo = true;
            bool risultato_calcolato = Equazione.IsDetermined(a);
            Assert.AreEqual(risulatato_effettivo, risultato_calcolato);
        }
        public void TestMethod1_2()
        {
            double a = 0;
            bool risulatato_effettivo = false;
            bool risultato_calcolato = Equazione.IsDetermined(a);
            Assert.AreEqual(risulatato_effettivo, risultato_calcolato);
        }
        public void TestMethod2_1()
        {
            double a = 0; double b = 1.8;
            bool risulatato_effettivo = true;
            bool risultato_calcolato = Equazione.IsInconsisted(a,b);
            Assert.AreEqual(risulatato_effettivo, risultato_calcolato);
        }
        public void TestMethod2_2()
        {
            double a = 5.9; double b = 7.3;
            bool risulatato_effettivo = false;
            bool risultato_calcolato = Equazione.IsInconsisted(a, b);
            Assert.AreEqual(risulatato_effettivo, risultato_calcolato);
        }
    }
}
