using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class PractiseExam: Exam {
        public string ExamType = "practise exam";
        public override void ShowExam(Exam exam)
        {
            Console.WriteLine("this is practise exam");
        }
    }
}
