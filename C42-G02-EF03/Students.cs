using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_EF03
{
    internal class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Course>Courses { get; set; }

    }
}
