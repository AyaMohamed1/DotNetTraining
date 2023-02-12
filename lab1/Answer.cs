using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Answer {
        //choose
        public bool A { get; set; }
        public bool B { get; set; }
        public bool C { get; set; }
        public bool D { get; set; }

        public override string ToString()
        {
            string ans = "";
            if (A == true)
                ans = "A";
            else if (B == true)
                ans = "B";
            else if (C == true)
                ans = "C";
            else if (D == true)
                ans = "D";
            return ans;
        }
    }
}
