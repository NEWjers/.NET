using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class StudentListHandlerEventArgs: System.EventArgs
    {
        public string CollectionName { get; set; }
        public string ChangeType { get; set; }
        public Student ChangeObject { get; set; }

        public StudentListHandlerEventArgs()
        {
            CollectionName = "Unknown";
            ChangeType = "Unknown";
            ChangeObject = new Student();
        }

        public StudentListHandlerEventArgs(string collectionName, string changeType, Student changeObject)
        {
            CollectionName = collectionName;
            ChangeType = changeType;
            ChangeObject = changeObject;
        }

        public override string ToString()
        {
            return CollectionName + ";" + ChangeType + ";" + ChangeObject.ToString() + ";" + "|";
        }
    }
}
