using System;
using System.IO;

class Entry {
    public string prompt;
    public string response;
    public DateTime date;

    public Entry(string prompt, string response, DateTime date) {
        this.prompt = prompt;
        this.response = response;
        this.date = date;
    }
}

class Journal {
    public List<Entry> entries = new List<Entry>();
    public List<string> prompts = new List<string> {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is something I can do today that my future self will thank me for?",
        "What blessings have I seen today?",
        "What are 5 things that I can cherish about my friends or family today?",
        "Did you perform an act of kindness yet?",
        "Have you felt the promptings of the holy ghost today? "
    };

    public void AddEntry() {
        Random rand = new Random();
        int index = rand.Next(prompts.Count);
        string prompt = prompts[index];
        Console.WriteLine("Prompt: " + prompt);
        string response = Console.ReadLine();
        DateTime date = DateTime.Now;
        Entry newEntry = new Entry(prompt, response, date);
        entries.Add(newEntry);
        Console.WriteLine("Your entry has been added!");
    }

    public void DisplayJournal() {
        if (entries.Count == 0) {
            Console.WriteLine("No entries to display.");
        } else {
            for (int i = 0; i < entries.Count; i++) {
                Entry entry = entries[i];
                Console.WriteLine("Entry " + (i+1) + ":");
                Console.WriteLine("Prompt: " + entry.prompt);
                Console.WriteLine("Response: " + entry.response);
                Console.WriteLine("Date: " + entry.date);
                Console.WriteLine("*********");
            }
        }
    }

    public void LoadJournal(string filename) {
        if (File.Exists(filename)) {
            entries = new List<Entry>();
            string[] lines = File.ReadAllLines(filename);
            for (int i = 0; i < lines.Length; i += 3) {
                string prompt = lines[i];
                string response = lines[i+1];
                DateTime date = DateTime.Parse(lines[i+2]);
                Entry entry = new Entry(prompt, response, date);
                entries.Add(entry);
            }
            Console.WriteLine("Journal loaded from " + filename);
        } else {
            Console.WriteLine("I couldn't find that file!");
        }
    }

    public void SaveJournal(string filename) {
        List<string> lines = new List<string>();
        for (int i = 0; i < entries.Count; i++) {
            Entry entry = entries[i];
            lines.Add(entry.prompt);
            lines.Add(entry.response);
            lines.Add(entry.date.ToString());
        }
        File.WriteAllLines(filename, lines);
        Console.WriteLine("Journal saved to" + filename);
}
}

class Program {
    static void Main(string[] args) {
        Journal journal = new Journal();
        bool running = true;
        while (running) {
        Console.WriteLine("Welcome to your very own Journal Application!");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display journal");
        Console.WriteLine("3. Load a previous Journal");
        Console.WriteLine("4. Save my journal");
        Console.WriteLine("5. Exit ");
        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();

        switch (choice) {
            case "1":
                journal.AddEntry();
                break;
            case "2":
                journal.DisplayJournal();
                break;
            case "3":
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();
                journal.LoadJournal(filename);
                break;
            case "4":
                Console.Write("Enter filename: ");
                filename = Console.ReadLine();
                journal.SaveJournal(filename);
                break;
            case "5":
                running = false;
                break;
            default:
                Console.WriteLine("Please pick between 1-5 only, try again!");
                break;
        }
    }
}
}

//I found some tutorials on classes to be very helpful during this assignment.
//One of them suggested this website: https://learn.microsoft.com/en-us/dotnet/api/system.io.file?view=net-5.0
//https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic?view=net-7.0
//Which is now my go to when learning because it Explains the available tools and gives a lot of resources
//that I personally consider very valuable for this class.
//The tutorial that helped me understand better this topic was this one:
//https://www.youtube.com/watch?v=t2SPg6IuT3k&t=362s