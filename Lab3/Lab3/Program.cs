using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentCollection collection = new StudentCollection();

            Person person1 = new Person("Serhiy", "Pityk", new DateTime(2000, 3, 27));
            Person person2 = new Person("Artem", "Shtefanesa", new DateTime(1999, 2, 10));
            Person person3 = new Person("Ksenia", "Dolgan", new DateTime(1999, 12, 26));
            Person person4 = new Person("Margarita", "Boiko", new DateTime(2000, 3, 23));
            Person person5 = new Person("Irina", "Zhizhiyan", new DateTime(2000, 5, 25));

            Student student1 = new Student(person1, Education.Bachelor, 302);
            Student student2 = new Student(person2, Education.Bachelor, 302);
            Student student3 = new Student(person3, Education.Bachelor, 302);
            Student student4 = new Student(person4, Education.Bachelor, 302);
            Student student5 = new Student(person5, Education.Bachelor, 302);

            student1.Testss = new System.Collections.Generic.List<Test>
            {
                new Test("Math", true),
                new Test("History", true),
                new Test("Philosophy", true)
            };

            student2.Testss = new System.Collections.Generic.List<Test>
            {
                new Test("Math", true),
                new Test("History", true),
                new Test("Philosophy", true)
            };

            student3.Testss = new System.Collections.Generic.List<Test>
            {
                new Test("Math", true),
                new Test("History", true),
                new Test("Philosophy", true)
            };

            student4.Testss = new System.Collections.Generic.List<Test>
            {
                new Test("Math", true),
                new Test("History", true),
                new Test("Philosophy", true)
            };

            student5.Testss = new System.Collections.Generic.List<Test>
            {
                new Test("Math", true),
                new Test("History", true),
                new Test("Philosophy", true)
            };

            student1.Examss = new System.Collections.Generic.List<Exam>
            {
                new Exam("Programming", 85, new DateTime(2020, 4, 20)),
                new Exam("Structures", 70, new DateTime(2020, 4, 15)),
                new Exam("Methods", 80, new DateTime(2020, 4, 10))
            };

            student1.Examss = new System.Collections.Generic.List<Exam>
            {
                new Exam("Programming", 80, new DateTime(2020, 4, 20)),
                new Exam("Structures", 70, new DateTime(2020, 4, 15)),
                new Exam("Methods", 70, new DateTime(2020, 4, 10))
            };

            student1.Examss = new System.Collections.Generic.List<Exam>
            {
                new Exam("Programming", 70, new DateTime(2020, 4, 20)),
                new Exam("Structures", 70, new DateTime(2020, 4, 15)),
                new Exam("Methods", 75, new DateTime(2020, 4, 10))
            };

            student1.Examss = new System.Collections.Generic.List<Exam>
            {
                new Exam("Programming", 75, new DateTime(2020, 4, 20)),
                new Exam("Structures", 75, new DateTime(2020, 4, 15)),
                new Exam("Methods", 70, new DateTime(2020, 4, 10))
            };

            student1.Examss = new System.Collections.Generic.List<Exam>
            {
                new Exam("Programming", 100, new DateTime(2020, 4, 20)),
                new Exam("Structures", 100, new DateTime(2020, 4, 15)),
                new Exam("Methods", 100, new DateTime(2020, 4, 10))
            };

            Student[] students = new Student[5];
            students[0] = student1;
            students[1] = student2;
            students[2] = student3;
            students[3] = student4;
            students[4] = student5;

            collection.AddStudents(students);

            Console.WriteLine(collection.ToString());
            Console.WriteLine();

            collection.SurnameSort();
            Console.WriteLine(collection.ToString());
            Console.WriteLine();

            collection.BirthDateSirt();
            Console.WriteLine(collection.ToString());
            Console.WriteLine();

            collection.AverageMarkSort();
            Console.WriteLine(collection.ToString());
            Console.WriteLine();

            Console.WriteLine(collection.MaxAverageMark);

            Console.WriteLine(collection.Master.Cast<object>().ToList().ToString());

            Console.WriteLine(collection.AverageMarkGroup(80).ToString());

            List<Person> people = new List<Person>() {
                person1,
                person2,
                person3,
                person4,
                person5
            };

            List<string> vs = new List<string>()
            {
                "Serhiy",
                "Artem",
                "Ksenia",
                "Margarita",
                "Irina"
            };

            Dictionary<Person, Student> pairs = new Dictionary<Person, Student>();
            pairs.Add(person1, student1);
            pairs.Add(person2, student2);
            pairs.Add(person3, student3);
            pairs.Add(person4, student4);
            pairs.Add(person5, student5);

            Dictionary<string, Student> pairs1 = new Dictionary<string, Student>();
            pairs1.Add("Serhiy", student1);
            pairs1.Add("Artem", student2);
            pairs1.Add("Ksenia", student3);
            pairs1.Add("Margarita", student4);
            pairs1.Add("Irina", student5);

            TestCollections test = new TestCollections(people, vs, pairs, pairs1);

            test.CheckTimePersonList(0);
            Console.WriteLine();
            test.CheckTimePersonList(2);
            Console.WriteLine();
            test.CheckTimePersonList(4);
            Console.WriteLine();
            test.CheckTimePersonList(7);
            Console.WriteLine();

            test.CheckTimeStringList(0);
            Console.WriteLine();
            test.CheckTimeStringList(2);
            Console.WriteLine();
            test.CheckTimeStringList(4);
            Console.WriteLine();
            test.CheckTimeStringList(7);
            Console.WriteLine();

            test.CheckTimeDictionaryPersonKey(person1);
            Console.WriteLine();
            test.CheckTimeDictionaryPersonKey(person3);
            Console.WriteLine();
            test.CheckTimeDictionaryPersonKey(person5);
            Console.WriteLine();

            test.CheckTimeDictionaryPersonValue(student1);
            Console.WriteLine();
            test.CheckTimeDictionaryPersonValue(student3);
            Console.WriteLine();
            test.CheckTimeDictionaryPersonValue(student5);
            Console.WriteLine();

            test.CheckTimeDictionaryStringKey("Serhiy");
            Console.WriteLine();
            test.CheckTimeDictionaryStringKey("Ksenia");
            Console.WriteLine();
            test.CheckTimeDictionaryStringKey("Irina");
            Console.WriteLine();

            test.CheckTimeDictionaryStringValue(student1);
            Console.WriteLine();
            test.CheckTimeDictionaryStringValue(student3);
            Console.WriteLine();
            test.CheckTimeDictionaryStringValue(student5);
            Console.WriteLine();
        }
    }
}
