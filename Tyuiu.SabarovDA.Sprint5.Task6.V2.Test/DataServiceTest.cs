using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SabarovDA.Sprint5.Task6.V2.Lib;
using System.IO;
namespace Tyuiu.SabarovDA.Sprint5.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"D:\DataSprint5\InPutDataFileTask6V2.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"D:\DataSprint5\InPutDataFileTask6V2.txt";
            var res = ds.LoadFromDataFile(path);
            int wait = 22;
            Assert.AreEqual(wait, res);
        }
    }
}
