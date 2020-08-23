using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace psv.SFP.ApiSpecification
{
    public class RJesObjectResult : RJesResult<object> , IConvertToActionResult
    {
        public RJesObjectResult(RJesCode code) : base(code)
        {

        }

        public IActionResult Convert()
        {
            ObjectResult objectResult = new ObjectResult(this);
            return objectResult;
        }
    }
}
