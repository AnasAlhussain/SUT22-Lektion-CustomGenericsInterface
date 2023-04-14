using SUT22_Lektion_CustomGenericsInterface.Models;

namespace SUT22_Lektion_CustomGenericsInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookRepository bookRepo = new BookRepository();

            foreach (Book item in bookRepo.GetAll())
            {
                Console.WriteLine("Book ID = {0} \n " +
                    "Title : {1} \t Discription : {2} \t Author Name :{3}",
                    item.BookId,item.Title,
                    item.Discription,item.Author.Name);
            }

            Console.WriteLine("********************************************");
            AuthorRepository authorRepo = new AuthorRepository();
            foreach (Author item in authorRepo.GetAll())
            {
                Console.WriteLine("Author ID = {0} \n Author Name = {1} ", 
                    item.AuthorId,item.Name);
            }

            Console.ReadKey();
        }
    }
}