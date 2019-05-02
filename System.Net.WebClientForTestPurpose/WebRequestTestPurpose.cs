using System.IO;

namespace System.Net.WebClientForTestPurpose
{
    /// <summary>
    /// 
    /// </summary>
    public class WebRequestTestPurpose : WebRequest
    {
        public override Uri RequestUri { get => _uri; }
        private readonly Uri _uri;
        private readonly string _response;

        public WebRequestTestPurpose(Uri uri, string response)
        {
            _uri = uri;
            _response = response;
        }

        public override Stream GetRequestStream()
        {
            return new MemoryStream();
        }
        public override WebResponse GetResponse()
        {
            return new WebResponseTestPurpose(_response);
        }
    }
}
