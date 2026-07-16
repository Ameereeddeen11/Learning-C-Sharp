namespace Quiz_Game
{
    internal abstract class Program
    {
        private static void Main(string[] args)
        {
            // Questions array[]
            string[] questions =
            [
                "Which of the following is not a primitive data type in Java?",
                "Which keyword is used to create a subclass in Java?",
                "What does the acronym \"DNS\" stand for in networking?",
                "Which OSI layer is responsible for IP addressing and routing?",
                "In SQL, which command is used to remove all records from a table without removing the table structure?",
                "Which of the following is considered a \"symmetric\" encryption algorithm?",
                "Which component is often referred to as the \"brain\" of the computer?",
                "What is the primary purpose of a \"Heat Sink\" in a computer?"
            ];
            
            // Options array[,]
            string[,] options =
            {
                { "int", "boolean", "String", "double" },
                { "int", "boolean", "String", "double" },  // correct answer: String
                { "implements", "extends", "super", "inherits" },  // correct answer: extends
                {
                    "Domain Name System", 
                    "Data Network Service", 
                    "Digital Name Server", 
                    "Dynamic Network Source"
                },  // correct answer: Domain Name System
                {
                    "Data Link Layer", 
                    "Transport Layer", 
                    "Network Layer", 
                    "Session Layer"
                },  // correct answer: Network Layer
                { "DELETE", "DROP", "REMOVE", "TRUNCATE" },  // correct answer: TRUNCATE
                { "RSA", "AES", "ECC", "Diffie-Hellman" },  // correct answer: AES
                { "GPU", "RAM", "CPU", "Motherboard" },  // correct answer: CPU
                {
                    "To increase clock speed", 
                    "To store temporary data", 
                    "To dissipate heat from components", 
                    "To regulate voltage"
                }  // correct answer: To dissipate heat from components
            };

            // Answers array[]
            int[] correctAnswers = { 3, 2, 1, 3, 4, 2, 3, 3 };
            
            // Score and guess variable 
            int score = 0;
            int guess;
            
            // Welcome message
            Console.WriteLine("**************************************");
            Console.WriteLine("Welcome to my Quiz Game written in C#!");
            Console.WriteLine("**************************************");
            
            // Loop through questions
            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);

                for (int j = 0; j < options.GetLength(1); j++)
                {
                    Console.WriteLine($"{j + 1}. {options[i, j]}");
                }
                
                // Get user input
                Console.Write($"Enter your answer (1-{options.GetLength(1)}): ");
                guess = Convert.ToInt32(Console.ReadLine());

                if (
                    guess < 1 || 
                    guess > options.GetLength(1)
                    )
                {
                    Console.WriteLine("Invalid input! Please enter a number between 1 and {options.GetLength(1)}.");
                    i--; // Retry the same question
                    continue;
                }
                
                // Check if the answer is correct 
                Console.WriteLine("**************************************");
                if (guess == correctAnswers[i])
                {
                    Console.WriteLine("Correct!");
                    Console.WriteLine("**************************************");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Wrong! The correct answer is {correctAnswers[i]}");
                    Console.WriteLine("**************************************");
                }
            }
            
            // Display final score 
            Console.WriteLine("**************************************");
            Console.WriteLine($"Your final score is: {score}/{questions.Length}");
            Console.WriteLine("**************************************");
        }
    }
}

