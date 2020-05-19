using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]

    class CoupleAttribute: System.Attribute
    {
        public string Pair { get; set; }
        public double Probability { get; set; }
        public string ChildType { get; set; }

        public CoupleAttribute(string pair, double probability, string childType)
        {
            Pair = pair;
            Probability = probability;
            ChildType = childType;
        }

        public CoupleAttribute()
        {
        }
    }
}
