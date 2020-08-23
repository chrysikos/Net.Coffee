namespace psv.SFP.ApiSpecification
{
    public class RJesNotFoundObjectResult : RJesObjectResult
    {
        public RJesNotFoundObjectResult()
            : base(RJesCode.NotFound)
        {

        }
    }
}
