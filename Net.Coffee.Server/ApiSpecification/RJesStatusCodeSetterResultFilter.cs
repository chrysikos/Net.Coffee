using Microsoft.AspNetCore.Mvc.Filters;
using System.Threading.Tasks;

namespace psv.SFP.ApiSpecification
{
    public class RJesStatusCodeSetterResultFilter : IAsyncAlwaysRunResultFilter
    {
        public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            if (context.ReturnsRJesResult())
            {
                var mvcObject = context.Result as Microsoft.AspNetCore.Mvc.ObjectResult;
                var rjesObjectResult = mvcObject.Value as RJesObjectResult;
                context.HttpContext.Response.StatusCode = (int)rjesObjectResult.code;

                //var rjesObjectResult = context.Result as RJesObjectResult;
                //context.HttpContext.Response.StatusCode = (int)rjesObjectResult.code;
            }
            await next();
        }
    }
}
