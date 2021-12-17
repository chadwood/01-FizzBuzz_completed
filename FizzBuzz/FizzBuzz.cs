using System;

namespace Katas
{
    public class FizzBuzz
    {
        private const int MinInputValue = 1;
        private const int MaxInputValue = 100;

        private const string FizzName = "Fizz";
        private const int FizzDivisor = 3;

        private const string BuzzName = "Buzz";
        private const int BuzzDivisor = 5;

        static void Main(string[] args) {

		}

        public string Process(int inputValue) {
            ValidateInputValue(inputValue);
            var _retVal = $"{PrintFizz(inputValue)}{PrintBuzz(inputValue)}";
            return string.IsNullOrEmpty(_retVal) ? inputValue.ToString() : _retVal;
        }

        private void ValidateInputValue(int inputValue) {
            if (!IsBetweenMinMaxValue(inputValue)) {
                throw new ArgumentOutOfRangeException($"Only integers {MinInputValue} through {MaxInputValue} are allowed.");
            }
        }

        private bool IsBetweenMinMaxValue(int inputValue) {
            return inputValue >= MinInputValue && inputValue <= MaxInputValue;
        }

        private string PrintFizz(int inputValue) {
            return Modulo(inputValue, FizzDivisor) ? FizzName : string.Empty;
        }

        private string PrintBuzz(int inputValue) {
            return Modulo(inputValue, BuzzDivisor) ? BuzzName : string.Empty;
        }

        private bool Modulo(int dividend, int divisor) {
            return dividend % divisor == 0;
        }

    }
}
