using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16._6._1.Tests
{
    [TestFixture]
    public class TaskTests
    {
        [Test]
        public void AdditionalMustReturnCorrectValue()
        {
            var calc = new Calculator();
            Assert.That(calc.Additional(200, 100) == 300);
        }

        [Test]
        public void SubtractionMustReturnCorrectValue()
        {
            var calc = new Calculator();
            Assert.That(calc.Subtraction(200, 100) == 100);
        }

        [Test]
        public void MiltiplicationMustReturnCorrectValue()
        {
            var calc = new Calculator();
            Assert.That(calc.Miltiplication(5, 5) == 25);
        }

        [Test]
        public void DivisionMustReturnCorrectValue()
        {
            var calc = new Calculator();
            Assert.That(calc.Division(5, 5) == 1);
           
        }

        [Test]
        public void DivisionMustThrowException()
        {
            var calc = new Calculator();
            Assert.Throws<DivideByZeroException>(()=>calc.Division(30,0));

        }


    }
}
