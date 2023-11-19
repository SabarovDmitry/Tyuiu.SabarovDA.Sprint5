using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.SabarovDA.Sprint5.Task1.V19.Lib;
namespace Tyuiu.SabarovDA.Sprint5.Task1.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"D:\ReposVisualStud19\Tyuiu.SabarovDA.Sprint5\Tyuiu.SabarovDA.Sprint5.Task1.V19\bin\Debug\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
