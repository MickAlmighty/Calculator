using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLogic;

namespace TestModel
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void Addition()
        //{
        //    StringManager stringManager = new StringManager();
        //    stringManager.AddDigitToOperand("1");
        //    stringManager.AddDigitToOperand("5");
        //    stringManager.AddDigitToOperand(".");
        //    stringManager.AddDigitToOperand("5");
        //    stringManager.ChangeSignOfOperand();
        //    //stringManager.AddDigitToOperand("5");
        //    Assert.AreEqual("-15.5", stringManager.FirstOperand.ToString());

        //    stringManager.ActionOperator = "+";

        //    stringManager.AddDigitToOperand("5");
        //    Assert.AreEqual("5", stringManager.SecondOperand.ToString());

        //    stringManager.Execute();
        //    Assert.AreEqual("-10.5", stringManager.Result);
            
        //}
        [TestMethod]
        public void Substraction()
        {
            //Operation op = new Operation();
            //op.X1 = 2;
            //op.X2 = 3;
            //Assert.AreEqual(-1.0, op.Substraction());

        }

        [TestMethod]
        public void AddingDigitToOperand()
        {
            StringManager stringManager = new StringManager();
            stringManager.AddDigitToOperand("1");
            Assert.AreEqual("1", stringManager.FirstOperand.ToString());
            stringManager.AddDigitToOperand("5");
            Assert.AreEqual("15", stringManager.FirstOperand.ToString());
        }

        [TestMethod]
        public void CreatingFloatingPointNumber()
        {
            StringManager stringManager = new StringManager();
            stringManager.AddDigitToOperand("1");
            Assert.AreEqual("1", stringManager.FirstOperand.ToString());
            stringManager.AddDigitToOperand("0");
            Assert.AreEqual("10", stringManager.FirstOperand.ToString());
            stringManager.AddDigitToOperand("0");
            Assert.AreEqual("100", stringManager.FirstOperand.ToString());
            stringManager.AddDigitToOperand(".");
            Assert.AreEqual("100.", stringManager.FirstOperand.ToString());
            //stringManager.ChangeSignOfOperand();
            //Assert.AreEqual("-100", stringManager.FirstOperand.ToString());

        }
        [TestMethod]
        public void CreatingFloatingPointNumber2()
        {
            StringManager stringManager = new StringManager();
            stringManager.AddDigitToOperand(".");
            Assert.AreEqual("0.", stringManager.FirstOperand.ToString());
            stringManager.AddDigitToOperand("0");
            Assert.AreEqual("0.0", stringManager.FirstOperand.ToString());
            stringManager.AddDigitToOperand(".");
            Assert.AreEqual("0.0", stringManager.FirstOperand.ToString());
        }

        [TestMethod]
        public void ChangeSignOfOperand()
        {
            StringManager stringManager = new StringManager();
            stringManager.AddDigitToOperand("1");
            stringManager.ChangeSignOfOperand();
            Assert.AreEqual("-1", stringManager.FirstOperand.ToString());

            StringManager stringManager2 = new StringManager();
            stringManager2.AddDigitToOperand("-5");
            stringManager2.ChangeSignOfOperand();
            Assert.AreEqual("5", stringManager2.FirstOperand.ToString());
        }
    }
}
