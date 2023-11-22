using System;

class Program
{
    static void Main(string[] args)
    {
        string command = "";

        GospelLibrary.Load("scriptures.txt"); // This is the file where the scriptures are.
        Scripture scripture = GospelLibrary._scriptures[new Random().Next(0, GospelLibrary._scriptures.Count-1)];

        while(true) 
        {
            Console.Clear();// 
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            command = Console.ReadLine();
            if(command.ToLower()=="quit" || scripture.IsCompletelyHidden())
                break;
            
            scripture.HideRandomWords(15);
        }
    }

}