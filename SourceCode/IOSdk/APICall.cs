using IOSdk.RequestModels;
using IOSdk.ResponseModels;
using RestSharp;

namespace IOSdk
{
    public static class Config
    {
        public static string ApiKey { get; set; }
        public static string ApiSecret { get; set; }
    }
    public class API
    {
        public UserRegistrationRespose Register(UserRegisterationModel payload)
        {
            var requestUrl = $"https://api.loginradius.io/v1/register?apiKey={Config.ApiKey}";
            var result=new HttpUtility().call<UserRegistrationRespose>(requestUrl, payload,Method.POST);
            return result;
        }

        public LoginResponse Login(UserLoginModel payload)
        {
            var requestUrl = $"https://api.loginradius.io/v1/login?apiKey={Config.ApiKey}";
            var result = new HttpUtility().call<LoginResponse>(requestUrl, payload, Method.POST);
            return result;
        }
    }
}
