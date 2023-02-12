using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class ChooseAllQuestion : Question {
        public string QuestionType { get;}
        public ChooseAllQuestion() {
            QuestionType = "ChooseAll";
            
        }
        public ChooseAllQuestion(string QuestionId, string Body, string Marks, string Header,
            string QuestionType, AnswersList Answers)
        {
            this.QuestionId = QuestionId;
            this.Body = Body;
            this.Marks = Marks;
            this.Header = Header;
            this.QuestionType = QuestionType;
            this.Answers = Answers;
        }
    }
}
