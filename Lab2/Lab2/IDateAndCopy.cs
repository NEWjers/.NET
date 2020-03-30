using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    interface IDateAndCopy
    {
        object DeepCopy();
        DateTime Date { get; set; }
    }
}
