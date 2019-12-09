using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace IOSdk.ResponseModels
{
	///<summary>
	///Model class ResendVerificationResponse
	///</summary>
    class ResendVerificationResponse
    {
        [JsonProperty("IsPosted")]
        public bool IsPosted { get; set; }
    }
}
