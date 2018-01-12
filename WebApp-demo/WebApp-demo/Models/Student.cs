using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_demo.Models
{
    public class Student
    {
        public Student ()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public float StudentFee { get; set; }
        public int CreditLmtd { get; set; }
    }
}
