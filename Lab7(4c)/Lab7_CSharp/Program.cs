using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab7_CSharp
{
    class Program
    {
        public class V
        {
            public FileInfo File { get; set; }
            public string SearchString { get; set; }
        }

        public static StringBuilder Answer { get; set; } = new StringBuilder();
        
        public static void GetCountRepeatsInFile(object x)
        {
            int countPerform = 0;
            int countRepeats = 0;
            V values = (V)x;
            using (StreamReader sr = values.File.OpenText())
            {
                string readLine = "";
                int length = sr.ReadToEnd().Split('\n').Length;
                sr.BaseStream.Position = 0;
                while ((readLine = sr.ReadLine()) != null)
                {
                    if (readLine.Contains(values.SearchString))
                        ++countRepeats;
                    Console.WriteLine(values.File.Name + " perform " + (++countPerform * 100) / length + " %");
                }
            }
            Answer.Append(values.File.Name + ": '" + values.SearchString + "' repeats " + countRepeats + " times\n");
            Thread.Sleep(400);
        }

        private static void Main(string[] args)
        {
            V values = new V();
            DirectoryInfo directory = new DirectoryInfo(@"D:\Test");
            FileInfo[] files = directory.GetFiles("*.txt");
            string testString = "Sleentex";

            foreach (FileInfo file in files)
            {
                values.File = file;
                values.SearchString = testString;
                Thread myThread = new Thread(new ParameterizedThreadStart(GetCountRepeatsInFile));
                myThread.Start(values);
                myThread.Join();
            }

            Console.WriteLine(Answer.ToString());
            Console.ReadKey();
        }
    }
}
