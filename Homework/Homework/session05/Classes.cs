using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.session05
{
    internal class Classes
    {
        public string ClassId { get; set; }
        public string ClassName { get; set; }

        public List<Student> Students;

        /// <summary>
        /// Constructor independent of the list of students
        /// </summary>
        public Classes(string classId, string className, List<Student> students)
        {
            ClassId = classId;
            ClassName = className;
            Students = students;
        }
        /// <summary>
        /// Constructor dependent of the list of students
        /// </summary>
        //public Classes(string classId, string className)
        //{
        //    ClassId = classId;
        //    ClassName = className;
        //    Students = new List<Student>();
        //}


    }
}
