using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{

    [Serializable]
    class Exam
    {
        public string Name;
        public int Mark;
        public DateTime Date;

        public Exam(string name, int mark, DateTime date)
        {
            Name = name;
            Mark = mark;
            Date = date;
        }

        public Exam()
        {
            Name = "Empty";
            Mark = -1;
            Date = new DateTime(2000, 1, 1);
        }

        public override string ToString()
        {
            return Name + ";" + Mark.ToString() + ";" + Date.ToString() + "|";
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public int GetMark()
        {
            return Mark;
        }

        public void SetMark(int mark)
        {
            Mark = mark;
        }

        public DateTime GetDate()
        {
            return Date;
        }

        public void SetDate(DateTime date)
        {
            Date = date;
        }
    }
}
