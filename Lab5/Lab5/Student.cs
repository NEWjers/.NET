using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Lab5
{

    enum Education
    {
        Master,
        Bachelor,
        SecondEducation
    }
    
    [Serializable]
    class Student : Person
    {
        private Education Degree;
        private int GroupNumber;
        private List<Test> Tests;
        private List<Exam> Exams;

        public Student(Person info, Education degree, int groupnumber)
        {
            Name = info.GetName();
            Surname = info.GetSurname();
            BirthDate = info.GetBirthDate();
            Degree = degree;
            GroupNumber = groupnumber;
            Tests = new List<Test>();
            Exams = new List<Exam>();
        }

        public Student()
        {
            Name = "Empty";
            Surname = "Empty";
            BirthDate = new DateTime(2000, 1, 1);
            Degree = Education.Bachelor;
            GroupNumber = -1;
            Tests = new List<Test>();
            Exams = new List<Exam>();
        }

        public Person Info
        {
            get
            {
                Person person = new Person(Name, Surname, BirthDate);
                return person;
            }
            set
            {
                Name = value.GetName();
                Surname = value.GetSurname();
                BirthDate = value.GetBirthDate();
            }
        }

        public double AverageMark
        {
            get
            {
                double result = 0;
                Exam[] exams = (Exam[])Exams.ToArray();
                for (int i = 0; i < Exams.Count; i++)
                {
                    result += exams[i].GetMark();
                }
                return result / exams.Length;
            }
        }

        public List<Exam> Examss
        {
            get
            {
                return Exams;
            }
            set
            {
                Exams = value;
            }
        }

        public List<Test> Testss
        {
            get
            {
                return Tests;
            }
            set
            {
                Tests = value;
            }
        }

        public void AddExams(Exam[] exams)
        {
            for (int i = 0; i < exams.Length; i++)
            {
                Exams.Add(exams[i]);
            }
        }

        public override string ToString()
        {
            string result = Name + ";" + Surname + ";" + BirthDate.ToString() + ";" + Degree.ToString() + ";" + GroupNumber + ";";
            for (int i = 0; i < Tests.Count; i++)
            {
                result += Tests[i].ToString();
            }
            for (int i = 0; i < Exams.Count; i++)
            {
                result += Exams[i].ToString();
            }
            result += "|";
            return result;
        }

        public override string ToShortString()
        {
            return Name + " " + Surname + " " + BirthDate.ToString() + " " + Degree.ToString() + " " + GroupNumber + " " + AverageMark + " ";
        }

        public Education GetDegree()
        {
            return Degree;
        }

        public void SetDegree(Education degree)
        {
            Degree = degree;
        }

        public bool this[Education index]
        {
            get
            {
                return index == Degree;
            }
        }

        public Student DeepCopy()
        {
            if (!typeof(Student).IsSerializable)
            {
                throw new ArgumentException("The type must be serializable.", "source");
            }

            if(Object.ReferenceEquals(this, null))
            {
                return default(Student);
            }

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new MemoryStream();
            using (stream)
            {
                formatter.Serialize(stream, this);
                stream.Seek(0, SeekOrigin.Begin);
                return (Student)formatter.Deserialize(stream);
            }
        }

        public int GroupNumberr
        {
            get
            {
                return GroupNumber;
            }
            set
            {
                if (value <= 100 || value > 699)
                {
                    throw new Exception("Group number must be in (100;699]");
                }
                else
                {
                    GroupNumber = value;
                }
            }
        }

        public System.Collections.IEnumerable GetEnumeratorUnion()
        {
            System.Collections.ArrayList union = new System.Collections.ArrayList();
            for (int i = 0; i < Tests.Count; i++)
            {
                union.Add(Tests[i]);
            }
            for (int i = 0; i < Exams.Count; i++)
            {
                union.Add(Exams[i]);
            }
            for (int i = 0; i < union.Count; i++)
            {
                yield return union[i];
            }
        }

        public System.Collections.IEnumerable GetEnumeratorMoreThan(double mark)
        {
            for (int i = 0; i < Exams.Count; i++)
            {
                Exam exam = (Exam)Exams[i];
                if (exam.Mark > mark)
                {
                    yield return exam;
                }
            }
        }

        public bool Save(string filename)
        {
            if (!(File.Exists(filename)))
            {
                Console.WriteLine("File does not exist");
                Console.WriteLine("File was created");
            }

            if (!typeof(Student).IsSerializable)
            {
                return false;
            }

            if(Object.ReferenceEquals(this, null))
            {
                return false;
            }

            BinaryFormatter formatter = new BinaryFormatter();

            using(FileStream stream = new FileStream(filename, FileMode.OpenOrCreate))
            {
                try
                {
                    formatter.Serialize(stream, this);
                }
                catch
                {
                    return false;
                }
            }

            return true;
        }

        public bool Load(string filename)
        {
            if (!(File.Exists(filename)))
            {
                Console.WriteLine("File does not exist");
                Console.WriteLine("File was created");
            }

            if (!typeof(Student).IsSerializable)
            {
                return false;
            }

            if(Object.ReferenceEquals(this, null))
            {
                return false;
            }

            BinaryFormatter formatter = new BinaryFormatter();

            using(FileStream stream = new FileStream(filename, FileMode.OpenOrCreate))
            {
                try
                {
                    Student student = (Student)formatter.Deserialize(stream);
                    Name = student.Name;
                    Surname = student.Surname;
                    BirthDate = student.BirthDate;
                    Degree = student.Degree;
                    GroupNumber = student.GroupNumber;
                    Tests = student.Testss;
                    Exams = student.Examss;
                }
                catch
                {
                    return false;
                }
            }

            return true;
        }

        public bool AddFromConsole()
        {
            Console.Write("Input Exam info (Format: Math;95;27.03.2000): ");
            string info = Console.ReadLine();

            try
            {
                string[] vs = info.Split(new char[] { ';' });

                Exam exam = new Exam();
                exam.Name = vs[0];
                exam.Mark = Convert.ToInt32(vs[1]);

                string[] vs1 = vs[2].Split(new char[] { '.' });
                exam.Date = new DateTime(Convert.ToInt32(vs1[2]), Convert.ToInt32(vs1[1]), Convert.ToInt32(vs1[0]));

                Examss.Add(exam);
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
