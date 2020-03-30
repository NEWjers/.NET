using System;
using System.Collections;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Serhiy", "Pityk", new DateTime(2000, 3, 27));
            Person person2 = new Person("Serhiy", "Pityk", new DateTime(2000, 3, 27));
            if (person1.Equals(person2))
                Console.WriteLine("Elements are equals");
            else
                Console.WriteLine("Elements are not equals");
            Console.WriteLine(person1.GetHashCode());
            Console.WriteLine(person2.GetHashCode());
            ArrayList offset = new ArrayList();
            ArrayList exam = new ArrayList();
            offset.Add(new Test("English",true));
            exam.Add(new Exam("Math", 90, new DateTime(2020, 3, 26)));
            Student student = new Student(Education.Bachelor, 302, offset, exam);
            student.Info = new Person("Serhiy", "Pityk", new DateTime(2000, 3, 27));
            Console.WriteLine(student.ToString());
        }
    }
}
