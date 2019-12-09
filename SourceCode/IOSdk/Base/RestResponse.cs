using System.Net;

namespace IOSdk.Base
{
    public class RestResponse
    {
        public HttpStatusCode Status { get; set; }
        public string Response { get; set; }

        public bool IsResponseOK()
        {
            return Status == HttpStatusCode.OK;
        }

        public bool IsResponseCreated()
        {
            return Status == HttpStatusCode.Created;
        }
    }
}