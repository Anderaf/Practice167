using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice167.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AdditionMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.True(calculator.Addition(3, 10) == 13);
        }
        [Test]
        public void SubstractionMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.True(calculator.Substraction(10, 3) == 7);
        }
        [Test]
        public void MultiplicationMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.True(calculator.Multiplication(10, 3) == 30);
        }
        [Test]
        public void DivisionMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.True(calculator.Division(9, 3) == 3);
        }
        [Test]
        public void DivisionMustThrowDivideByZeroException()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(1,0));
        }
    }
}
