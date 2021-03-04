using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using RQ_0x1_CodeLines;

namespace SourceCodeTests
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void Main_NonexistentPathPassed_ReturnsOne()
        {
            string[] path = { "" };

            int result = Program.Main(path);

            Assert.AreEqual(1, result);
        }
    }
}
