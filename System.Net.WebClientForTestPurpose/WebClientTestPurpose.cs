/// <summary>
/// this namespace contains derived classes 
/// </summary>
namespace System.Net.WebClientForTestPurpose
{
    /// <summary>
    /// This class derived from System.Net.Webclient for use to implement test cases
    /// </summary>
    public class WebClientTestPurpose : WebClient
    {
        /// <summary>
        /// this field contains expected response which is passed into constructor
        /// </summary>
        private readonly string _response;
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="response"></param>
        public WebClientTestPurpose(string response)
        {
            _response = response;
        }
        /// <summary>
        /// this overridden method supplies WebRequestTestPurpose instance which is derived from System.Net.WebRequest
        /// </summary>
        /// <param name="address">Url to be invoked</param>
        /// <returns><see cref="System.Net.WebRequestTestPurpose"/>System.Net.WebRequestTestPurpose</returns>
        protected override WebRequest GetWebRequest(Uri address)
        {
            return new WebRequestTestPurpose(address, _response);
        }

        protected override WebResponse GetWebResponse(WebRequest request, IAsyncResult result)
        {
            return new WebResponseTestPurpose(_response);
        }

        protected override WebResponse GetWebResponse(WebRequest request)
        {
            return new WebResponseTestPurpose(_response);
        }
    }
}
