using System;
using System.Collections.Generic;
using System.Linq;

namespace Net.Coffee.Domain
{
    public class Money
    {
        public Money(
            decimal amount,
            Currency currency)
        {
            Currency = currency ?? throw new ArgumentNullException(nameof(currency), $"{nameof(currency)} is null.");
            this.Amount = Math.Round(amount, 2, MidpointRounding.ToEven);
        }
        public static Money FromEuro(decimal amount)
        {
            return new Money(amount, CurrencyRepository.Get("EUR"));
        }
        public static Money FromEuro(string amount)
        {
            if (string.IsNullOrEmpty(amount))
                throw new ArgumentException($"{nameof(amount)} is null or empty.", nameof(amount));


            decimal value;
            if (!decimal.TryParse(amount, out value))
                throw new InvalidOperationException($"Value:{amount} is not valid input for {nameof(Money)}.");

            return FromEuro(value);
        }
        public static Money FromCurrencyCode(string code)
        {
            return new Money(0M, CurrencyRepository.Get(code));
        }
        public static void AssertSameCurrency(Money left, Money right)
        {
            if (left == null || right == null)
                throw new ArgumentNullException("Money Is Null");
            if (left.Currency != right.Currency)
                throw new ArgumentException("Money Currency Not Equal");
        }
        public decimal Amount { get; }
        public Currency Currency { get; }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (!(obj is Money))
                return false;

            var other = obj as Money;

            return this.Amount.Equals(other.Amount);
        }
        public override int GetHashCode()
        {
            return -602769199 + Amount.GetHashCode();
        }
        public override string ToString()
        {
            return this.ToString("d");
        }
        public string ToString(string format)
        {
            switch (format)
            {
                case "d":
                    return this.Amount.ToString("0.00");
                case "s":
                    return $"{this.Amount.ToString($"0.00")}{this.Currency.Symbol}";
                default:
                    throw new FormatException($"Format: {format} not supported");
            }
        }
        public static bool operator ==(Money left, Money right)
        {
            AssertSameCurrency(left, right);
            return Equals(left, right);
        }
        public static bool operator !=(Money left, Money right)
        {
            AssertSameCurrency(left, right);
            return !(left == right);
        }
        public static Money operator +(Money left, Money right)
        {
            AssertSameCurrency(left, right);
            decimal result = left.Amount + right.Amount;
            return new Money(result, left.Currency);
        }
        public static Money operator -(Money left, Money right)
        {
            AssertSameCurrency(left, right);
            decimal result = left.Amount - right.Amount;
            return new Money(result, left.Currency);
        }
        public static Money operator *(Money left, Money right)
        {
            AssertSameCurrency(left, right);
            decimal result = left.Amount * right.Amount;
            return new Money(result, left.Currency);
        }
        public static Money operator /(Money left, Money right)
        {
            AssertSameCurrency(left, right);
            decimal result = left.Amount / right.Amount;
            return new Money(result, left.Currency);
        }
        public static Money operator %(Money left, Money right)
        {
            AssertSameCurrency(left, right);
            decimal result = left.Amount % right.Amount;
            return new Money(result, left.Currency);
        }
        public static Money operator ++(Money value)
        {
            decimal result = value.Amount;
            result++;
            return new Money(result, value.Currency);
        }
        public static Money operator --(Money value)
        {
            decimal result = value.Amount;
            result--;
            return new Money(result, value.Currency);
        }

        public static implicit operator string(Money value) => value.ToString();
    }
}