using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public class Practicalexam : Exam
    {
        public Practicalexam(int time, int numOfQuestion) : base(time, numOfQuestion)
        {

        }
        public override void CreateListQuestion()
        {
            questions = new MCQQuestion[NumOfQuestion];
            for(int i=0;i<questions.Length;i++)
            {
                questions[i] = new MCQQuestion();
                questions[i].AddQuestion();
            }
        }

        public override void ShowExam()
        {
            foreach (var qt in questions)
            {
                Console.WriteLine(qt);
                for (int i = 0; i < qt.AllAnswers.Length; i++)
                {
                    Console.WriteLine(qt.AllAnswers[i]);
                }
                Console.WriteLine("_________________________________");
                int user;
                do
                {
                    Console.WriteLine("enter your result");
                } while (!int.TryParse(Console.ReadLine(), out user) || user < 1 || user > 2);
                qt.UserAnswer.AnswerId = user;
                qt.UserAnswer.AnswerText = qt.AllAnswers[user - 1].AnswerText;

            }
            Console.Clear();
            for (int i = 0; i < questions.Length; i++)
            {
                              
                Console.WriteLine($" qustion{i + 1}  {questions[i].Body}");
                Console.WriteLine($"user answer {questions[i].RightAnswer.AnswerText}");
            }
        }
    }
}
