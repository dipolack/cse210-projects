using System;
using System.Collections.Generic;

 public class Comment

    {
        public string Name { get; set; }
        public string Text { get; set; }

        public Comment(string _name, string _text)
        {
            Name = _name;
            Text = _text;
        }
    }