using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_CSharp
{
    public class Book : IHasName
    {

        public Book()
        {
            Name = "Book";
        }

        public Book(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
