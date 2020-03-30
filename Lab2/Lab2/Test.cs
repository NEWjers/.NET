using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Test
    {
        private string SubjectName;
        private bool Result;

        public Test(string subjectname, bool result)
        {
            SubjectName = subjectname;
            Result = result;
        }

        public Test()
        {
            SubjectName = "Empty";
            Result = false;
        }

        public override string ToString()
        {
            return SubjectName + " " + Result.ToString();
        }
    }
}
