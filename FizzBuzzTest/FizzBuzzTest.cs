using System;
using NUnit.Framework;

namespace Katas
{
    [TestFixture]
    public class NUnitTest1
    {
        [Test]
        public void ShouldReturn1For1() {
            FizzBuzz _fizzBuzz = new FizzBuzz();

            //Values are not a multiple of 3 or 5
            Assert.AreEqual("1", _fizzBuzz.Process(1));
            Assert.AreEqual("4", _fizzBuzz.Process(4));
            Assert.AreEqual("7", _fizzBuzz.Process(7));
        }

        [Test]
        public void ShouldTriggerError()
        {
            FizzBuzz _fizzBuzz = new FizzBuzz();

            //Value is > 100
            Assert.Catch<ArgumentOutOfRangeException>(() => _fizzBuzz.Process(101));
            Assert.Catch<ArgumentOutOfRangeException>(() => _fizzBuzz.Process(102));
            Assert.Catch<ArgumentOutOfRangeException>(() => _fizzBuzz.Process(105));

            //Value is < 100
            Assert.Catch<ArgumentOutOfRangeException>(() => _fizzBuzz.Process(0));
            Assert.Catch<ArgumentOutOfRangeException>(() => _fizzBuzz.Process(-3));
            Assert.Catch<ArgumentOutOfRangeException>(() => _fizzBuzz.Process(-5));
        }

        [Test]
        public void ShouldReturnFizz() {
            var _fizzBuzz = new FizzBuzz();
            Assert.AreEqual("Fizz", _fizzBuzz.Process(3));
            Assert.AreEqual("Fizz", _fizzBuzz.Process(18));
            Assert.AreEqual("Fizz", _fizzBuzz.Process(66));
            Assert.AreEqual("Fizz", _fizzBuzz.Process(42));
        }

        [Test]
        public void ShouldReturnBuzz()
        {
            var _fizzBuzz = new FizzBuzz();
            Assert.AreEqual("Buzz", _fizzBuzz.Process(5));
            Assert.AreEqual("Buzz", _fizzBuzz.Process(50));
            Assert.AreEqual("Buzz", _fizzBuzz.Process(70));
            Assert.AreEqual("Buzz", _fizzBuzz.Process(100));
        }

        [Test]
        public void ShouldReturnFizzBuzz()
        {
            var _fizzBuzz = new FizzBuzz();
            Assert.AreEqual("FizzBuzz", _fizzBuzz.Process(15));
            Assert.AreEqual("FizzBuzz", _fizzBuzz.Process(30));
            Assert.AreEqual("FizzBuzz", _fizzBuzz.Process(45));
            Assert.AreEqual("FizzBuzz", _fizzBuzz.Process(75));
            Assert.AreEqual("FizzBuzz", _fizzBuzz.Process(90));
        }
    }
}