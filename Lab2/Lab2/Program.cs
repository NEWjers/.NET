using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Serhiy", "Pityk", new DateTime(2000, 3, 27));
            Person person2 = new Person("Serhiy", "Pityk", new DateTime(2000, 3, 27));
            if (person1.Equals(person2))
            {
                Console.WriteLine("Objects are equals");
            }
            else
            {
                Console.WriteLine("Oblects are not equals");
            }
            Console.WriteLine(person1.GetHashCode());
            Console.WriteLine(person2.GetHashCode());


            Student student = new Student(person1, Education.Bachelor, 312);
            System.Collections.ArrayList tests = new System.Collections.ArrayList();
            tests.Add(new Test("Math", true));
            tests.Add(new Test("English", true));
            tests.Add(new Test("Programming", true));
            student.Testss = tests;
            System.Collections.ArrayList exams = new System.Collections.ArrayList();
            exams.Add(new Exam("NETCore", 90, new DateTime(2020, 4, 13)));
            exams.Add(new Exam("JavaCore", 95, new DateTime(2020, 4, 10)));
            exams.Add(new Exam("PHP", 70, new DateTime(2020, 4, 5)));
            student.Examss = exams;
            Console.WriteLine(student.ToString());


            Console.WriteLine(student.Info.GetName());
            Console.WriteLine(student.Info.GetSurname());
            Console.WriteLine(student.Info.GetBirthDate().ToString());

            Student studentCopy = (Student)student.DeepCopy();
            student.SetName("Artem");
            student.SetSurname("Shtefanesa");
            student.SetBirthDate(new DateTime(1999, 2, 10));
            if(student == studentCopy)
            {
                Console.WriteLine("Something went wrong");
            }
            else
            {
                Console.WriteLine("Objects arent equals");
            }


            try
            {
                student.GroupNumberr = 50;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            foreach(Exam exam in student.GetEnumeratorMoreThan(80))
            {
                Console.WriteLine(exam.Mark);
            }
        }
    }
}
