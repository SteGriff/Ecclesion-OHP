using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ecclesion.OHP.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecclesion.OHP.Core.Tests
{
    [TestClass()]
    public class SlideFactoryTests
    {
        [TestMethod()]
        public void SlideFactoryTest()
        {
            string longContent = "For\r\nEvery\r\nSong\r\nFor\r\nEvery\r\nBreath\r\nFor\r\nEvery\r\nGood\r\nAnd\r\nPerfect\r\nGift\r\nYou\r\nGive";

            var factory = new SlideFactory(longContent, 32, 600, 400);

            Assert.IsTrue(factory.Slides.Count > 1);
        }
    }
}