using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Quic;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class FinalExam : Exam
    {
        int limit;
        public FinalExam(int time, int numOfQuestion) :base(time,numOfQuestion)
        {

        }
        public override void CreateListQuestion()
        {
            questions = new Question[NumOfQuestion];
            for(int i=0; i<NumOfQuestion;i++)
            {
                int choice;
                do
                {
                    Console.WriteLine("enter choice 1 for mcq  and 2 for true and false");
                } while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 2);
                if(choice==1)
                {
                    questions[i] = new MCQQuestion();
                    questions[i].AddQuestion();
                    limit = 3;
                }
                else
                {
                    questions[i] = new TFQuestion();
                    questions[i].AddQuestion();
                    limit = 2;
                }
            }

        }

        public override void ShowExam()
        {
//show allquestion
//take user answer
//show result
foreach(var qt in questions)
            {
                Console.WriteLine(qt);
                for(int i=0; i<qt.AllAnswers.Length;i++)
                {
                    Console.WriteLine(qt.AllAnswers[i]);
                }
                Console.WriteLine("_________________________________");
                int user ;
                do
                {
                    Console.WriteLine("enter your result");
                } while (!int.TryParse(Console.ReadLine(), out user) || user < 1 || user > limit);
                qt.UserAnswer.AnswerId = user;
                qt.UserAnswer.AnswerText = qt.AllAnswers[user - 1].AnswerText;

            }
            Console.Clear();
            int totalmark = 0;
            int mark = 0;
            for(int i=0; i<questions.Length;i++)
            {
                totalmark += questions[i].Mark;
                if (questions[i].UserAnswer.AnswerId== questions[i].RightAnswer.AnswerId)
                {
                    mark += questions[i].Mark;
                }
                Console.WriteLine($" qustion{i + 1}  {questions[i].Body}");
                Console.WriteLine($"user answer {questions[i].UserAnswer.AnswerText}");
            }
            Console.WriteLine($"your grade is {mark}  from {totalmark}");


        }
    }
}
