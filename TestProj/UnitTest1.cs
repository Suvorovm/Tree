using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tree;

namespace TestProj
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestmetodAdd()
        {
            DoubleList list = new DoubleList();
            string str = "123";
            list.AddWord(str);
            list.AddWord("321");
            list.AddWord("325");
            list.AddWord("321");
            str = "555";
           
        }
        [TestMethod]
        public void TestMetodSearch()
        {
            DoubleList list = new DoubleList();
            string str = "123";
            list.AddWord(str);
            if (list.SerchWord(str))
            {
                Debug.WriteLine("true");
            }
            else
            {
                Debug.WriteLine("false");
            }
        }
    }
}
