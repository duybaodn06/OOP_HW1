using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Homework.session05.StudentManagement
{
    internal class StudentSubject
    {
        public string StudentId { get; }
        public string SubjectId { get; }
        private float _score;
        public float Score { 
            get { return _score; } 
            private set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentOutOfRangeException("Score must be between 0 and 10.");
                }
                else 
                {
                    _score = value;
                }
            }
        }

        public StudentSubject(string studentId, string subjectId, float score)
        {
            Student temp = new Student(studentId);
            List<Subject> subjects = Subject.GetSubjects();
            Subject Stemp = new Subject(subjectId);
            if (subjects.Contains(Stemp) && score >= 0 && score <= 10)
            {
                this.StudentId = studentId;
                this.SubjectId = subjectId;
                this.Score = score;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Insert error.");
            }
        }
        public bool UpdateScore(float score)
        {
            if (score < 0 || score > 10)
            {
                return false;
            }
            this.Score = score;
            return true;
        }
    }

}
