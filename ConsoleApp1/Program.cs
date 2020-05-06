using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // the implementation based on the following link
    //https://medium.com/falafel-software/implement-step-by-step-generic-repository-pattern-in-c-3422b6da43fd
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            IRepository<Author> _authorRepository = new AuthorRepository();
            var result = _authorRepository.FindById(1);
            Console.Write(result.authorName);
            Console.ReadLine();




        }
    }
}
