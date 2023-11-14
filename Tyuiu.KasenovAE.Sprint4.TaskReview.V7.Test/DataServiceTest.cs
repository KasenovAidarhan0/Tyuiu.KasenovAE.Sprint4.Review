using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KasenovAE.Sprint4.TaskReview.V7.Lib;

namespace Tyuiu.KasenovAE.Sprint4.TaskReview.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMatrix()
        {
            string str = "31415926";
            DataService ds = new DataService();
            int[,] mtrx = ds.TransformMatrix(str);
            int[,] resMtrx = new int[,] { {3, 1}, {4, 1}, {5, 9}, {2, 6} };
            CollectionAssert.AreEqual(mtrx, resMtrx);
        }
        [TestMethod]
        public void TestCount()
        {
            string str = "31415926";
            DataService ds = new DataService();
            int[,] mtrx = ds.TransformMatrix(str);
            int count = ds.CountOdd(mtrx);
            Assert.AreEqual(count, 5);
        }
    }
}
