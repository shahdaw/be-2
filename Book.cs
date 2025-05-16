

using System;

namespace LMS1
{

    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public bool IsAvailable { get; set; }

        public Book(int id, string title, string authorName)
        {
            Id = id;
            Title = title;
            AuthorName = authorName;
            IsAvailable = true;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Book ID: {Id}, Title: \"{Title}\", Author: {AuthorName}, Available: {IsAvailable}");
        }
    }

}

