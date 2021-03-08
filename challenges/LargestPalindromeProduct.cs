using System.Linq;

namespace ProjectEulerCSharp.challenges
{
    public class LargestPalindromeProduct
    {
        public static string solve() {
            int largest = 0;

            for (var one = 100; one < 1000; one++) {
                for (var two = 100; two < 1000; two++) {
                    int sum = one * two;
                    int reversed = int.Parse(new string(sum.ToString().Reverse().ToArray()));
                    if (reversed == sum && reversed > largest) {
                        largest = reversed;
                    }
                }
            }

            return largest.ToString();
        }

        public static string info() {
            return "A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99. Find the largest palindrome made from the product of two 3-digit numbers.";
        }
    }
}