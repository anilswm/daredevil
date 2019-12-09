using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace IOSdk.ResponseModels
{
	///<summary>
	///Model Class ResetPasswordResponse
	///</summary>
    public class ResetPasswordResponse
    {
        [JsonProperty("IsPosted")]
        public bool IsPosted { get; set; }
    }
}
