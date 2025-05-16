using System;
using System.Collections.Generic;

namespace LMS1
{

    public class Member : AbstractPerson
    {
        public List<Book> BorrowedBooks { get; set; }

        public Member(int id, string name)
        {
            Id = id;
            Name = name;
            BorrowedBooks = new List<Book>();
        }

        public void BorrowBook(Book book)
        {
            if (book.IsAvailable)
            {
                BorrowedBooks.Add(book);
                book.IsAvailable = false;
                Console.WriteLine($"\"{book.Title}\" has been borrowed by {Name}.");
            }
            else
            {
                Console.WriteLine($"\"{book.Title}\" is not available.");
            }
        }

        public void ReturnBook(Book book)
        {
            if (BorrowedBooks.Contains(book))
            {
                BorrowedBooks.Remove(book);
                book.IsAvailable = true;
                Console.WriteLine($"\"{book.Title}\" has been returned by {Name}.");
            }
            else
            {
                Console.WriteLine($"{Name} did not borrow \"{book.Title}\".");
            }
        }

        public void DisplayBorrowedBooks()
        {
            Console.WriteLine($"{Name}'s Borrowed Books:");
            if (BorrowedBooks.Count == 0)
            {
                Console.WriteLine("None");
                return;
            }

            foreach (var book in BorrowedBooks)
                book.DisplayInfo();
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Member ID: {Id}, Name: {Name}");
        }
    }

}



