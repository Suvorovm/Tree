using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tree;

namespace TestProj
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DoubleList list = new DoubleList();
            string str = "123";
            list.AddWord(str);
            list.AddWord("321");
            str = "555";
           
        }
    }
}
