using System;

namespace psv.SFP.ApiSpecification
{

    [Serializable]
    public class RJesErrorException : Exception
    {
        public RJesErrorCode RJesErrorCode { get; private set; }
        public RJesErrorException(string message, RJesErrorCode rJesErrorCode) : this(message, null, rJesErrorCode)
        {

        }
        public RJesErrorException(string message, Exception inner, RJesErrorCode rJesErrorCode) : base(message, inner)
        {
            RJesErrorCode = rJesErrorCode;
        }
    }
}
