using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTestApp;
using NUnit.Framework;
using System.Threading;

namespace CalculatorTest
{    
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator testObj = null;

        [SetUp]
        public void InitialSetup()
        {
            Thread.Sleep(2000);
            Console.WriteLine($"Setup method for {TestContext.CurrentContext.Test.MethodName}");
            testObj = new Calculator();
        }

        [Test]
        [Parallelizable]
        [Category("1")]
        [Category("3")]
        public void AddTest()
        {
            Assert.AreEqual(5, testObj.Add(2, 3), "Verified add functionality");
        }

        [Test]
        [Parallelizable]
        [Category("2")]
        public void DiffTest()
        {
            Assert.AreEqual(4, testObj.Diff(8, 4), "Verified difference functionality");
        }
    }
}
