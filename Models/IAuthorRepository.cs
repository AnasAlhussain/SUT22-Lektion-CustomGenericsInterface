using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT22_Lektion_CustomGenericsInterface.Models
{
    internal interface IAuthorRepository
    {
        
        IList<Author> GetAllAuthors();
        List<Author> Search(string term);
    }
}
