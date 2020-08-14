using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VideoRentalUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DatabaseConnectionTest()
        {
            try
            {

                Database dh = new Database();
                string result = da.DatabaseConnection();
                Assert.AreEqual("Connected", result);



            }
            catch (Exception ex)
            {
                Console.WriteLine("Test Failed: " + ex.ToString());
                Assert.Fail();
            }
        }
    }
}
