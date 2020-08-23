namespace psv.SFP.ApiSpecification
{
    public class RJesInternalServerErrorObjectResult : RJesObjectResult
    {
        public RJesInternalServerErrorObjectResult()
            : base(RJesCode.InternalServerError)
        {

        }
    }
}
