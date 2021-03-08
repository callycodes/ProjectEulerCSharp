using System;

namespace ProjectEulerCSharp.challenges
{
    public class SmallestMultiple
    {
        public static string solve() {
            int maxDivisible = 20;
            int current = 0;
            int answer = 0;
            
            for (var i = 1; i < 1000000000; i++) {
                for (var x = 1; x < maxDivisible + 1; x++) {
                    if (!isDivisibleBy(i, x)) {
                        break;
                    } else {
                        current = x;
                    }
                }

                if (current == maxDivisible) {
                    answer = i;
                    return answer.ToString();
                }
            }

            return 0.ToString();
        }

        public static bool isDivisibleBy(int num, int by) {
            return (num % by == 0);
        }

        public static string info() {
            return "2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder. What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?";
        }
    }
}