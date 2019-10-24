using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
            
            public void TestPush()
        {

                MyStack Ms = new MyStack();
                Ms.Push("1");
                Ms.Push("2");
                Ms.Push("3");
                Assert.AreEqual(3,Ms.Count());
          }
         public void TestPop()
            {
                MyStack Ms = new MyStack();
                Ms.Push("1");
                Ms.Push("2");
                Ms.Push("3");
                Assert.AreEqual(2,Ms.Pop());
                Assert.AreEqual(3,Ms.Pop());
            }
        public void TestPeek()
        {
            MyStack Ms = new MyStack();
            Ms.Push("1");
            Ms.Push("2");
            Ms.Push("3");
            Assert.AreEqual("3",Ms.Peek());
            Assert.AreEqual(3,Ms.Count());
        }
        public void TestCount()
        {

        }
    }


  }


