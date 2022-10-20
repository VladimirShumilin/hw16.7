

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AdditionalAlwaysReturnsExpectedValue()
        {
            var calculatorTest = new Practices.Calculator();
            Assert.That(calculatorTest.Additional(10, 220), Is.EqualTo(230));
        }

        [Test]
        public void SubtractionAlwaysReturnsExpectedValue()
        {
            var calculatorTest = new Practices.Calculator();
            Assert.That(calculatorTest.Subtraction(220, 10), Is.EqualTo(210));
        }

        [Test]
        public void MiltiplicationAlwaysReturnsExpectedValue()
        {
            var calculatorTest = new Practices.Calculator();
            Assert.That(calculatorTest.Miltiplication(220, 10), Is.EqualTo(2200));
        }

        [Test]
        public void DivisionAlwaysReturnsExpectedValue()
        {
            var calculatorTest = new Practices.Calculator();
            Assert.That(calculatorTest.Division(220, 10), Is.EqualTo(22));
        }
        [Test]
        public void DivisionMustThrowException()
        {
            var calculator = new Practices.Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(30, 0));
        }
    }
}