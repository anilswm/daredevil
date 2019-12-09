using System;
using System.Collections.Generic;
using System.Text;

namespace IOSdk.ResponseModels
{
    public class CheckEmail
    {
        [JsonProperty("IsPosted")]
        public bool IsExist { get; set; }
    }
}
