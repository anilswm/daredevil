using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace IOSdk.ResponseModels
{
    public class VerifyEmail
    {
        [JsonProperty("IsPosted")]
        public bool IsPosted { get; set; }
    }
}
