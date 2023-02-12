using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

namespace lab1
{
    public class QuestionList : List<Question> {
        public string QuestionListId { get; set; } 
        public QuestionList(string QuestionListId) { 
            this.QuestionListId = QuestionListId;
        }
        public QuestionList() { }

        void appendText(Question question, string location)
        {
            using (TextWriter textWriter = new StreamWriter(location, true))
            {
                textWriter.WriteLine($"Question id: {question.QuestionId}");
                textWriter.WriteLine($"Question header: {question.Header}");
                textWriter.WriteLine($"Question body: {question.Body}");
                textWriter.WriteLine($"Question marks: {question.Marks} marks");
                textWriter.WriteLine("--Answers are--");
                foreach (Answer ans in question.Answers) {
                    textWriter.WriteLine($"Answer: {ans}");
                }
                textWriter.WriteLine("**********************************************");

            }
        }
        public void Add(Question item){
            string location = "";
            base.Add(item);
            location = $@"D:\Fast track\Dot Net\c#\lab1\lab1\questionsFiles\{QuestionListId}.txt";
            appendText(item, location);


        }
    }
}
