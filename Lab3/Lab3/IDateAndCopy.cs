using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    interface IDateAndCopy
    {
        object DeepCopy();
        DateTime Date { get; set; }
    }
}
