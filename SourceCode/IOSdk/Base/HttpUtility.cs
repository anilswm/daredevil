using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using RestSharp;

namespace IOSdk.Base
{
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
                request.AddParameter("application/json", body, ParameterType.RequestBody);
            }
            return new Tuple<RestClient, RestRequest>(restClient, request);
        }

        public T call<T>(string url,object payload,RestSharp.Method method)
        {
            var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(payload);
            
            try
            {
                var result = Invoke(url, null, method, null,
                    jsonString);

                if (result.IsResponseOK())
                {
                    var apiResponse = JsonConvert.DeserializeObject<T>(result.Response);
                    return apiResponse;
                }

            }
            catch (Exception ex)
            {
                
            }
            return default(T);

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
        
    }
}
