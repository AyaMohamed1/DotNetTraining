using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab1
{
    public class Exam : ICloneable, IComparable {

        public int ExamId { get; set; }
        public TimeSpan Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public Subject Subject { get; set; }
        public Dictionary<Question, Answer> questionAnswers = new Dictionary<Question, Answer>();



        public virtual void ShowExam(Exam exam)
        {

        }

        public override string ToString()
        {
            return "exam id is: " + ExamId;
        }

        public Exam Clone() { return new Exam(); }
        // ICloneable implementation
        object ICloneable.Clone()
        {
            return Clone();
        }

        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType())) {
                return false;
            }
            else {
                Exam p = (Exam)obj;
                return (ExamId == p.ExamId);
            }
        }

        public override int GetHashCode() {
            return ExamId;
        }

        public int CompareTo(object incomingobject) {
            Exam incomingexam = incomingobject as Exam;

            return this.ExamId.CompareTo(incomingexam.ExamId);
        }



    }
}
