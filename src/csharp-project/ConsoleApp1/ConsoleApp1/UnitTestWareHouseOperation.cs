using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ConsoleApp1
{
    [TestClass]
    public class UnitTestWareHouseOperation
    {
        [TestMethod]
        public void Test_addItem()
        {
            WareHouseOperation wh = new WareHouseOperation();
            int res = wh.addItem(5, 25);
            Assert.AreEqual(res, 30);
        }

        [TestMethod]
        public void Test_removeItem()
        {
            WareHouseOperation wh = new WareHouseOperation();
            int res = wh.removeItem(25, 15);
            Assert.AreEqual(res, 10);
        }

        [TestMethod]
        public void Test_valueItem()
        {
            WareHouseOperation wh = new WareHouseOperation();
            int res = wh.valueItem(8, 10);
            Assert.AreEqual(res, 80);
        }
    }
}




