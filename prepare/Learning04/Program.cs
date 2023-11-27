using System;

class Program
{
    static void Main(string[] args)
    {
        Assigment a1 = new Assigment("Joseph Oliva", "Programming");
        Console.WriteLine (a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Elaine Sofia", "Fractions", "8.5", "9-20");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Valentina Rabanales", "Guatemala History", "The popol vooh");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}