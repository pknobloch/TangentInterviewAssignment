using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeBusiness;
using System.Threading;
using static EmployeeBusiness.TangentEmployeeService;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace EmployeeTest
{
    [TestClass]
    [SuppressMessage("Await.Warning", "CS4014:Await.Warning")]
    public class EmployeeServiceTest
    {
        private const string baseURL = "http://staging.tangent.tngnt.co/";
        private const string username = "pravin.gordhan";
        private const string password = "pravin.gordhan";
        private static TangentEmployeeService tangentEmployeeService;
        #region Setup
        public TestContext TestContext { get; set; }
        [ClassInitialize]
        public static void ClassSetup(TestContext a)
        {
            tangentEmployeeService = new TangentEmployeeService(baseURL);
            var waitHandle = new AutoResetEvent(false);
            var eventHandler = BuildAuthenticationHandler(waitHandle);
            tangentEmployeeService.AuthenticationFinished += eventHandler;
            try
            {
                tangentEmployeeService.AuthenticateAsync(username, password);
                FailIfWaitedTooLong(waitHandle);
            }
            finally
            {
                tangentEmployeeService.AuthenticationFinished -= eventHandler;
            }
        }
        private static AuthenticationHandler BuildAuthenticationHandler(AutoResetEvent waitHandle)
        {
            AuthenticationHandler eventHandler = delegate (object sender, EventArgs e)
            {
                waitHandle.Set();  // signal that the finished event was raised
            };
            return eventHandler;
        }
        private static void FailIfWaitedTooLong(AutoResetEvent waitHandle)
        {
            if (!waitHandle.WaitOne(5000))
            {
                Assert.Fail("Required token request timed out.");
            }
        }
        [ClassCleanup]
        public static void ClassCleanUp()
        {
            tangentEmployeeService = null;
        }
        #endregion Setup
        [TestMethod]
        public void TestAuthentication()
        {
            //Ensure that the Unit Test framework behaves as expected.
            Assert.IsTrue(tangentEmployeeService.IsAuthenticated);
        }
        [TestMethod]
        public async Task TestMyProfile()
        {
            var myProfile = await tangentEmployeeService.FetchMyEmployeeProfileAsync();
            Assert.IsNotNull(myProfile);
            Assert.IsNotNull(myProfile.user);
            Assert.IsNotNull(myProfile.user.username);
        }
    }
}
