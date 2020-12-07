using System;
using System.Runtime.Serialization;

namespace Lab6_CSharp
{
    internal class InvalidCoupleArguments : Exception
    {

        public InvalidCoupleArguments(string message) : base(message)
        {
        }

    }
}