

namespace SchoolPractice
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId,
            int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
        : this(name, studentId, 0, 0) { }

        public Student(string name)
        : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        //AddGrade method.
        public void AddGrade(int courseCredits, double grade)
        {
            // Update the appropriate properties: NumberOfCredits, Gpa
            NumberOfCredits = courseCredits++;
            Gpa = grade * courseCredits / NumberOfCredits;
        }

        //GetGradeLevel method here:
        public static string GetGradeLevel(int credits)
        {
            
            if (credits <= 29)
            {
                return "Freshman";
            }
            else if (credits <= 59 && credits >= 30)
            {
                return "Sophomore";
            }
            else if (credits <= 60 && credits >= 89)
            {
                return "Junior";
            }
            else if (credits >= 90)
            {
                return "Senior";
            }
            else
            {
                return "Not a valid input";
            }

        }

        public override string ToString()
        {
            return Name + " (Credits: " + NumberOfCredits + ", GPA: " + Gpa + ")";
        }
        public override boolean Equals(object toBeCompared)
        {

            if (toBeCompared == this)
            {
                return true;
            }

            if (toBeCompared == null)
            {
                return false;
            }

            if (toBeCompared.GetType() != this.GetType())
            {
                return false;
            }

            Student s = toBeCompared as Student;
            return s.StudentId == StudentId;
        }

        

    }
}
