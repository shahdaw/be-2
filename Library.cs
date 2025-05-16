using System;
using System.Collections.Generic;
using System.Linq;

namespace LMS1
{

    public class Library
    {
        public List<Book> Books { get; set; } = new List<Book>();
        public List<AbstractPerson> Members { get; set; } = new List<AbstractPerson>();

        public void AddBook(Book book) => Books.Add(book);
        public void AddMember(AbstractPerson member) => Members.Add(member);

        public Book FindBookById(int id) => Books.FirstOrDefault(b => b.Id == id);
        public AbstractPerson FindMemberById(int id) => Members.FirstOrDefault(m => m.Id == id);

        public void DisplayAllBooks()
        {
            Console.WriteLine("\nAll Books:");
            foreach (var book in Books)
                book.DisplayInfo();
        }

        public void DisplayAllMembers()
        {
            Console.WriteLine("\nAll Members:");
            foreach (var member in Members)
                member.DisplayInfo();
        }
    }

}

