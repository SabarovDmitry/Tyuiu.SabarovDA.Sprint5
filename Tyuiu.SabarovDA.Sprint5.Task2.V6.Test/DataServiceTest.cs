using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SabarovDA.Sprint5.Task2.V6.Lib;
using System.IO;
namespace Tyuiu.SabarovDA.Sprint5.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"D:\ReposVisualStud19\Tyuiu.SabarovDA.Sprint5\Tyuiu.SabarovDA.Sprint5.Task2.V6\bin\Debug\OutPutFileTask2.csv";
            FileInfo file = new FileInfo(path);
            bool exists = file.Exists;
            bool wait = true;
            Assert.AreEqual(wait, exists);
        }
    }
}
