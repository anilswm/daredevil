using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace IOSdk.RequestModels
{
    public class ResetUserPasswordRequestModel
    {
        public string ResetToken { get; set; }      
        public string Password { get; set; }
    }
}
