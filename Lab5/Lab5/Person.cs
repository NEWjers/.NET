using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{

    [Serializable]
    class Person
    {
        protected string Name;
        protected string Surname;
        protected DateTime BirthDate;

        public Person(string name, string surname, DateTime birthdate)
        {
            Name = name;
            Surname = surname;
            BirthDate = birthdate;
        }

        public Person()
        {
            Name = "Empty";
            Surname = "Empty";
            BirthDate = new DateTime(2000, 1, 1);
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetSurname(string surname)
        {
            Surname = surname;
        }

        public string GetSurname()
        {
            return Surname;
        }

        public void SetBirthDate(DateTime birthdate)
        {
            BirthDate = birthdate;
        }

        public DateTime GetBirthDate()
        {
            return BirthDate;
        }

        public void SetIntBirthDate(int day, int month, int year)
        {
            BirthDate = new DateTime(year, month, day);
        }

        public int GetDay()
        {
            return BirthDate.Day;
        }

        public int GetMonth()
        {
            return BirthDate.Month;
        }

        public int GetYear()
        {
            return BirthDate.Year;
        }

        public override string ToString()
        {
            return Name + " " + Surname + " " + BirthDate.ToString();
        }

        public virtual string ToShortString()
        {
            return Name + " " + Surname;
        }

        /*public override bool Equals(object obj)
        {
            Person person = (Person)obj;
            return (Name == person.Name && Surname == person.Surname && BirthDate == person.BirthDate);
        }

        public static bool operator ==(Person person1, Person person2)
        {
            return person1.Equals(person2);
        }

        public static bool operator !=(Person person1, Person person2)
        {
            return !person1.Equals(person2);
        }*/

        public override int GetHashCode()
        {
            int hashcode = Name.GetHashCode();
            hashcode = 31 * hashcode + Surname.GetHashCode();
            hashcode = 31 * hashcode + BirthDate.GetHashCode();
            return hashcode;
        }

        public virtual DateTime Date
        {
            get
            {
                return Date;
            }
            set
            {
                Date = value;
            }
        }
    }
}
