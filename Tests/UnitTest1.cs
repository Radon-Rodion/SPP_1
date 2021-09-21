using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortLibrary;
using System.IO;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        const string TESTING_FILES_LOCATION = "TestFiles\\";

        [TestMethod]
        public void TestQuickSortMethod()
        {
            string[] expectedOutput = {"\n", "Albedo", "Mice", "Moon", "Nice", "Nick is about to come", "Software", "Triangulation", "Welcome", "Yellow", "Yellowstone park", "Zero"};
            string[] testInput = { "Nice", "Welcome", "Software", "Albedo", "Mice", "\n", "Zero", "Moon", "Yellowstone park", "Nick is about to come",  "Triangulation",  "Yellow" };
            string[] output = Class1.SortLines(ref testInput, testInput.Length);
            CollectionAssert.AreEqual(expectedOutput, output, "String are sorted incorrectly!");
        }

        [TestMethod]
        public void TestEmptyFileProcessing()
        {
            Class1.ProcessFile(TESTING_FILES_LOCATION+"emptyInput.txt", TESTING_FILES_LOCATION+"emptyOutput.txt");
            Assert.IsTrue(CompareFiles(TESTING_FILES_LOCATION + "emptyExpected.txt", TESTING_FILES_LOCATION + "emptyOutput.txt"), "Output file is incorrect!");
        }

        [TestMethod]
        public void TestSmallFileProcessing()
        {
            Class1.ProcessFile(TESTING_FILES_LOCATION + "smallInput.txt", TESTING_FILES_LOCATION + "smallOutput.txt");
            Assert.IsTrue(CompareFiles(TESTING_FILES_LOCATION + "smallExpected.txt", TESTING_FILES_LOCATION + "smallOutput.txt"), "Output file is incorrect!");
        }

        [TestMethod]
        public void TestLargeFileProcessing()
        {
            Class1.ProcessFile(TESTING_FILES_LOCATION + "largeInput.txt", TESTING_FILES_LOCATION + "largeOutput.txt");
            Assert.IsTrue(CompareFiles(TESTING_FILES_LOCATION + "largeExpected.txt", TESTING_FILES_LOCATION + "largeOutput.txt"), "Output file is incorrect!");
        }

        private bool CompareFiles(string addr1, string addr2)
        {
            StreamReader addr1Reader = new StreamReader(addr1);
            StreamReader addr2Reader = new StreamReader(addr2);

            string line1, line2;
            do
            {
                line1 = addr1Reader.ReadLine();
                line2 = addr2Reader.ReadLine();
                if (line1 != line2) return false;
            } while (line1 != null && line2 != null);
            return true;
        }
    }
}
