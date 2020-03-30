using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Lab2
{

    enum Education
    {
        Master,
        Bachelor,
        SecondEducation
    }

    class Student: Person, IDateAndCopy
    {
        private Education Degree;
        private int GroupNumber;
        private ArrayList Offset;
        private ArrayList Exams;

        public Student(Education degree, int groupnumber, ArrayList results, ArrayList exams)
        {
            Degree = degree;
            GroupNumber = groupnumber;
            Offset = results;
            Exams = exams;
        }

        public Student()
        {
            Degree = Education.Bachelor;
            GroupNumber = -1;
            Offset = new ArrayList();
            Exams = new ArrayList();
        }

        public Person Info
        {
            get
            {
                return Info;
            }
            set
            {
                Info = value;
            }
        }

        public double AverageMark
        {
            get
            {
                double sum = 0;
                foreach(Exam exam in Exams)
                {
                    sum += exam.Mark;
                }
                return sum / Exams.Count;
            }
        }

        public ArrayList Examss
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

        public void AddExams(Exam[] exams)
        {
            for (int i = 0; i < exams.Length; i++)
            {
                Exams.Add(exams[i]);
            }
        }

        public override string ToString()
        {
            string result = Info.ToString() + ";" + Degree.ToString() + ";" + GroupNumber + ";";
            for (int i = 0; i < Offset.Count; i++) 
            {
                result += Offset[i].ToString() + ";";
            }
            for (int i = 0; i < Exams.Count; i++)
            {
                result += Exams[i].ToString() + ";";
            }
            return result;
        }

        public virtual string ToShortString()
        {
            return Info.ToString() + ";" + Degree.ToString() + ";" + GroupNumber + ";" + AverageMark;
        }

        public object DeepCopy()
        {
            return new Student { Degree = this.Degree, GroupNumber = this.GroupNumber, Offset = this.Offset, Exams = this.Exams, Info = (Person)this.Info.DeepCopy() };
        }

        public DateTime Date
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

        public int groupNumber
        {
            get
            {
                return GroupNumber;
            }
            set
            {
                if ((value <= 100) || (value > 699)) {
                    throw new ArgumentOutOfRangeException("GroupNumber","Group number must belong [100;699]");
                }
                else
                {
                    GroupNumber = value;
                }
            }
        }

        public IEnumerator GetUnionEnumerator()
        {
            var result = Exams;
            result.AddRange(Offset);
            for (int i = 0; i<result.Count; i++) 
            {
                yield return result[i];
            }
        }

        public IEnumerator GetHigherThenEnumerator(int mark)
        {
            for(int i = 0; i < Exams.Count; i++)
            {
                Exam exam = (Exam)Exams[i];
                if( exam.Mark > mark)
                {
                    yield return exam;
                }
            }
        }


    }
}
