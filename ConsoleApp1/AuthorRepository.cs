using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AuthorRepository : IRepository<Author>

    {
        private Model1 _authorContext;

        public AuthorRepository()
        {
            _authorContext = new Model1();
        }

        public IEnumerable<Author> List => new List<Author> {
            {new Author{ Id=1, authorName="ayman"} },
            {new Author{ Id=2, authorName="momo"} }
        };

         public Author FindById(int Id)
        {
            return List.Where(x => x.Id == Id).FirstOrDefault();
        }


    }
}
