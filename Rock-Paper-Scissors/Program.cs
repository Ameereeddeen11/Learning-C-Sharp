namespace Rock_Paper_Scissors
{
    internal abstract class Program
    {
        private static void Main(string[] args)
        {
            Random random = new Random();

            bool playAgain = true;
            bool result;
            string playerChoice;
            string programChoice;
            string playerResponse;
            string[] choices =
            {
                "Rock",
                "Paper",
                "Scissors"
            };
            
            // Welcome message
            Console.WriteLine("*****************************************************");
            Console.WriteLine("Welcome to my Rock Paper Scissors Game written in C#!");
            Console.WriteLine("*****************************************************");

            do
            {
                Console.WriteLine("Enter your choice (Rock, Paper, or Scissors): ");
                playerChoice = Console.ReadLine();
                
                // Validate player input
                while (
                    playerChoice.ToLower() != "rock" && 
                    playerChoice.ToLower() != "paper" && 
                    playerChoice.ToLower() != "scissors"
                    )
                {
                    Console.WriteLine("Invalid choice. Please enter Rock, Paper, or Scissors: ");
                    playerChoice = Console.ReadLine();
                }
                
                // Generate program choice
                programChoice = choices[random.Next(choices.Length)];
                Console.WriteLine($"Program chose: {programChoice}");
                Console.WriteLine($"You chose: {playerChoice}");

                // Determine the result of the game
                result = (
                    (playerChoice.ToLower().Equals("rock") && programChoice.ToLower().Equals("scissors")) ||
                    (playerChoice.ToLower().Equals("paper") && programChoice.ToLower().Equals("rock")) ||
                    (playerChoice.ToLower().Equals("scissors") && programChoice.ToLower().Equals("paper"))
                    );

                // Determine the winner
                if (playerChoice.Equals(programChoice))
                {
                    Console.WriteLine("It's a tie!");
                } 
                else if (result)
                {
                    Console.WriteLine("You win!");
                }
                else
                {
                    Console.WriteLine("You lose!");
                }
                
                Console.WriteLine("Do you want to play again? (y/n): ");
                playerResponse = Console.ReadLine();
                while (playerResponse.ToLower() != "y" && playerResponse.ToLower() != "n")
                {
                    Console.WriteLine("Invalid response. Please enter 'y' or 'n': ");
                    playerResponse = Console.ReadLine();
                }
                playAgain = playerResponse.ToLower().Equals("y");
            } while (playAgain);
            
            Console.WriteLine("Thanks for playing!");
        }
    }
}