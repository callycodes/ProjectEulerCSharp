using System;

namespace ProjectEulerCSharp
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Project Euler - Archive");
            Console.WriteLine("By Callum Bass");
            Aesthetics.divider();

            for (var challengeIndex = 0; challengeIndex < Challenges.getChallenges().Length; challengeIndex++) {
                Console.WriteLine($"{challengeIndex}. {(Challenges.ChallengesDirectory)challengeIndex}");
            }
            
            var userInput = "";

            while (userInput != "END") {
                Console.Write("Select an Option or END: ");
                userInput = Console.ReadLine();
                
                try {
                    Challenges.complete(int.Parse(userInput));
                    
                } catch (Exception e) {
                    Console.WriteLine("Please try again");
                }
            }
            
        }
    }
}
