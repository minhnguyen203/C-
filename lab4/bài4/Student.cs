using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.bài4
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public double MathScore { get; set; }
        public double PhysicsScore { get; set; }
        public double ChemistryScore { get; set; }
        public double GPA { get; set; }
        public string AcademicLevel { get; set; }

        public void CalculateGPA()
        {
            GPA = (MathScore + PhysicsScore + ChemistryScore) / 3;
            if (GPA >= 8)
            {
                AcademicLevel = "Excellent";
            }
            else if (GPA >= 6.5)
            {
                AcademicLevel = "Good";
            }
            else if (GPA >= 5)
            {
                AcademicLevel = "Average";
            }
            else
            {
                AcademicLevel = "Weak";
            }
        }
    }
}

