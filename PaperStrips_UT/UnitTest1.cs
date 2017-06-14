using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaperStrips;

namespace PaperStrips_UT
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MinPiecesTest()
        {
            Assert.AreEqual(3, PaperStrips.Program.MinPieces(new int[] { 1, 4, 3, 2 }, new int[] { 1, 2, 4, 3 }));
            Assert.AreEqual(4, PaperStrips.Program.MinPieces(new int[] { 1, 5, 2, 4, 3 }, new int[] { 1, 3, 4, 5, 2}));
            Assert.AreEqual(7, PaperStrips.Program.MinPieces(new int[] { 3, 4, 2, 9, 6, 1, 5, 7, 8 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }));
            Assert.AreEqual(3, PaperStrips.Program.MinPieces(new int[] { 1, 2, 5, 6, 3, 4 }, new int[] { 1, 2, 3, 4, 5, 6 }));
            Assert.AreEqual(3, PaperStrips.Program.MinPieces(new int[] { 1, 2, 5, 6, 3, 4, 7 }, new int[] { 1, 2, 3, 4, 7, 5, 6 }));
        }
    }
}
