using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS1
{

    public class Library
    {
        public List<Book> Books { get; set; }
        public List<AbstractPerson> Members { get; set; }

        public Library()
        {
            Books = new List<Book>();
            Members = new List<AbstractPerson>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void AddMember(AbstractPerson member)
        {
            Members.Add(member);
        }

        public Book FindBookById(int id)
        {
            foreach (var book in Books)
            {
                if (book.Id == id)
                    return book;
            }
            return null;
        }

        public AbstractPerson FindMemberById(int id)
        {
            foreach (var member in Members)
            {
                if (member.Id == id)
                    return member;
            }
            return null;
        }

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
