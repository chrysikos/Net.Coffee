using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace psv.SFP.ApiSpecification
{
    public class RJesResult<T>
    {
        public RJesResult(RJesCode code)
        {
            this.code = code;
        }
        public string status { get; set; }
        public RJesCode code { get; private set; }
        public string message { get; set; }
        public T data { get; set; }

        //public Task ExecuteResultAsync(ActionContext context)
        //{
        //    var executor = context.HttpContext.RequestServices.GetRequiredService<IActionResultExecutor<ObjectResult>>();
        //    return executor.ExecuteAsync(context, new ObjectResult(this));
        //}

        //public IActionResult Convert()
        //{
        //    ActionResult<RJesResult<T>> result = new ActionResult<RJesResult<T>>(this);
        //    var s = result as IConvertToActionResult;
        //    return s.Convert();

        //    return new ObjectResult(this);
        //}

        //public Task ExecuteResultAsync(ActionContext context)
        //{
        //    //JsonResult json = new JsonResult(this);
        //    //return json.ExecuteResultAsync(context);



        //    ActionResult<RJesResult<T>> result = new ActionResult<RJesResult<T>>(this);
        //    var s = result as IConvertToActionResult;
        //    return s.Convert().ExecuteResultAsync(context);
        //}
    }
}
