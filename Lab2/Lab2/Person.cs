using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Person : IDateAndCopy
    {
        protected string Name;
        protected string Surname;
        protected DateTime BirthDate;
        public string Names
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        public string Surnames
        {
            get
            {
                return Surname;
            }
            set
            {
                Surname = value;
            }
        }
        public DateTime Date {
            get
            {
                return BirthDate;
            }
            set
            {
                BirthDate = value;
            }
        }

        public object DeepCopy()
        {
            return new Person { Name = this.Name, Surname = this.Surname, Date = this.Date };
        }

        public Person(string name, string surname, DateTime birthdate)
        {
            Name = name;
            Surname = surname;
            Date = birthdate;
        }

        public Person()
        {
            Name = "Empty";
            Surname = "Empty";
            Date = new DateTime(2000, 1, 1);
        }

        public void SetIntBirthDate(int day, int month, int year)
        {
            Date = new DateTime(year, month, day);
        }

        public int GetDay()
        {
            return Date.Day;
        }

        public int GetMonth()
        {
            return Date.Month;
        }

        public int GetYear()
        {
            return Date.Year;
        }

        public override string ToString()
        {
            return Name + " " + Surname + " " + Date.ToString();
        }

        public virtual string ToShortString()
        {
            return Name + " " + Surname;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Person person = obj as Person;
            if (person as Person == null)
                return false;
            return person.Name == this.Name && person.Surname == this.Surname && person.BirthDate == this.BirthDate;
        }

        /*public static bool operator ==(Person person1, Person person2)
        {
            if ((person1.Name == person2.Name) && (person1.Surname == person2.Surname) && (person1.BirthDate == person2.BirthDate))
                return true;
            else
                return false;
        }*/

        /*public static bool operator !=(Person person1, Person person2)
        {
            if (person1.Name != person2.Name && person1.Surname != person2.Surname && person1.BirthDate != person2.BirthDate)
                return true;
            else
                return false;
        }*/

        public override int GetHashCode()
        {
            int hashcode = Name.GetHashCode();
            hashcode = 31 * hashcode + Surname.GetHashCode();
            hashcode = 31 * hashcode + Date.GetHashCode();
            return hashcode;
        }
    }
}
