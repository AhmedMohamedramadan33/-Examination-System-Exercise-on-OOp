using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public abstract class Question
    {
        public abstract string Header { get; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answer[] AllAnswers { get; set; }
        public Answer RightAnswer { get; set; }
        public Answer UserAnswer { get; set; }
        public Question()
        {
            RightAnswer= new Answer();  
            UserAnswer = new Answer();  
        }
        public abstract void AddQuestion();
        public override string ToString()
        {
            return $" Header   {Header}    Mark {Mark}   \n    {Body}  ";
        }
    }
}
