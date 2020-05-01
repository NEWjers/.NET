using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class TestCollections
    {
        private List<Person> People;
        private List<string> Strings;
        private Dictionary<Person, Student> PersonDictionary;
        private Dictionary<string, Student> StringDictionary;

        public TestCollections(int sizePeople, int sizeStrings, int sizePersonDictionary, int sizeStringDictionary)
        {
            People = new List<Person>(sizePeople);
            Strings = new List<string>(sizeStrings);
            PersonDictionary = new Dictionary<Person, Student>(sizePersonDictionary);
            StringDictionary = new Dictionary<string, Student>(sizeStringDictionary);
        }

        public TestCollections(List<Person> people, List<string> strings, Dictionary<Person, Student> personDictionary, Dictionary<string, Student> stringDictionary)
        {
            People = people;
            Strings = strings;
            PersonDictionary = personDictionary;
            StringDictionary = stringDictionary;
        }

        public Student FindPerson(int index)
        {
            int i = 0;
            foreach(var n in PersonDictionary)
            {
                if (i == index)
                {
                    return n.Value;
                }
                i++;
            }
            return new Student();
        }

        public Student FindString(int index)
        {
            int i = 0;
            foreach(var n in StringDictionary)
            {
                if (i == index)
                {
                    return n.Value;
                }
                i++;
            }
            return new Student();
        }

        public void CheckTimePersonList(int index)
        {
            Console.WriteLine("List<Person>:");
            var startTimePeople = System.Diagnostics.Stopwatch.StartNew();
            if (index < 0 || index > People.Count)
            {
                Console.WriteLine("Out of range");
            }
            else
                Console.WriteLine(People[index].ToString());
            var finishTimePeople = startTimePeople.Elapsed;
            Console.WriteLine(finishTimePeople.TotalMilliseconds);
        }

        public void CheckTimeStringList(int index)
        {
            Console.WriteLine("List<string>: ");
            var startTimeStrings = System.Diagnostics.Stopwatch.StartNew();
            if (index < 0 || index > Strings.Count)
            {   
                Console.WriteLine("Out of range");
            }
            else
                Console.WriteLine(Strings[index]);
            var finishTimeStrings = startTimeStrings.Elapsed;
            Console.WriteLine(finishTimeStrings.TotalMilliseconds);
        }

        public void CheckTimeDictionaryPersonKey(Person person)
        {
            Console.WriteLine("Dictionary<Person> Key: ");
            var startTimePersonDictionaryKey = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine(PersonDictionary[person].ToString());
            var finishTimePersonDictionaryKey = startTimePersonDictionaryKey.Elapsed;
            Console.WriteLine(finishTimePersonDictionaryKey.TotalMilliseconds);
        }

        public void CheckTimeDictionaryPersonValue(Student student)
        {
            Console.WriteLine("Dictionary<Person> Value: ");
            var startTimePersonDictionaryValue = System.Diagnostics.Stopwatch.StartNew();
            foreach (var n in PersonDictionary)
            {
                if (n.Value.Equals(student))
                {
                    Console.WriteLine(n.Key.ToString());
                }
            }
            var finishTimePersonDictionartValue = startTimePersonDictionaryValue.Elapsed;
            Console.WriteLine(finishTimePersonDictionartValue.TotalMilliseconds);
        }

        public void CheckTimeDictionaryStringKey(string key)
        {
            Console.WriteLine("Dictionary<string> Key: ");
            var startTimeStringDictionaeyKey = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine(StringDictionary[key].ToString());
            var finishTimeStringDictionaeyKey = startTimeStringDictionaeyKey.Elapsed;
            Console.WriteLine(finishTimeStringDictionaeyKey.TotalMilliseconds);
        }

        public void CheckTimeDictionaryStringValue(Student student)
        {
            Console.WriteLine("Dictionary<string> Value: ");
            var startTimeStringDictionaeyValue = System.Diagnostics.Stopwatch.StartNew();
            foreach (var n in StringDictionary)
            {
                if (n.Value.Equals(student))
                {
                    Console.WriteLine(n.Key);
                }
            }
            var finishTimeStringDictionaeyValue = startTimeStringDictionaeyValue.Elapsed;
            Console.WriteLine(finishTimeStringDictionaeyValue.TotalMilliseconds);
        }
    }
}
