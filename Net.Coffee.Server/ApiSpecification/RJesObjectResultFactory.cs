namespace psv.SFP.ApiSpecification
{
    public static class RJesObjectResultFactory
    {
        public static RJesObjectResult FactoryCreate(string status, object data, RJesCode code, string message)
        {

            RJesObjectResult rjesobject = null;
            switch (code)
            {
                case RJesCode.OK:
                    rjesobject = new RJesOkObjectResult();
                    break;
                case RJesCode.Created:
                    rjesobject = new RJesCreatedObjectResult();
                    break;
                case RJesCode.Accepted:
                    rjesobject = new RJesAcceptedObjectResult();
                    break;
                case RJesCode.NoContent:
                    rjesobject = new RJesNoContentObjectResult();
                    break;
                case RJesCode.BadRequest:
                    rjesobject = new RJesBadRequestObjectResult();
                    break;
                case RJesCode.Unauthorized:
                    rjesobject = new RJesUnauthorizedObjectResult();
                    break;
                case RJesCode.Forbidden:
                    rjesobject = new RJesForbiddenObjectResult();
                    break;
                case RJesCode.NotFound:
                    rjesobject = new RJesNotFoundObjectResult();
                    break;
                case RJesCode.InternalServerError:
                    rjesobject = new RJesInternalServerErrorObjectResult();
                    break;
                case RJesCode.NotImplemented:
                    rjesobject = new RJesNotImplementedObjectResult();
                    break;
            }

            rjesobject.status = status;
            rjesobject.data = data;
            rjesobject.message = message;
            return rjesobject;
        }

        //2XX -> success
        public static RJesOkObjectResult OK(object data, string message)
        {
            return FactoryCreate(RJesStatus.success, data, RJesCode.OK, message) as RJesOkObjectResult;
        }
        public static RJesCreatedObjectResult Created(object data, string message)
        {
            return FactoryCreate(RJesStatus.success, data, RJesCode.Created, message) as RJesCreatedObjectResult;
        }
        public static RJesAcceptedObjectResult Accepted(object data, string message)
        {
            return FactoryCreate(RJesStatus.success, data, RJesCode.Accepted, message) as RJesAcceptedObjectResult;
        }
        public static RJesNoContentObjectResult NoContent(object data, string message)
        {
            return FactoryCreate(RJesStatus.success, data, RJesCode.NoContent, message) as RJesNoContentObjectResult;
        }
        //4XX -> fail
        public static RJesBadRequestObjectResult BadRequest(object data, string message)
        {
            return FactoryCreate(RJesStatus.fail, data, RJesCode.BadRequest, message) as RJesBadRequestObjectResult;
        }
        public static RJesUnauthorizedObjectResult Unauthorized(object data, string message)
        {
            return FactoryCreate(RJesStatus.fail, data, RJesCode.Unauthorized, message) as RJesUnauthorizedObjectResult;
        }
        public static RJesForbiddenObjectResult Forbidden(object data, string message)
        {
            return FactoryCreate(RJesStatus.fail, data, RJesCode.Forbidden, message) as RJesForbiddenObjectResult;
        }
        public static RJesNotFoundObjectResult NotFound(object data, string message)
        {
            return FactoryCreate(RJesStatus.fail, data, RJesCode.NotFound, message) as RJesNotFoundObjectResult;
        }
        //5XX -> error
        public static RJesInternalServerErrorObjectResult InternalServerError(object data, string message)
        {
            return FactoryCreate(RJesStatus.error, data, RJesCode.InternalServerError, message) as RJesInternalServerErrorObjectResult;
        }
        public static RJesNotImplementedObjectResult NotImplemented(object data, string message)
        {
            return FactoryCreate(RJesStatus.error, data, RJesCode.NotImplemented, message) as RJesNotImplementedObjectResult;
        }
    }
}
