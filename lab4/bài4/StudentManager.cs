using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.bài4
{
    internal class StudentManager
    {
        private List<Student> students = new List<Student>();

        // Method to add a new student
        public void AddStudent(Student student)
        {
            students.Add(student);
            Console.WriteLine("Student added successfully.");
        }

        // Method to update student information by ID
        public void UpdateStudent(int id, Student updatedStudent)
        {
            Student student = students.FirstOrDefault(s => s.Id == id);
            if (student != null)
            {
                student.Name = updatedStudent.Name;
                student.Gender = updatedStudent.Gender;
                student.Age = updatedStudent.Age;
                student.MathScore = updatedStudent.MathScore;
                student.PhysicsScore = updatedStudent.PhysicsScore;
                student.ChemistryScore = updatedStudent.ChemistryScore;
                student.CalculateGPA();
                Console.WriteLine("Student information updated successfully.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        // Method to delete student by ID
        public void DeleteStudent(int id)
        {
            Student student = students.FirstOrDefault(s => s.Id == id);
            if (student != null)
            {
                students.Remove(student);
                Console.WriteLine("Student deleted successfully.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        // Method to search student by name
        public void SearchStudentByName(string name)
        {
            List<Student> searchResult = students.Where(s => s.Name.ToLower().Contains(name.ToLower())).ToList();
            if (searchResult.Count > 0)
            {
                DisplayStudents(searchResult);
            }
            else
            {
                Console.WriteLine("No student found with the given name.");
            }
        }

        // Method to sort students by GPA
        public void SortStudentsByGPA()
        {
            List<Student> sortedStudents = students.OrderBy(s => s.GPA).ToList();
            DisplayStudents(sortedStudents);
        }

        // Method to sort students by name
        public void SortStudentsByName()
        {
            List<Student> sortedStudents = students.OrderBy(s => s.Name).ToList();
            DisplayStudents(sortedStudents);
        }

        // Method to sort students by ID
        public void SortStudentsById()
        {
            List<Student> sortedStudents = students.OrderBy(s => s.Id).ToList();
            DisplayStudents(sortedStudents);
        }

        // Method to display student list
        public void DisplayStudents()
        {
            DisplayStudents(students);
        }

        // Method to display list of students
        private void DisplayStudents(List<Student> studentList)
        {
            Console.WriteLine("Student list:");
            foreach (Student student in studentList)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Gender: {student.Gender}, Age: {student.Age}, GPA: {student.GPA}, Academic Level: {student.AcademicLevel}");
            }
        }
    }
}

