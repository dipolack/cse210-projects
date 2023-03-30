using System;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {

        Address address1 = new Address("304 main st", "Fairview", "NJ", "07302");
        Address address2 = new Address("575 3rd st", "Bronx", "NY", "63450");
        Address address3 = new Address("302 south main st", "Lakewood", "NJ", "07502");

        Event genericEvent = new Event("Gardening Event", "Flowers in the Amazons", new DateTime(2023, 6, 1), new TimeSpan(19, 0, 0), address1);
        Lecture lecture = new Lecture("Let's talk dinosaurs", "Dinosaurs and their way of life", new DateTime(2023, 7, 1), new TimeSpan(13, 0, 0), address2, "Dr. Steven Craford", 50);
        Reception reception = new Reception("Speech therapists Anual Reception", "Anual Reception for speech therapists in the Tri-State area", new DateTime(2023, 8, 1), new TimeSpan(18, 0, 0), address3, "rsvp@therapistsunited.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("A ride in the shore", "Motorcycle riding in the ocean shore", new DateTime(2023, 9, 1), new TimeSpan(11, 0, 0), address1, "Janeth Deen");

        Console.WriteLine(genericEvent.GetStandardDetails());
        Console.WriteLine ();
        Console.WriteLine(genericEvent.GetFullDetails());
        Console.WriteLine ();
        Console.WriteLine(genericEvent.GetShortDescription());
        Console.WriteLine ();

        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine ();
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine ();
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine ();

        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine ();
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine ();
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine ();

        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine ();
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine ();
        Console.WriteLine(outdoorGathering.GetShortDescription());
        Console.WriteLine ();

    }
}