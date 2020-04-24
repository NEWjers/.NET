using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class StudentCollection
    {
        private List<Student> Students;

        public void AddDefaults(Student student)
        {
            Students = new List<Student>();
            Students.Add(student);
        }

        public void AddStudents(Student[] students)
        {
            Students = new List<Student>(students.Length);
            Students.AddRange(students);
        }

        public override string ToString()
        {
            string result = "";
            for(int i = 0; i < Students.Count; i++)
            {
                result += Students[i].ToString() + "|";
            }
            return result;
        }

        public string ToShortString()
        {
            string result = "";
            for (int i = 0; i < Students.Count; i++)
            {
                result += Students[i].ToShortString() + Students[i].Testss.Count + " " + Students[i].Examss + " " + "|";
            }
            return result;
        }

        public void SurnameSort()
        {
            Student[] students = Students.ToArray();
            Array.Sort(students);
            Students.Clear();
            Students.AddRange(students);
        }

        public void BirthDateSirt()
        {
            Students.Sort(new Person());
        }

        public void AverageMarkSort()
        {
            Students.Sort(new StudentComparer());
        }

        public double MaxAverageMark
        {
            get{
                if(Students.Count == 0)
                {
                    return 0;
                }
                else
                {
                    return Students.Max(n=> n.AverageMark);
                }
            }
        }

        public IEnumerable<Student> Master
        {
            get
            {
                return Students.Where(n => n.GetDegree() == Education.Master);
            }
        }

        public List<Student> AverageMarkGroup(double value)
        {
            var list = Students.Where(n => n.AverageMark == value).GroupBy(n => n.GetDegree());
            List<Student> students = new List<Student>();
            foreach(var n in list)
            {
                students.Add((Student)n);
            }
            return students;
        }
    }
}    
