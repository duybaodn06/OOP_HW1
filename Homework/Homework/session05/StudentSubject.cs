using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Homework.session05
{
    internal class StudentSubject
    {
        private string StudentId;
        private string SubjectId;
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
                    this._score = value;
                }
            }
        }

        public StudentSubject(string studentId, string subjectId, float score)
        {
            this.StudentId = studentId;
            this.SubjectId = subjectId;
            this.Score = score;
        }
        //public bool UpdateScore(float score)
        //{
        //    this.Score = score;
        //}
    }

}
