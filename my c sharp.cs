using System;

class Program
{
    static void Main()
    {
      // text of the start
      Console.WriteLine("Welcome programmer")
      
      // Prompt the user to enter something
        Console.WriteLine("Enter your name pls:");
        
        // Read the user input and store it in a variable
        string userInput = Console.ReadLine();
        
        // Display what the user entered
       Console.WriteLine("oh hi " + userInput);
       
      
      Console.WriteLine("wanna exit?");
        
        bool exit = false;

        while (!exit) {
            // Display options
            Console.WriteLine("1. no");
            Console.WriteLine("2. exit")

            // Get user input
            string choice = Console.ReadLine();

            // Process user input
            switch (choice)
            {
                case "1":
                    Console.WriteLine("ok");
                    
                    Console.Write.Line("but i can't stay that long i have other stuff to do like update, so bye");
                    return;

                case "2":
                    Console.WriteLine("ok then exit, goodbye!");
                    exit = true;
                    return;
            }
        }
}
