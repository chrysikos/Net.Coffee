using System;

namespace Net.Coffee.Domain
{
    public class Currency
    {
        public Currency(
           string code,
           string name,
           string symbol)
        {
            Symbol = symbol;
            Name = name;
            Code = code;
        }

        public string Code { get; }
        public string Name { get; }
        public string Symbol { get; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (!(obj is Currency))
                return false;

            var other = obj as Currency;

            return String.Equals(this.Code, other.Code, StringComparison.Ordinal);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Code);
        }
        public override string ToString()
        {
            return Code;
        }

        public static bool operator ==(Currency left, Currency right)
        {
            return Equals(left, right);
        }
        public static bool operator !=(Currency left, Currency right)
        {
            return !(left == right);
        }
    }
}

