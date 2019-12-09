using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace IOSdk.ResponseModels
{
	///<summary>
	/// Model Class of Change Password from API Respose.
	///</summary>
    public class ChangePasswordResponse
    {
        [JsonProperty("IsPosted")]
        public bool IsPosted { get; set; }
    }
}
