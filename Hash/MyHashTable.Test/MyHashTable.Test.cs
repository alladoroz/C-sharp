using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hash_table;

namespace MyHashTable.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MyHashTable<String> test = new MyHashTable<String>();
            test.add("ololo");
            Assert.IsTrue(test.contain("ololo"));
        }
    }
}
