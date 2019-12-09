using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace IOSdk.ResponseModels
{
    public class ResetPasswordResponse
    {
        [JsonProperty("IsPosted")]
        public bool IsPosted { get; set; }
    }
}
