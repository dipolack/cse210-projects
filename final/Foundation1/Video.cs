using System;
using System.Collections.Generic;

public class Video

    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Length { get; set; }
        public List<Comment> Comments { get; set; }

        public Video(string _title, string _author, int _length)
        {
            Title = _title;
            Author = _author;
            Length = _length;
            Comments = new List<Comment>();
        }

        public int GetNumComments()
        {
            return Comments.Count;
        }
    }