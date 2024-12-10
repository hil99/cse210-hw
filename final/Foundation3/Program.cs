using System;

class Program
{
    static void Main()
    {
        // Create addresses
        Address lectureAddress = new Address("123 Learning Lane", "Techville", "CA", "90210");
        Address receptionAddress = new Address("456 Celebration Street", "Partytown", "NY", "12345");
        Address outdoorAddress = new Address("789 Park Avenue", "Greenfield", "OR", "97123");

        // Create events
        Lecture lecture = new Lecture(
            "Machine Learning Fundamentals", 
            "An introduction to machine learning concepts", 
            "2024-07-15", 
            "14:00", 
            lectureAddress, 
            "Dr. Emily Chen", 
            100
        );

        Reception reception = new Reception(
            "Tech Innovators Networking", 
            "Annual networking event for tech professionals", 
            "2024-08-20", 
            "18:30", 
            receptionAddress, 
            "rsvp@techinnovators.com"
        );

        OutdoorGathering outdoorGathering = new OutdoorGathering(
            "Summer Tech Picnic", 
            "Casual outdoor gathering for tech enthusiasts", 
            "2024-09-05", 
            "12:00", 
            outdoorAddress, 
            "Sunny with light breeze, 75°F"
        );

        // Display event details
        Console.WriteLine("Lecture Standard Details:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine("\nLecture Full Details:");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine("\nLecture Short Description:");
        Console.WriteLine(lecture.GetShortDescription());

        Console.WriteLine("\n---\n");

        Console.WriteLine("Reception Standard Details:");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine("\nReception Full Details:");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine("\nReception Short Description:");
        Console.WriteLine(reception.GetShortDescription());

        Console.WriteLine("\n---\n");

        Console.WriteLine("Outdoor Gathering Standard Details:");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine("\nOutdoor Gathering Full Details:");
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine("\nOutdoor Gathering Short Description:");
        Console.WriteLine(outdoorGathering.GetShortDescription());
    }
}