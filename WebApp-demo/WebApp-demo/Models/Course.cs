using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_demo.Models
{
    public class Course
    {
        public Course()
        {

        }
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int MaxNum { get; set; }
        public int Credit { get; set; }
    }


}
