using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.SabarovDA.Sprint5.Task0.V29.Lib;
namespace Tyuiu.SabarovDA.Sprint5.Task0.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"D:\ReposVisualStud19\Tyuiu.SabarovDA.Sprint5\Tyuiu.SabarovDA.Sprint5.Task0.V29\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExsist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExsist);
        }
    }
}
