using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
   public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Subject(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Exam subjectexam { get; set; }
        public void createexam()
        {
            int numofqt, time, type;
            do
            {
                Console.WriteLine("enter 1for practical and 2 for final");
            } while (!int.TryParse(Console.ReadLine(), out type) || type < 1 || type > 2);
            do
            {
                Console.WriteLine("enter time");
            } while (!int.TryParse(Console.ReadLine(), out time));
            do
            {
                Console.WriteLine("enter  num of questions");
            } while (!int.TryParse(Console.ReadLine(), out numofqt) );
            if(type==1)
            {
                subjectexam = new Practicalexam(time,numofqt);
            }
            else
            {
                subjectexam = new FinalExam(time, numofqt);
            }
            subjectexam.CreateListQuestion();
            Console.Clear();
        }
    }
}
