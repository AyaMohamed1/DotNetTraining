using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class FinalExam:Exam {
        public string ExamType = "final exam";
        public override void ShowExam(Exam exam)
        {
            Console.WriteLine("this is final exam");
        }
    }
}
