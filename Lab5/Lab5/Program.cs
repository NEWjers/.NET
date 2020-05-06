using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(new Person("Srhiy", "Pityk", new DateTime(2000, 3, 27)), Education.Bachelor, 312);
            student.Examss.Add(new Exam("Algebra", 80, new DateTime(2020, 5, 6)));

            Student studentCopy = student.DeepCopy();

            Console.WriteLine(student.ToString());
            Console.WriteLine(studentCopy.ToString());

            Student student1 = new Student(new Person("Artem", "Shtefanesa", new DateTime(1999, 2, 10)), Education.Bachelor, 312);
            student1.Examss.Add(new Exam("Algebra", 75, new DateTime(2020, 5, 6)));

            Console.Write("Input file name: ");
            string filename = Console.ReadLine();
            student1.Save(filename);

            Student studentLoad = new Student();
            studentLoad.Load(filename);

            Console.WriteLine(studentLoad.ToString());

            studentLoad.AddFromConsole();
            studentLoad.Save(filename);

            Console.WriteLine(studentLoad.ToString());
        }
    }
}
