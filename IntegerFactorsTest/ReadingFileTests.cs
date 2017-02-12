using System;
using IntegerFactors;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
namespace IntegerFactorsTest
{
    [TestClass]
    public class ReadingFileTests
    {
        [TestMethod]
        public void TestFileLoadSucessful()

        {
            //Assign
            int[] expected = new int[15];
            string filename = "c:\\users\\mikeg\\documents\\test.txt";

            expected[0] = 32;
            expected[1] = 48;
            expected[2] = 64;
            expected[3] = 171;
            expected[4] = 81;
            expected[5] = 19;
            expected[6] = 54;
            expected[7] = 13;
            expected[8] = 0;
            expected[9] = 1;
            expected[10] = -34;
            expected[11] = -1;
            expected[12] = 21;
            expected[13] = 15;
            expected[14] = 421;
            

            //Act


            var actual = FileIO.ReadtheFile(filename);
            //Assert
            int count = 0;
            foreach (int number in actual)
            {
                Assert.AreEqual(expected[count], number);
                ++count;
            }
        }
        [TestMethod]
        public void TestFileDoesNotExist()

        {
            //Assign
            string filename = "c:\\text.txt";
            //Assert
            try
            {
                var actual = FileIO.ReadtheFile(filename);
            }
            catch (FileNotFoundException)
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.IsTrue(false);
            
            //Act
            //Assert
           
        }
        [TestMethod]
        public void TestFileLoadBadDataType()

        {
            //Assign
            string filename = "c:\\users\\mikeg\\documents\\test2.txt";
            //Act
            try
            {
                var actual = FileIO.ReadtheFile(filename);
            }
            catch (InvalidDataException)
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.IsTrue(false);
            //Assert
       }
    }
}
