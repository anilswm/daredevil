using System.Collections.Generic;
using System.Linq;

namespace IOSdk.Base
{
    public static class Utility
    {
        public static bool IsNotNullOrEmpty<T>(this IEnumerable<T> value)
        {
            return value != null && value.Any();
        }

        public static bool IsNotNullOrEmptyOrWhiteSpace(this string Value)
        {
            return !Value.IsNullOrEmptyOrWhiteSpace();
        }
        public static bool IsNullOrEmptyOrWhiteSpace(this string Value)
        {
            return string.IsNullOrWhiteSpace(Value) || Value.Length == 0;
        }
    }
}