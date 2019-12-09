using System;
using System.Collections.Generic;
using System.Text;

namespace IOSdk.RequestModels
{
    public class ChangeUserPasswordRequestModel
    {
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
