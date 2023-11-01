using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Student
    {
        public int id {  get; set; }
        public string name { get; set; }
        public double theorymark {  get; set; }
        public double labmark {  get; set; }
   
        public override string ToString()
        {
            return "Id: " + id + ", name: " + name + ", theory mark: " + theorymark + ", lab mark: " + labmark;
        }
    }
    public class InvalidMarkException: Exception
    {
        public InvalidMarkException() : base("Diem phai nam trong khoang 0-10") { }
    }
}
