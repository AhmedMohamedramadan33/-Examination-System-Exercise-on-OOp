using System.Diagnostics;

namespace Examination_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject sub = new Subject(1, "c#");
            sub.createexam();
            Console.WriteLine("do you want to start exam enter Y/N");
            char res = char.Parse(Console.ReadLine());
            if(res=='y'||res=='Y')
            {
                Stopwatch m = new();
                m.Start();
                sub.subjectexam.ShowExam();
                Console.WriteLine(m.Elapsed);
            }
            else
            {
                Console.WriteLine("thank you");
            }

        }
    }
}
