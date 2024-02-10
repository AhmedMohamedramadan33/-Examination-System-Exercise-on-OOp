using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public class MCQQuestion : Question
    {
        public override string Header => $" MCQ Question ";

      

        public MCQQuestion()
        {
            AllAnswers = new Answer[3];
        }
        public override void AddQuestion()
        {
            Console.WriteLine($" {Header} ");
            Console.WriteLine(" Enter Body Of Question");
            Body = Console.ReadLine();
            int mark;
            do
            {
                Console.WriteLine("Enter mark");
            } while (!int.TryParse(Console.ReadLine(),out mark));
                Mark = mark;
            for(int i=0; i<3; i++)
            {
                AllAnswers[i] = new Answer()
                {
                    AnswerId = i + 1,

                };
                Console.WriteLine($"Enter  chice {i + 1}");
                AllAnswers[i].AnswerText = Console.ReadLine();
            }
            int right ;
            do
            {
                Console.WriteLine("enter id of right answer");
            }while(!int.TryParse(Console.ReadLine(), out right)||right<1||right>3);

            RightAnswer.AnswerId = right;
            RightAnswer.AnswerText = AllAnswers[right - 1].AnswerText;
            Console.Clear();
        }
    }
}
