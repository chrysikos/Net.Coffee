using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace psv.SFP.ApiSpecification
{
    public class RJesExceptionHandlerFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if (context.ReturnsRJesResult())
            {
                var rjesObjectResult = RJesExceptionHandler.Handle(context.Exception);
                context.ExceptionHandled = true;
                context.Result = rjesObjectResult.Convert();
            }
        }
    }
}
