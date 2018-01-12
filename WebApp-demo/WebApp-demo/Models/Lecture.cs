using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_demo.Models
{
    public class Lecture
    {
        public Lecture()
        {

        }
        public int LectureId { get; set; }
        public string LectureName { get; set; }
        public int Payroll { get; set; }
        public string MsgFromStudent { get; set; }
    }
}
