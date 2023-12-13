using System;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of Address
        Address address1 = new Address("123 Main St", "Cityville", "CA", "USA");
        Address address2 = new Address("456 Park Ave", "Townsville", "NY", "USA");
        Address address3 = new Address("789 Beach Rd", "Seaside", "FL", "USA");

        // Create instances of different events
        Lecture lecture = new Lecture("Tech Talk", "Exciting technology discussion", new DateTime(2023, 1, 15), new TimeSpan(18, 30, 0), address1, "John Doe", 50);
        Reception reception = new Reception("Networking Event", "Socialize and connect", new DateTime(2023, 2, 20), new TimeSpan(19, 0, 0), address2, "rsvp@example.com");
        OutdoorGathering gathering = new OutdoorGathering("Summer Picnic", "Enjoy outdoor activities", new DateTime(2023, 5, 1), new TimeSpan(12, 0, 0), address3, "Weather permitting");

        // Display marketing messages for each event
        Console.WriteLine("Marketing Messages for Lecture:\n");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(lecture.GetShortDescription());

        Console.WriteLine("\n------------------------\n");

        Console.WriteLine("Marketing Messages for Reception:\n");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(reception.GetShortDescription());

        Console.WriteLine("\n------------------------\n");

        Console.WriteLine("Marketing Messages for Outdoor Gathering:\n");
        Console.WriteLine(gathering.GetStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(gathering.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(gathering.GetShortDescription());
    }
}