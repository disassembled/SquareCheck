using Maths;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class MathsTests
    {
        [TestMethod]
        public void CheckIfSquare()
        {
            var result = Calculator.Evaluate("");
            Assert.IsFalse(result.IsSquare);
            Assert.AreEqual(result.Message, "Enter a number");

            result = Calculator.Evaluate("5.5");
            Assert.IsFalse(result.IsSquare);
            Assert.AreEqual(result.Message, "Number is not square");

            result = Calculator.Evaluate("-1");
            Assert.IsFalse(result.IsSquare);
            Assert.AreEqual(result.Message, "Number is not square");

            result = Calculator.Evaluate("0");
            Assert.IsTrue(result.IsSquare);
            Assert.AreEqual(result.Message, "Number is square");

            result = Calculator.Evaluate("3");
            Assert.IsFalse(result.IsSquare);
            Assert.AreEqual(result.Message, "Number is not square");

            result = Calculator.Evaluate("4");
            Assert.IsTrue(result.IsSquare);
            Assert.AreEqual(result.Message, "Number is square");

            result = Calculator.Evaluate("25");
            Assert.IsTrue(result.IsSquare);
            Assert.AreEqual(result.Message, "Number is square");

            result = Calculator.Evaluate("26");
            Assert.IsFalse(result.IsSquare);
            Assert.AreEqual(result.Message, "Number is not square");
        }
    }
}