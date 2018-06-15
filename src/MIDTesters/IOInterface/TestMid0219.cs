﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenProtocolInterpreter.IOInterface;

namespace MIDTesters.IOInterface
{
    [TestClass]
    public class TestMid0219 : MidTester
    {
        [TestMethod]
        public void Mid0219Revision1()
        {
            string package = "00230219            102";
            var mid = _midInterpreter.Parse<MID_0219>(package);

            Assert.AreEqual(typeof(MID_0219), mid.GetType());
            Assert.IsNotNull(mid.RelayNumber);
            Assert.AreEqual(package, mid.Pack());
        }
    }
}
