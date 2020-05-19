using System;

namespace Lab6
{
    class CoupleMethods
    {
        private static bool DoYouLikeHim(double prob)
        {
            int random = UniqueRandom.Instance.Next(100);
            return random < prob * 100;
        }

        private static CoupleAttribute GetAttribute(Human first, Human second)
        {
            foreach(CoupleAttribute attr in first)
            {
                if(attr.Pair == second.GetType().Name)
                {
                    return attr;
                }
            }

            throw new System.Exception("Error. Wrong couple.");
        }

        public static Name Couple(Human first, Human second)
        {
            CoupleAttribute firstAttr = GetAttribute(first, second);
            CoupleAttribute secondAttr = GetAttribute(second, first);

            bool firstLike = DoYouLikeHim(firstAttr.Probability);
            bool secondLike = DoYouLikeHim(secondAttr.Probability);
            string name = "Default";

            if(firstLike && secondLike)
            {
                var method = first.GetType().GetMethods()[1];
                name = (string)method.Invoke(first, null);
            }
            else
            {
                throw new System.Exception("There is no love.");
            }

            Type type = Type.GetType("Lab6." + firstAttr.ChildType, true);
            object obj = Activator.CreateInstance(type, name);

            return (Name)obj;
        }
    }
}
