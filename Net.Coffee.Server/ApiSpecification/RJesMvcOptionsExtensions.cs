using Microsoft.AspNetCore.Mvc;
using System;

namespace psv.SFP.ApiSpecification
{
    public static class RJesMvcOptionsExtensions
    {
        public static void AddRJes(this MvcOptions options)
        {

            options.Filters.Add<RJesExceptionHandlerFilter>();
            options.Filters.Add<RJesStatusCodeSetterResultFilter>(0);
        }
    }
}
