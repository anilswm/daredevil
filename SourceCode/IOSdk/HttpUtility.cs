using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using RestSharp;

namespace IOSdk
{
    public static class Utility
    {
        public static bool IsNotNullOrEmpty<T>(this IEnumerable<T> value)
        {
            return value != null && value.Any();
        }

        public static bool IsNotNullOrEmptyOrWhiteSpace(this string Value)
        {
            return !Value.IsNullOrEmptyOrWhiteSpace();
        }
        public static bool IsNullOrEmptyOrWhiteSpace(this string Value)
        {
            return string.IsNullOrWhiteSpace(Value) || Value.Length == 0;
        }
    }
    public class HttpUtility
    {
        
        
        Tuple<RestClient, RestRequest> Call(string url, Dictionary<string, string> data, RestSharp.Method method,
            Dictionary<string, string> headers, string body)
        {
            var restClient =
                new RestClient(url) { UserAgent = "daredevils" };

            var request = new RestRequest(method);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("User-Agent", "daredevils");
            if (data.IsNotNullOrEmpty())
            {
                foreach (var item in data)
                {
                    request.AddParameter(item.Key, item.Value);
                }
            }

            if (headers.IsNotNullOrEmpty())
            {
                foreach (var item in headers)
                {
                    request.AddHeader(item.Key, item.Value);
                }
            }

            if (body.IsNotNullOrEmptyOrWhiteSpace())
            {
                request.RequestFormat = DataFormat.Json;
                request.AddParameter("application/json; charset=utf-8", body, ParameterType.RequestBody);
            }
            return new Tuple<RestClient, RestRequest>(restClient, request);
        }

        public T call<T>(object payload)
        {
            var passwordHookEndpoint = "";



           var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(payload);
            //try
            //{
                var result = Invoke(passwordHookEndpoint, null, RestSharp.Method.POST, null,
                    jsonString);

                if (result.IsResponseOK())
                {
                    var apiResponse = JsonConvert.DeserializeObject<T>(result.Response);
                }
                
            //}
            //catch (OAuthException ex)
            //{
            //    try
            //    {
            //        cloudApiErrorResponse =
            //            Newtonsoft.Json.JsonConvert.DeserializeObject<CloudAPIErrorResponse>(ex.Message);
            //    }
            //    catch { }

            //    return APIStatusCode.ERROR_FROM_CLOUD_API_SIDE;
            //}
        
    }
        RestResponse Invoke(string url, Dictionary<string, string> data, RestSharp.Method method,
            Dictionary<string, string> headers, string body)
        {
            var request = Call(url, data, method, headers, body);

            var result = request.Item1.Execute(request.Item2);

            var returnresponse = new RestResponse
            {
                Response = result.Content,
                Status = result.StatusCode
            };
            return returnresponse;
        }
        public class RestResponse
        {
            public HttpStatusCode Status { get; set; }
            public string Response { get; set; }

            public bool IsResponseOK()
            {
                return Status == HttpStatusCode.OK;
            }

            public bool IsResponseCreated()
            {
                return Status == HttpStatusCode.Created;
            }
        }
    }
}
