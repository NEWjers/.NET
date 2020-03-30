using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{

    enum Education
    {
        Master,
        Bachelor,
        SecondEducation
    }
    class Student
    {

        private Person Info;
        private Education Degree;
        private int GroupNumber;
        private Exam[] Exams;

        public Student(Person info, Education degree, int groupnumber, int examsnumber)
        {
            Info = info;
            Degree = degree;
            GroupNumber = groupnumber;
            Exams = new Exam[examsnumber];
            for(int i = 0; i < Exams.Length; i++)
            {
                Exams[i] = new Exam();
            }
        }

        public Student()
        {
            GroupNumber = -1;
            Exams = new Exam[1];
            Exams[0] = new Exam();
        }

        public Person GetInfo()
        {
            return Info;
        }

        public void SetInfo(Person info) {
            Info = info;
        }

        public Education GetDegree()
        {
            return Degree;
        }

        public void SetDegree(Education degree)
        {
            Degree = degree;
        }

        public int GetGroupNumber()
        {
            return GroupNumber;
        }

        public void SetGroupNumber(int groupnumber)
        {
            GroupNumber = groupnumber;
        }

        public Exam[] GetExams()
        {
            return Exams;
        }

        public void SetExam(Exam[] exams)
        {
            Exams = exams;
        }

        public double AverageMark()
        {
            double res = 0;
            for(int i = 0; i < Exams.Length; i++)
            {
                res += Exams[i].GetMark();
            }
            return res / Exams.Length;
        }

        public bool this[Education index]
        {
            get
            {
                return index == Degree;
            }
        }

        public void AddExams(Exam[] exams)
        {
            for(int i = 0; i < exams.Length; i++)
            {
                Array.Resize(ref Exams, Exams.Length + 1);
                Exams[Exams.Length - 1] = exams[i];
            }
        }

        public override string ToString()
        {
            string result = Info.ToString() + ";" + Degree.ToString() + ";" + GroupNumber + ";";
            for(int i = 0; i < Exams.Length; i++)
            {
                result += Exams[i].ToString() + ";";
            }
            return result; 
        }

        public virtual string ToShortString()
        {
            return Info.ToString() + ";" + Degree.ToString() + ";" + GroupNumber + ";" + AverageMark();
        }

    }
}
