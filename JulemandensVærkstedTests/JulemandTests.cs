using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JulemandensVærksted.Tests
{
    [TestClass()]
    public class JulemandTests
    {
        [TestMethod()]
        public void JulemandTest()
        {
            Julemand Julemand = Julemand.Instance("Julemanden", 480);
            //Julemand julemand = new Julemand("Julemanden", 480);

            Assert.AreEqual(480, Julemand.Age);
            Assert.AreEqual("Julemanden", Julemand.Name);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void JulemandTest2()
        {
            Julemand julemand = Julemand.Instance("Julemanden", 480);
            //Julemand julemand = new Julemand("Julemanden", 480);

            julemand.Age = 450;

        }

        [TestMethod]
        public void TestJulemandAgeOK()
        {
            Julemand julemand = Julemand.Instance("Julemanden", 451);
            
            Assert.AreEqual(451, julemand.Age);
            
        }

        public void TestUnderAgeJulemand()
        {
            int _julemand = 220;
            Julemand julemand = Julemand.Instance("Julemanden", 220);
            
            try
            {
                julemand.CheckAge(_julemand);
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Julemanden er altid over 450 år gammel", e.Message);
            }
        }

        [TestMethod]

        public void TestJuleNisseOK()
        {
            
            JuleNisse julenisse = new JuleNisse("Peter", "Transformer Biksen", 200);
            
            Assert.AreEqual(200, julenisse._age);
            Assert.AreEqual("Peter", julenisse._name);
            Assert.AreEqual("Transformer Biksen", julenisse._arbejdsområde);

        }

        [TestMethod]

        public void TestUnderAgeJuleNisse()
        {
            JuleNisse julenisse = new JuleNisse("Bo", "Pokemon", 150);

            try
            {
                julenisse.CheckAge(150);
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Julenisser er altid mindst 200 år gamle", e.Message);
            }
        }

       
        

       
    }
}
