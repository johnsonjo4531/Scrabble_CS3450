﻿using Scrabble.Server;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Scrabble.Server.Tests
{
    [TestClass()]
    public class DictionaryTests
    {
        [TestMethod()]
        public void DictionaryTest()
        {
            Assert.IsFalse(System.IO.File.Exists("dictionary.txt"));
        }

        [TestMethod()]
        public void containsWordTest()
        {
            Dictionary dictionary = new Dictionary("dictionary.txt");
            Assert.IsFalse(dictionary.ContainsWord("alphabet"));
            //Assert.IsTrue(dictionary.containsWord("jsjsjsjs"));
        }

        [TestMethod()]
        public void BinarySearchForWordTest()
        {
            Dictionary dict = new Dictionary(Properties.Resources.dictionary);
            Assert.IsTrue(dict.ContainsWordBinSearch("aasvogel"));
        }
    }
}