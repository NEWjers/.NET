using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4
{

    delegate void StudentListHandler(object source, StudentListHandlerEventArgs args);

    class StudentCollection
    {
        private List<Student> Students;
        public event StudentListHandler StudentCountChange;
        public event StudentListHandler StudentReferenceChange;

        public void AddDefaults(Student student)
        {
            Students = new List<Student>();
            StudentCountChange?.Invoke(this, new StudentListHandlerEventArgs(CollectionName, "Add element", student));
            Students.Add(student);
        }

        public void AddStudents(Student[] students)
        {
            Students = new List<Student>(students.Length);
            for(int i = 0; i < students.Length; i++)
            {
                StudentCountChange?.Invoke(this, new StudentListHandlerEventArgs(CollectionName, "Add element", students[i]));
            }
            Students.AddRange(students);
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < Students.Count; i++)
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
            get
            {
                if (Students.Count == 0)
                {
                    return 0;
                }
                else
                {
                    return Students.Max(n => n.AverageMark);
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
            foreach (var n in list)
            {
                students.Add((Student)n);
            }
            return students;
        }

        public string CollectionName { get; set; }

        public bool Remove(int j)
        {
            if (j >= Students.Count || j < 0) 
            {
                return false;
            }
            StudentCountChange?.Invoke(this, new StudentListHandlerEventArgs(CollectionName, "Remove element", Students[j]));
            Students.RemoveAt(j);
            return true;
        }

        public Student this[int index]
        {
            get
            {
                return Students[index];
            }
            set
            {
                Students[index] = value;
                StudentReferenceChange?.Invoke(this, new StudentListHandlerEventArgs(CollectionName, "Change element", value));
            }
        }

        


    }
}
