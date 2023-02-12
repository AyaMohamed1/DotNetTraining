using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Question {
        // list of ans
        public string QuestionId { get; set; }
        public string Body { get; set; }
        public string Marks { get; set; }
        public string Header { get; set; }
        public string QuestionType { get; set; }
        public AnswersList Answers { get; set; }

        public Question(string QuestionId, string Body, string Marks, string Header, 
            string QuestionType, AnswersList Answers) { 
            this.QuestionId = QuestionId;
            this.Body = Body;
            this.Marks = Marks;
            this.Header = Header;
            this.QuestionType= QuestionType;
            this.Answers = Answers;
        
        }
        public Question() { }

    }
}
