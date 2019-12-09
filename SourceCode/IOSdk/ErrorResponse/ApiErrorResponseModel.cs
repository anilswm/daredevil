using System;
using System.Collections.Generic;
using System.Text;

namespace IOSdk.ErrorResponse
{
    public class ApiErrorResponseModel
    {
        public int ErrorCode { get; set; }
        public string Message { get; set; }
        public string Description { get; set; }
    }
}
