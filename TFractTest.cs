using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TFractCSharp_test1;

namespace TFractTests
{
    [TestClass] 
    public class TFractTest_construcors
    {
        [TestMethod] 
        public void Constructor_Default()
        {
            TFract expectedF = new TFract(1, 1);
            TFract actualF = new TFract();
            Assert.AreEqual(expectedF, actualF);
        }

        [TestMethod] 
        public void Constructor_XdZero()
        {
            try
            {
                TFract f = new TFract(1, 0);
                Assert.Fail();
            }
            catch (TFractException)
            {

            }
        }

        [TestMethod] 
        public void Constructor_NegativeFracts()
        {
            TFract expectedF = new TFract(1, -2);
            TFract actualF = new TFract(-1, -2);
            Assert.AreEqual(expectedF, actualF);
        }
    }
    [TestClass] 
    public class TFractTest_methods
    {
        [TestMethod] 
        public void Method_ToFloat()
        {
            TFract Fract = new TFract(1, 2);
            float expectedF; expectedF = 0.5F;
            float actualF = Fract.ToFloat();
            Assert.AreEqual(actualF, expectedF);
        }

        [TestMethod] 
        public void Method_ToString()
        {
            TFract Fract = new TFract(1, 2);
            string expectedF; expectedF = "1/2";
            string actualF = Fract.ToString();
            Assert.AreEqual(actualF, expectedF);
        }

        [TestMethod]
        public void Method_Reduce()
        {
            TFract expectedF = new TFract(10, 20);
            TFract actualF = new TFract(1, 2);
            expectedF.Reduce();
            Assert.AreEqual(expectedF, actualF);
        }
    }
   
    [TestClass] 
    public class TFractTest_operators
    {
        [TestMethod]
        public void Operator_Sum()
        {
            TFract f1 = new TFract(2, 3);
            TFract f2 = new TFract(5, 6);
            TFract actualF = (f1 + f2).Reduce();
            TFract expectedF = new TFract(3, 2);
            Assert.AreEqual(expectedF, actualF);
        }

        [TestMethod]
        public void Operator_Sum_NumPlusFract()
        {            
            int f1 = 5;
            TFract f2 = new TFract(5, 6);
            TFract actualF = (f1 + f2).Reduce();
            TFract expectedF = new TFract(35, 6);
            Assert.AreEqual(expectedF, actualF);
        }

        [TestMethod] 
        public void Operator_Sum_FractPlusNum()
        {
            int f1 = 5;
            TFract f2 = new TFract(24, 5);
            TFract actualF = (f2 + f1).Reduce();
            TFract expectedF = new TFract(49, 5);
            Assert.AreEqual(expectedF, actualF);
        }

        [TestMethod]
        public void Operator_Mul()
        {
            TFract f1 = new TFract(5, 32);
            TFract f2 = new TFract(1, 64);
            TFract actualF = (f1 * f2).Reduce();
            TFract expectedF = new TFract(5, 2048);
            Assert.AreEqual(expectedF, actualF);
        }

        [TestMethod]
        public void Operator_Div()
        {
            TFract f1 = new TFract(2, 9);
            TFract f2 = new TFract(5, -4);
            TFract actualF = (f1 / f2).Reduce();
            TFract expectedF = new TFract(-8, 45);
            Assert.AreEqual(expectedF, actualF);
        }

        [TestMethod]
        public void Operator_AsmallerB()
        {
            TFract f1 = new TFract(9, 20);
            TFract f2 = new TFract(1, 2);
            bool actual = (f1 < f2);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Operator_AbiggerB()
        {
            TFract f1 = new TFract(-9, 20);
            TFract f2 = new TFract(-1, 2);
            bool actual = (f1 > f2);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Operator_AeqB()
        {
            TFract f1 = new TFract(100, 1000);
            TFract f2 = new TFract(1, 10);
            bool actual = (f1 == f2);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Operator_AbiggerOReqB()
        {
            TFract f1 = new TFract(2, 5);
            TFract f2 = new TFract(10, 11);
            bool actual = (f1 >= f2);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Operator_AsmallerOReqB()
        {
            TFract f1 = new TFract(2, 5);
            TFract f2 = new TFract(10, 12);
            bool actual = (f1 <= f2);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }
    }
}
