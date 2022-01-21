using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    public class GeneratorTest
    {
        public List<string> results = new List<string>();
        public int maxNumber = 100;
        [SetUp]
        public void Setup()
        {
            var generator = new Generator();
            results = generator.Generate(maxNumber);
        }

        [Test]
        public void Should_Generate_100_items()
        {
            Assert.AreEqual(100, results.Count);
        }

        [Test]
        public void Should_Return_String()
        {
            Assert.AreEqual("1", results[0]);
        }

        [Test]
        public void Third_Item_Should_Be_Fizz()
        {
            Assert.AreEqual("Fizz", results[8]);
        }

        [Test]
        public void Fifth_Item_Should_Be_Buzz()
        {
            Assert.AreEqual("Buzz",results[4]);
        }

        [Test]
        public void Fifteenth_Item_Shoul_Be_FizzBuzz()
        {
            Assert.AreEqual("FizzBuzz",results[14]);
        }
    }
}