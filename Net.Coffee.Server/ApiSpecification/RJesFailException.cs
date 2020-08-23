using System;

namespace psv.SFP.ApiSpecification
{
    [Serializable]
    public class RJesFailException : Exception
    {

        public RJesFailCode RJesFailCode { get; private set; }
        public RJesFailException() { }
        public RJesFailException(string message, RJesFailCode rJesFailCode) : this(message, null, rJesFailCode) { }
        public RJesFailException(string message, Exception inner, RJesFailCode rJesFailCode) : base(message, inner)
        {
            RJesFailCode = rJesFailCode;
        }
    }
}
