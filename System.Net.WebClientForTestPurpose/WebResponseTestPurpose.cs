using System.IO;
using System.Text;

namespace System.Net.WebClientForTestPurpose
{
    public class WebResponseTestPurpose : WebResponse
    {
        public override long ContentLength { get => _response.Length; }

        private readonly byte[] _response;
        public WebResponseTestPurpose(string response)
        {
            _response = Encoding.Default.GetBytes(response);
        }
        public override Stream GetResponseStream()
        {
            var memoryStream = new MemoryStream(_response);
            memoryStream.Position = 0;
            return memoryStream;
        }
    }
}
