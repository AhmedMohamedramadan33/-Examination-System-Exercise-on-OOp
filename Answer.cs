using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
   public class Answer
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }

        public Answer(int answerId, string answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }

        public Answer()
        {
        }
        public override string ToString()
        {
            return $"Id {AnswerId}   AnswerText  {AnswerText} ";
        }
    }
}
