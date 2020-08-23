using System;

namespace psv.SFP.ApiSpecification
{
    public static class RJesExceptionHandler
    {
        public static RJesObjectResult Handle(Exception exception)
        {
            RJesObjectResult rjesObjectResult = null;
            switch (exception)
            {
                case RJesErrorException error:
                    rjesObjectResult = RJesObjectResultFactory.FactoryCreate(RJesStatus.error, exception.StackTrace, (RJesCode)error.RJesErrorCode, error.Message);
                    break;
                case RJesFailException fail:
                    rjesObjectResult = RJesObjectResultFactory.FactoryCreate(RJesStatus.fail, exception.StackTrace, (RJesCode)fail.RJesFailCode, fail.Message);
                    break;
                case NotImplementedException notImplementedException:
                    rjesObjectResult = RJesObjectResultFactory.NotImplemented(exception.StackTrace, notImplementedException.Message);
                    break;
                case Exception ex:
                    rjesObjectResult = RJesObjectResultFactory.InternalServerError(exception.StackTrace, ex.Message);
                    break;
            }

            return rjesObjectResult;
        }
    }
}
