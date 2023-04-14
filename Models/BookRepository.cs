using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT22_Lektion_CustomGenericsInterface.Models
{
    internal class BookRepository : IBookStoreRepository<Book>
    {
        List<Book> books;

        public BookRepository() 
        {
            books = new List<Book>()
            {
                new Book()
                {
                    BookId = 1,
                    Title = "C# Programing " ,
                    Discription = "C# for Beginners",
                    Author = new Author{ AuthorId = 3 , Name = "Anas"}
                },
                new Book()
                {
                    BookId = 2,
                    Title = "Java Programing " ,
                    Discription = "Java for Beginners",
                    Author = new Author{ AuthorId = 2 , Name = "Tobias"}
                },
                new Book()
                {
                    BookId = 3,
                    Title = "Python Programing " ,
                    Discription = "Python for Beginners",
                    Author = new Author{ AuthorId = 1 , Name = "Reidar"}
                },

            };
        
        
        }
        public void Add(Book entity)
        {
            entity.BookId = books.Max(b => b.BookId) + 1;
            books.Add(entity);
        }

        public void Delete(int id)
        {
            var book = Find(id);
            books.Remove(book);
        }

        public Book Find(int id)
        {
           var book =  books.FirstOrDefault(b => b.BookId == id);
            return book;
        }

        public IList<Book> GetAll()
        {
            return books;
        }

        public void Update(int id, Book updatedebook)
        {
            var book = Find(id);

            book.Title = updatedebook.Title;
            book.Discription = updatedebook.Discription;
            book.Author = updatedebook.Author;
        }
    }
}
