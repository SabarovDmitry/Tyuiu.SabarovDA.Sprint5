using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.SabarovDA.Sprint5.Task5.V15.Lib;
namespace Tyuiu.SabarovDA.Sprint5.Task5.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"D:\ReposVisualStud19\Tyuiu.SabarovDA.Sprint5\Tyuiu.SabarovDA.Sprint5.Task5.V15\bin\Debug\InPutDataFileTask5V15.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
