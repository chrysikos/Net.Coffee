using Microsoft.AspNetCore.Mvc;

namespace psv.SFP.ApiSpecification
{
    public class RJesController : ControllerBase
    {
        [ApiExplorerSettings(IgnoreApi = true)]
        public RJesOkObjectResult RJesOK(object data, string message)
        {
            return RJesObjectResultFactory.OK(data, message);
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public RJesCreatedObjectResult RJesCreated(object data, string message)
        {
            return RJesObjectResultFactory.Created(data, message);
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public RJesAcceptedObjectResult RJesAccepted(object data, string message)
        {
            return RJesObjectResultFactory.Accepted(data, message);
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public RJesNoContentObjectResult RJesNoContent(string message)
        {
            return RJesObjectResultFactory.NoContent(null, message);
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public RJesBadRequestObjectResult RJesBadRequest(object data, string message)
        {
            return RJesObjectResultFactory.BadRequest(data, message);
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public RJesUnauthorizedObjectResult RJesUnauthorized(object data, string message)
        {
            return RJesObjectResultFactory.Unauthorized(data, message);
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public RJesForbiddenObjectResult RJesForbidden(object data, string message)
        {
            return RJesObjectResultFactory.Forbidden(data, message);
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public RJesNotFoundObjectResult RJesNotFound(object data, string message)
        {
            return RJesObjectResultFactory.NotFound(data, message);
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public RJesInternalServerErrorObjectResult RJesInternalServerError(object data, string message)
        {
            return RJesObjectResultFactory.InternalServerError(data, message);
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public RJesNotImplementedObjectResult RJesNotImplemented(object data, string message)
        {
            return RJesObjectResultFactory.NotImplemented(data, message);
        }
    }
}