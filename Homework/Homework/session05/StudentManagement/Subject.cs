using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.session05.StudentManagement
{
    internal class Subject
    {
        public string SubjectId { get; init ; }
        public string? SubjectName { get; private set; }
        public byte? Credit { get; private set; }

        private static List<Subject> subjects = new List<Subject>();
        public Subject(string subjectId, string subjectName, byte Credit)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
            this.Credit = Credit;
            subjects.Add(this);
        }

        public Subject(string subjectId) 
        {
            this.SubjectId = subjectId;
        }

        public override bool Equals(object? obj)
        {
            if (obj is not Subject) return false;
            return this.SubjectId.Equals(((Subject)obj).SubjectId);
        }
        
        public override int GetHashCode()
        {
            return this.SubjectId.GetHashCode();
        }
        public static List<Subject> GetSubjects()
        {
            return subjects;
        }
    }
}
