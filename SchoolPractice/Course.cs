using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    public class Course
    {
        public string Topic { get; set; }
        public Teacher Instructor { get; set; }
        public List<Student> enrolledStudents { get; set; }

        public override string ToString()
        {
            return Topic + " (Topic: " + Instructor + ", Instructor: " + enrolledStudents + ")";
        }

        public override bool Equals(object coursesCompared)
        {

            if (coursesCompared == this)
            {
                return true;
            }

            if (coursesCompared == null)
            {
                return false;
            }

            if (coursesCompared.GetType() != this.GetType())
            {
                return false;
            }

            Topic t = coursesCompared as Topic;
            return t.enrolledStudents == enrolledStudents;
        }
    }
}
