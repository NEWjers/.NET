using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    abstract class Human: Name
    {
        public string Name { get; }

        public Human(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public IEnumerator GetEnumerator()
        {
            Type t = this.GetType();
            object[] attrs = t.GetCustomAttributes(false);
            foreach(CoupleAttribute coupleAttribute in attrs)
            {
                yield return coupleAttribute;
            }
        }
    }
}
