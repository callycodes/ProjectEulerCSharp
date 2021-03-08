using System;
using ProjectEulerCSharp.challenges;

namespace ProjectEulerCSharp
{
    public class Challenges
    {
        public enum ChallengesDirectory{
            MultiplesOfThreeAndFive,
            EvenFibonacciNumbers,
            LargestPrimeFactor,
            LargestPalindromeProduct
        }

        public static Array getChallenges() {
            return Enum.GetValues(typeof(ChallengesDirectory));
        }

        public static void complete(int challenge) {
            Aesthetics.divider();
            Console.WriteLine("Information:");

            switch (challenge) {
                case 0:
                    Console.WriteLine(MultiplesOfThreeAndFive.info());
                    Aesthetics.divider();
                    Console.WriteLine("Answer:");
                    Console.WriteLine(MultiplesOfThreeAndFive.solve());
                break;
                case 1:
                    Console.WriteLine(EvenFibonacciNumbers.info());
                    Aesthetics.divider();
                    Console.WriteLine("Answer:");
                    Console.WriteLine(EvenFibonacciNumbers.solve());
                break;
                case 2:
                    Console.WriteLine(LargestPrimeFactor.info());
                    Aesthetics.divider();
                    Console.WriteLine("Answer:");
                    Console.WriteLine(LargestPrimeFactor.solve());
                break;
                case 3:
                    Console.WriteLine(LargestPalindromeProduct.info());
                    Aesthetics.divider();
                    Console.WriteLine("Answer:");
                    Console.WriteLine(LargestPalindromeProduct.solve());
                break;
            }

            Aesthetics.divider();


        }
    }
}