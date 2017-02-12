using System;
using IntegerFactors;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace IntegerFactorsTest
{
    [TestClass]
    public class PrimeFactorTests
    {
        [TestMethod]
        public void TestFactorPositiveNumber()
        {
            // Assign
            int[] expected = new int[3];
            int count = 0;
            expected[0] = 3;
            expected[1] = 3;
            expected[2] = 19;

            //Act
            var actual = PrimeFactors.Generate(171);

            //Assert
            foreach (int number in actual)
            {
                Assert.AreEqual(expected[count], number);
                ++count;
            }
        }
        [TestMethod]
        public void TestFactorNegativeNumber()
        {
            // Assign
            int[] expected = new int[3];
            int count = 0;
            expected[0] = -1;
            expected[1] = 2;
            expected[2] = 17;

            //Act
            var actual = PrimeFactors.Generate(-34);

            //Assert
            foreach (int number in actual)
            {
                Assert.AreEqual(expected[count], number);
                ++count;
            }
        }
        [TestMethod]
        public void TestFactorPrimeNumber()
        {
            // Assign
            int[] expected = new int[2];
            int count = 0;
            expected[0] = 1;
            expected[1] =19;
            

            //Act
            var actual = PrimeFactors.Generate(19);

            //Assert
            foreach (int number in actual)
            {
                Assert.AreEqual(expected[count], number);
                ++count;
            }
        }
        [TestMethod]
        public void TestFactorPrimeNegativeNumber()
        {
            // Assign
            int[] expected = new int[2];
            int count = 0;
            expected[0] = -1;
            expected[1] = 13;


            //Act
            var actual = PrimeFactors.Generate(-13);

            //Assert
            foreach (int number in actual)
            {
                Assert.AreEqual(expected[count], number);
                ++count;
            }
        }
        [TestMethod]
        public void TestFactorZero()
        {
            // Assign
            int expected = 0;

            //Act
            var actual = PrimeFactors.Generate(0);

            //Assert
            foreach (int number in actual)
            {
                Assert.AreEqual(expected, number);
            }
        }
        [TestMethod]
        public void TestFactorOne()
        {
            // Assign
            int expected = 1;

            //Act
            var actual = PrimeFactors.Generate(1);

            //Assert
            foreach (int number in actual)
            {
                Assert.AreEqual(expected, number);
            }
        }
        [TestMethod]
        public void TestFactorNegativeOne()
        {
            // Assign
            int expected = -1;

            //Act
            var actual = PrimeFactors.Generate(-1);

            //Assert
            foreach (int number in actual)
            {
                Assert.AreEqual(expected, number);
            }
        }
    }
}
