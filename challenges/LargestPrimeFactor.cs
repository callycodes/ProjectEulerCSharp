using System;
using System.Linq;
using System.Collections.Generic;

namespace ProjectEulerCSharp.challenges
{
    public class LargestPrimeFactor
    {
        public static string solve() {
            long num = 600851475143;
            List<int> factors = new List<int>();
            while (num % 2 == 0) {
                num /= 2;
            }

            for (int i = 3; i <= Math.Sqrt(num); i += 2) {
                while (num % i == 0) {
                    factors.Add(i);
                    num /= i;
                }
            }

            if (num > 2) {
                factors.Add((int)num);
            }
            
            return factors.Max().ToString();
        }

        public static string info() {
            return "The prime factors of 13195 are 5, 7, 13 and 29. What is the largest prime factor of the number 600851475143 ?";
        }
    }
}