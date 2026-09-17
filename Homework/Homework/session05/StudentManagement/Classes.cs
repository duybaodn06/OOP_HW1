using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.session05.StudentManagement
{
    internal class Classes
    {
        public string ClassId { get; set; }
        public string ClassName { get; set; }

        public List<Student> Students { get; set; } = new List<Student>();

        /// <summary>
        /// Constructor independent of the list of students
        /// </summary>
        public Classes(string classId, string className)
        {
            ClassId = classId;
            ClassName = className;

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

        public List<Student> GetStudents()
        {
            return Students;
        }


    }
}
