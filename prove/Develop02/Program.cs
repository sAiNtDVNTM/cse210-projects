using System;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the journal program!! (❛ ‿ ❛)/ ");// The menu on the program this is where the program start
        Console.WriteLine("Please select one of the following choices. ");
        while (true)
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? 1-5"); // User need to enter the options 
            string choice = Console.ReadLine();

            switch (choice) 
            {
                case "1":
                    string prompt = PromptGenerator.GenerateRandomPrompt(); //Gnereted the prompt of today 
                    Console.Write("Please Enter Today's date(mm/dd/yyyy): "); //Date enter by user 
                    string dateToday = Console.ReadLine();
                    Console.WriteLine($"Today's Prompt: {prompt}");
                    string content = Console.ReadLine();

                    Entry entry = new Entry(dateToday, prompt, content);
                    Journal.userAddEntry(entry);//This is when the function save the user entry so we can not lost it 
                    break;

                case "2":
                    Journal.DisplayUserEntries();
                    break; // This can display the entries that is a the moment that we start the program and also the files 

                case "3":
                    Console.Write("Please enter the name file that you would like to load: ");
                    string fileLoad = Console.ReadLine() + ".txt";
                    Journal.LoadFromFile(fileLoad); //This gives us the option to load the file from an existing file 
                    break;

                case "4":
                    Console.WriteLine("Plese enter the file name to save your entries: ");
                    string fileSave = Console.ReadLine() + ".txt";
                    Journal.SaveToAFile(fileSave); // You can choose the name of your new file and save it in a txt 
                    break;

                case "5":
                    Console.WriteLine("Thank you for your reply. Good bye! ( ◕ ‿‿ ◕ )");
                    return;// End the program 

                default:
                    Console.WriteLine("Invalid Option!  ( > ‿‿ < )");
                    break; // in case they entered a wrong number 
            }
        }
    }
}