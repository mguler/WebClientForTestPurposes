using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace System.Net.WebClientForTestPurpose.Test
{
    [TestClass]
    public class WebRequestTestPurposeTest
    {
        [TestMethod]
        public void GetExpectedResponse()
        {
            var expectedResponse= "Expected Response From The Server";
            var url = "http://the_url_which_is_will_never_be_invoked.com";
            var webClientTestPurpose = new WebClientTestPurpose(expectedResponse);
            var response = webClientTestPurpose.DownloadString(url);

            Assert.IsTrue(expectedResponse == response);
        }
    }
}
