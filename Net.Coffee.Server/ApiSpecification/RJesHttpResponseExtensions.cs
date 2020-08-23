//using Microsoft.AspNetCore.Http;
//using psv.SFP.Infrastructure;
//using psv.SFP.Serialization.Abstractions;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading.Tasks;

//namespace psv.SFP.ApiSpecification
//{
//    public static class RJesHttpResponseExtensions
//    {
//        public static async Task RJesAsync(this HttpResponse response, IJsonConverter jsonConverter, RJesObjectResult rJesObjectResult)
//        {
//            response.Headers["Content-Type"] = "application/json; charset=utf-8";
//            response.StatusCode = (int)rJesObjectResult.code;
//            var result = jsonConverter.Serialize(rJesObjectResult);
//            var bytes = SFPEncoding.Get().GetBytes(result);
//            await response.Body.WriteAsync(bytes, 0, bytes.Length);
//            response.Body.Position = 0;
//        }
//    }
//}
