using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_EF03
{
    internal class StudentCourse
    {
        //public int StudentsId { get; set; }
        //public int CoursesId { get; set; }
        public Students Students { get; set; }
        public Course Course { get; set; }
        public double Grade { get; set; }
    }
}
