using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class StudentComparer : IComparer<Student>
    {
        public int Compare(Student student1, Student student2)
        {
            if (student1.AverageMark > student2.AverageMark)
            {
                return 1;
            }
            else if (student1.AverageMark < student2.AverageMark)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
