using IOSdk.RequestModels;

namespace IOSdk
{
    public class API
    {
        public UserRegisterationModel Register(UserRegisterationModel payload)
        {
            var result=new HttpUtility().call<UserRegisterationModel>(payload);
            return result;
        }
    }
}
