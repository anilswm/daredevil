using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace IOSdk.ResponseModels
{
	///<summary>
	/// Model Class of VerifyEmail
	///</summary>
    public class VerifyEmail
    {
        [JsonProperty("IsPosted")]
        public bool IsPosted { get; set; }
    }
}
