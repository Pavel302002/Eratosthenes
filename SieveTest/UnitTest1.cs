using NUnit.Framework;
using EratosthenesProject;
using System.Collections.Generic;

namespace SieveTest
{
    public class Tests
    {
        Eratosthenes era;

        [SetUp]
        public void Setup()
        {
            era = new Eratosthenes();
        }

        [Test]
        public void TestList()
        {
            int n = 7;
            era.Init(n);
            var actual = era.GetSieve();
            var expected = new List<int>() { 2, 3, 5, 7, 11, 13, 17 };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestString()
        {
            int n = 6;
            era.Init(n);
            var simpleNumbers = era.GetSieve();
            string actual = era.ToStr(simpleNumbers);
            string expected = "2; 3; 5; 7; 11; 13; ";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestListMinus()
        {
            int n = -925;
            era.Init(n);
            var actual = era.GetSieve();
            string expected = null;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestListNull()
        {
            int n = 0;
            era.Init(n);
            var actual = era.GetSieve();
            string expected = null;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestListLargeNumber()
        {
            int n = 23985;
            era.Init(n);
            var actual = era.GetSieve();
            string expected = null;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestStringNull()
        {
            List<int> simpleNumbers = null;
            var actual = era.ToStr(simpleNumbers);
            string expected = null;
            Assert.AreEqual(expected, actual);
        }
    }
}