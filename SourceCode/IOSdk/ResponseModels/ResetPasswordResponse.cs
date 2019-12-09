using System;
using System.Collections.Generic;
using System.Text;

namespace IOSdk.ResponseModels
{
    public class ResetPasswordResponse
    {
        [JsonProperty("IsPosted")]
        public bool IsPosted { get; set; }
    }
}
