using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.session05
{
    internal class Subject
    {
        public string SubjectId { get; init ; }
        public string SubjectName { get; private set; }
        public byte Credit { get; private set; }
        public Subject(string subjectId, string subjectName, byte Credit)
        {
            this.SubjectId = subjectId;
            this.SubjectName = subjectName;
            this.Credit = Credit;
        }
    }
}
