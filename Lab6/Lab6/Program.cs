using System;

namespace Lab6
{
    class Program
    {
        private static void KeyListener()
        {
            while (true)
            {
                var key = Console.ReadKey().Key;
                if (key == ConsoleKey.Q || key == ConsoleKey.F10)
                {
                    Environment.Exit(0);
                }
                if (key == ConsoleKey.Enter)
                {
                    break;
                }
            }
        }

        static void Main(string[] args)
        {

            Human[] massif = { new Botan("Artem"), new Student("Sego"), new Girl("Xenia"),
                new PrettyGirl("Rita"), new SmartGirl("Irina")};
            for (int i = 0; i < 6; i++)
            {
                var first = massif[UniqueRandom.Instance.Next(massif.Length)];
                var second = massif[UniqueRandom.Instance.Next(massif.Length)];
                var couple = CoupleMethods.Couple(first, second);
                Console.WriteLine($"First is {first.GetType().Name} {first.Name}   Second is {second.GetType().Name} {second.Name} " + couple.GetType().Name);
                try
                {

                    Console.WriteLine("Output is " + couple.Name + "   " + couple.GetType().Name);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Program.KeyListener();
            }
        }
    }
}
