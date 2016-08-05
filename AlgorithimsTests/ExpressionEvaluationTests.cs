using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithims;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims.Tests
{
    [TestClass()]
    public class ExpressionEvaluationTests
    {
        [TestMethod()]
        public void EvaluateTest()
        {
            Assert.AreEqual(2, ExpressionEvaluation.Evaluate("(1 + 1)"));
            Assert.AreEqual(2, ExpressionEvaluation.Evaluate("(4 - 2)"));
            Assert.AreEqual(8, ExpressionEvaluation.Evaluate("(2 ^ 3)"));
            Assert.AreEqual(4, ExpressionEvaluation.Evaluate("(2 * 2)"));
            Assert.AreEqual(1, ExpressionEvaluation.Evaluate("(2 / 2)"));

            Assert.AreEqual(8, ExpressionEvaluation.Evaluate("(((4 / 2) + 2) + 4)"));
            Assert.AreEqual(10, ExpressionEvaluation.Evaluate("(20 - 10)"));
        }
    }
}