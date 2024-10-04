namespace Moment4
{
    public class UserInterface
    {
        private CommentAnalyzer _commentAnalyzer = new();

        // Runs loop until exit
        public void Run()
        {
            while (true) {
                DisplayMenu();      // Calls DisplayMenu method
                HandleUserInput();  // Cals HandleUserInput method
            }
        }

        // Writes out menu options
        private void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("SENITMENT ANALYSIS\n");
            Console.WriteLine("Menu\n");
            Console.WriteLine("1. Write comment");
            Console.WriteLine("X. Exit");
        }

        // Gets and validates userinput and calls analyzecomment method
        private void HandleUserInput()
        {
            int key = (int) Console.ReadKey(true).Key;

            switch (key)
            {
                case 49: // If key 1/num1 is pressed

                    string? comment; // Variable to stor comment

                    // Get comment until comment is not null or empty
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Write comment to be analyzed: ");
                        comment = Console.ReadLine()!.Trim();  // Gets user comment and trims whitespace

                    }
                    while (String.IsNullOrEmpty(comment));

                    try
                    {
                        Console.WriteLine(CommentAnalyzer.AnalyzeSentiment(comment)); // Analyzes comment and writes out result
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                    }
                    catch (Exception ex) 
                    {
                        Console.WriteLine(ex.Message); // Writes out exception
                    }

                    break;

                case 88: // If X key is pressed
                    Environment.Exit(0);
                    break;
            }

          
        }
    }
}
