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

        public IEnumerable<Author> List => throw new NotImplementedException();

        public void Add(Author entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Author entity)
        {
            throw new NotImplementedException();
        }

        public Author FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Author entity)
        {
            throw new NotImplementedException();
        }
    }
}
