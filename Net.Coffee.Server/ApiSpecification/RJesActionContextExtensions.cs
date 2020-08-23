using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using System;

namespace psv.SFP.ApiSpecification
{
    public static class RJesActionContextExtensions
    {
        public static bool ReturnsRJesResult(this ActionContext context)
        {
            var descriptor = ((ControllerActionDescriptor)context.ActionDescriptor);
            return descriptor.MethodInfo.ReturnType.FullName.Contains("rjes", StringComparison.OrdinalIgnoreCase);
        }
    }
}
