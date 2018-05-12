using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmployeeTest
{
    [TestClass]
    public class EmployeeServiceTest
    {
        #region Setup
        private static string token = null;
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        [ClassInitialize]
        public static void ClassSetup(TestContext a)
        {
            token = "setup";
        }
        [ClassCleanup]
        public static void ClassCleanUp()
        {
            token = null;
        }
        #endregion Setup
        [TestMethod]
        public void TestAuthentication()
        {
            //Ensure that the Unit Test framework behaves as expected.
            Assert.IsNotNull(token);
        }
    }
}
