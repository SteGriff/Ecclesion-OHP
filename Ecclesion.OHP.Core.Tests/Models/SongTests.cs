using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ecclesion.OHP.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ecclesion.OHP.Core.Models.Tests
{
    [TestClass()]
    public class SongTests
    {
        [TestMethod()]
        public void FirstLineForSongWithOneLine()
        {
            var aSong = new Song();
            aSong.Lyrics = "Hello";

            string expected = "Hello";
            string actual = aSong.FirstLine;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FirstLineForSongWithMultipleLines()
        {
            var aSong = new Song();
            aSong.Lyrics = "The splendour of the King\r\nClothed in Majesty";

            string expected = "The splendour of the King";
            string actual = aSong.FirstLine;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void HashTest()
        {
            var aSong = new Song("How great is our God");
            aSong.Lyrics = "The splendour of the King\r\nClothed in Majesty";

            string actual = aSong.Hash;

            //Test that length of hashed value is correct
            Assert.AreEqual(actual.Length, 16);

            //Test that exception is not thrown on this line:
            Path.Combine("C:/", actual);

            //Test passed
            Assert.IsTrue(true);
        }
    }
}