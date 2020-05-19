using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    class Book: Name
    {
        public string Name { get; }

        public Book(string name)
        {
            Name = name;
        }
    }
}
