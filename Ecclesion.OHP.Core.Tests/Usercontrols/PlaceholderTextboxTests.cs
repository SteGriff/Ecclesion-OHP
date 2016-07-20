using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ecclesion.OHP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecclesion.OHP.Tests
{
    [TestClass()]
    public class PlaceholderTextboxTests
    {
        [TestMethod()]
        public void PlaceholderTextboxWithNoUserInput()
        {
            PlaceholderTextbox tb = new PlaceholderTextbox("Search");
            Assert.IsFalse(tb.HasUserContent);
        }

        [TestMethod()]
        public void PlaceholderTextboxWithUserInput()
        {
            PlaceholderTextbox tb = new PlaceholderTextbox("Search");
            tb.Text = "Hello World";

            Assert.IsTrue(tb.HasUserContent);
        }
    }
}