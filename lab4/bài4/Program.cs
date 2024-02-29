using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.bài4
{
    internal class Program
    {
            static void Main(string[] args)
            {
                StudentManager studentManager = new StudentManager();
                bool continueProgram = true;

                while (continueProgram)
                {
                    Console.WriteLine("Menu:");
                    Console.WriteLine("1. Add student");
                    Console.WriteLine("2. Update student by ID");
                    Console.WriteLine("3. Delete student by ID");
                    Console.WriteLine("4. Search student by name");
                    Console.WriteLine("5. Sort students by GPA");
                    Console.WriteLine("6. Sort students by name");
                    Console.WriteLine("7. Sort students by ID");
                    Console.WriteLine("8. Display student list");
                    Console.WriteLine("9. Exit");
                    Console.WriteLine("Enter your choice:");

                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Student newStudent = CreateStudent();
                            studentManager.AddStudent(newStudent);
                            break;
                        case 2:
                            Console.WriteLine("Enter student ID to update:");
                            int idToUpdate = int.Parse(Console.ReadLine());
                            Student updatedStudent = CreateStudent();
                            studentManager.UpdateStudent(idToUpdate, updatedStudent);
                            break;
                        case 3:
                            Console.WriteLine("Enter student ID to delete:");
                            int idToDelete = int.Parse(Console.ReadLine());
                            studentManager.DeleteStudent(idToDelete);
                            break;
                        case 4:
                            Console.WriteLine("Enter student name to search:");
                            string nameToSearch = Console.ReadLine();
                            studentManager.SearchStudentByName(nameToSearch);
                            break;
                        case 5:
                            studentManager.SortStudentsByGPA();
                            break;
                        case 6:
                            studentManager.SortStudentsByName();
                            break;
                        case 7:
                            studentManager.SortStudentsById();
                            break;
                        case 8:
                            studentManager.DisplayStudents();
                            break;
                        case 9:
                            continueProgram = false;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
            }

            // Method to create a new student
            static Student CreateStudent()
            {
                Student student = new Student();
                Console.WriteLine("Enter student ID:");
                student.Id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter student name:");
                student.Name = Console.ReadLine();
                Console.WriteLine("Enter student gender:");
                student.Gender = Console.ReadLine();
                Console.WriteLine("Enter student age:");
                student.Age = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter student Math score:");
                student.MathScore = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter student Physics score:");
                student.PhysicsScore = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter student Chemistry score:");
                student.ChemistryScore = double.Parse(Console.ReadLine());
                student.CalculateGPA();
                return student;
            }
        }
    }
