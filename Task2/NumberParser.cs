using System;

namespace Task2
{
    public class NumberParser : INumberParser
    {
        public int Parse(string stringValue)
        {
            if (stringValue == null)
                throw new ArgumentNullException(nameof(stringValue), "Input cannot be null.");

            if (string.IsNullOrWhiteSpace(stringValue))
                throw new FormatException("Input cannot be empty or whitespace.");

            stringValue = stringValue.Trim();
            double result = 0;
            bool isNegative = false;
            int startIndex = 0;

            if (stringValue[0] == '-')
            {
                isNegative = true;
                startIndex = 1;
            }
            else if (stringValue[0] == '+')
            {
                startIndex = 1;
            }

            for (int i = startIndex; i < stringValue.Length; i++)
            {
                if (stringValue[i] < '0' || stringValue[i] > '9')
                    throw new FormatException("Input is not a valid integer.");

                result = result * 10 + (stringValue[i] - '0');

            }

            if (isNegative)
            {
                result = -result;
            }

            if (result > int.MaxValue || result < int.MinValue)
                throw new OverflowException("The number is out of the range for an Int32.");

            return (int)result;
        }
    }
}