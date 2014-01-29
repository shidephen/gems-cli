﻿using GemsCLI.Help;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GemsCLITests.Test.Help
{
    [TestClass]
    public class HelpResourceTests
    {
        [TestMethod]
        public void HelpResource()
        {
            HelpResource help = new HelpResource(Properties.Help.ResourceManager);
            Assert.AreEqual(Properties.Help.Width, help.Get("width"));
            Assert.AreEqual(Properties.Help.Height, help.Get("height"));
        }
    }
}