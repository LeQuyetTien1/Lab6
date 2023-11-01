using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapLab6._3
{
    internal class Lecture
    {
        public string Name {  get; set; }
        public double Salary {  get; set; }
        public double Bonus {  get; set; }
        public override string ToString()
        {
            return "Name: " + Name + ", Salary: " + Salary + ", Bonus: " + Bonus;
        }
    }
}
