namespace psv.SFP.ApiSpecification
{
    public enum RJesCode
    {
        OK = 200,
        Created = 201,
        Accepted = 202,
        NoContent = 204,

        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 403,
        NotFound = 404,

        InternalServerError = 500,
        NotImplemented = 501
    }
}
