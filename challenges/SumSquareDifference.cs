using System;

namespace ProjectEulerCSharp.challenges
{
    public class SumSquareDifference
    {
        public static string solve() {
            int num = 100;
            int difference = Math.Abs(SumOfSquares(num) - SquareOfSum(num));

            return difference.ToString();
        }

        public static int SumOfSquares(int num) {
            int sum = 0;
            for (var i = 1; i < num + 1; i++) {
                sum += i*i;
            }
            return sum;
        }

        public static int SquareOfSum(int num) {
            int sum = 0;
            for (var i = 1; i < num + 1; i++) {
                sum += i;
            }
            return sum*sum;
        }

        public static string info() {
            return "URL: https://projecteuler.net/problem=6";
        }
    }
}