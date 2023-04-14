using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT22_Lektion_CustomGenericsInterface.Models
{
    internal class AuthorRepository : IBookStoreRepository<Author>
    {
        IList<Author> authors;
        public AuthorRepository()
        {
            authors = new List<Author>()
            {
                new Author { AuthorId = 1 , Name = "Reidar"},
                new Author { AuthorId = 2 , Name = "Tobias"},
                new Author { AuthorId = 3 , Name = "Anas"},
            };
        }
        public void Add(Author entity)
        {
            entity.AuthorId = authors.Max(a => a.AuthorId) + 1;
            authors.Add(entity);
        }

        public void Delete(int id)
        {
            var author = Find(id);
            authors.Remove(author);
        }

        public Author Find(int id)
        {
            var author = authors.FirstOrDefault(a => a.AuthorId == id);
            return author;
        }

        public IList<Author> GetAll()
        {
            return authors;
        }

        public void Update(int id, Author newAuthor)
        {
            var author = Find(id);
            author.Name = newAuthor.Name;
        }
    }
}
