using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class AuthorRepositoryTests
    {
        [TestMethod()]
        public void FindByIdTest()
        {
            var a = 1;
            var b = 1;
            var c = 2;
            Assert.AreEqual(a, b);
        }
    }
}