using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public abstract class Exam
    {
        public int Time { get; set; }
        public int NumOfQuestion { get; set; }
        public Question[] questions { get; set; }

        public Exam(int time, int numOfQuestion)
        {
            Time = time;
            NumOfQuestion = numOfQuestion;
        }
        public abstract void CreateListQuestion();
        public abstract void ShowExam();
    }
}
