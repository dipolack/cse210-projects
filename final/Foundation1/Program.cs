using System;
using System.Collections.Generic;

class Program
   
    {
        static void Main(string[] args)
        {
            List<Video> _videos = new List<Video>();

            Video v1 = new Video("C# Learning about Abstraction", "James Bond", 300);
            v1.Comments.Add(new Comment("Leah", "Wonderful Concepts!"));
            v1.Comments.Add(new Comment("Martha", "Insightful content!"));
            v1.Comments.Add(new Comment("Carl", "I learned a lot about Abstraction, thank you!"));
            _videos.Add(v1);

            Video v2 = new Video("C# Learning about Inheritance", "John Wick", 450);
            v2.Comments.Add(new Comment("Maria", "I will make sure to share this info!"));
            v2.Comments.Add(new Comment("Cristopher", "Very detailed and informative!"));
            _videos.Add(v2);

            Video v3 = new Video("C# Learning about Polymorphism", "Rocky Valvoa", 200);
            v3.Comments.Add(new Comment("Leon", "I loved learning the difference between Inheritance and Polymorphism!"));
            _videos.Add(v3);

            foreach (Video v in _videos)
            {
                Console.WriteLine("Title: " + v.Title);
                Console.WriteLine("Author: " + v.Author);
                Console.WriteLine("Length: " + v.Length + " seconds");
                Console.WriteLine("Number of comments: " + v.GetNumComments());
                Console.WriteLine("Comments:");

                foreach (Comment c in v.Comments)
                {
                    Console.WriteLine("- " + c.Name + ": " + c.Text);
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }