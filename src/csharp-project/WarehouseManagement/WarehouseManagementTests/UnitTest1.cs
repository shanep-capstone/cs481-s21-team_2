using NUnit.Framework;
using System.IO;
using System;
namespace WarehouseManagementTests
{
    public class Tests
    {
        private const string Expected = "Hello World!";


        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Assert.Pass();
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                WarehouseManagement.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);

            }
        }

    }
}