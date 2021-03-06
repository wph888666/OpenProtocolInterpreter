﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenProtocolInterpreter.PowerMACS;

namespace MIDTesters.PowerMACS
{
    [TestClass]
    public class TestMid0108 : MidTester
    {
        [TestMethod]
        public void Mid0108AllRevisions()
        {
            string package = "00210108002         1";
            var mid = _midInterpreter.Parse<Mid0108>(package);

            Assert.AreEqual(typeof(Mid0108), mid.GetType());
            Assert.IsNotNull(mid.BoltData);
            Assert.AreEqual(package, mid.Pack());
        }
    }
}
