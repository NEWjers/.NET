using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Test
    {
        string SubjectName;
        bool SubjectResult;

        public string Name
        {
            get
            {
                return SubjectName;
            }
            set
            {
                SubjectName = value;
            }
        }

        public bool Result
        {
            get
            {
                return SubjectResult;
            }
            set
            {
                SubjectResult = value;
            }
        }

        public Test()
        {
            SubjectName = "Empty";
            SubjectResult = false;
        }

        public Test(string name, bool result)
        {
            SubjectName = name;
            SubjectResult = result;
        }

        public override string ToString()
        {
            return SubjectName + " " + SubjectResult.ToString() + " " ;
        }
    }
}
