using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public class TFQuestion : Question
    {
        public override string Header => $" true false question";
        public TFQuestion()
        {
            AllAnswers = new Answer[2];
            AllAnswers[0] = new Answer(1, "true");
            AllAnswers[1] = new Answer(2, "false");

        }
        public override void AddQuestion()
        {
            Console.WriteLine(Header);
            Console.WriteLine("Enter Body Of question");
            Body = Console.ReadLine();
            int mark ;
            do
            {
                Console.WriteLine("enter mark");
            } while (!int.TryParse(Console.ReadLine(), out mark));
            Mark = mark;
            int right;
            do
            {
                Console.WriteLine("enter id of right answer");

            } while (!int.TryParse(Console.ReadLine(),out right)||right<1||right>2);
            RightAnswer.AnswerId = right;
            RightAnswer.AnswerText = AllAnswers[right - 1].AnswerText;
            Console.Clear();
        }
    }
}
