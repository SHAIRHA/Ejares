using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Record_Project
{
    public class Program
    {
        static void Main()
        {
            StudentList list = new StudentList();
            bool running = true;
            int choice;

            while (running)
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("|     Student Record Management System    |");
                Console.WriteLine("| 1. Add Student                          |");
                Console.WriteLine("| 2. Delete Student                       |");
                Console.WriteLine("| 3. Search Student                       |");
                Console.WriteLine("| 4. Update Student                       |");
                Console.WriteLine("| 5. Display All Students                 |");
                Console.WriteLine("| 6. Exit                                 |");
                Console.WriteLine("-------------------------------------------");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (choice == 1)
                {
                    Console.Write("Enter ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Course: ");
                    string course = Console.ReadLine();
                    Console.Write("Enter Year Level: ");
                    int year = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter GPA: ");
                    double gpa = Convert.ToDouble(Console.ReadLine());

                    NodeStudent newStudent = new NodeStudent(id, name, course, year, gpa);

                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("|     Insert at:                          |");
                    Console.WriteLine("| 1. Beginning                            |");
                    Console.WriteLine("| 2. End                                  |");
                    Console.WriteLine("| 3. Specific Location                    |");
                    Console.WriteLine("-------------------------------------------");
                    Console.Write("Enter your choice: ");
                    int insertChoice = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    if (insertChoice == 1)
                        list.AddStudentAtBeginning(newStudent);
                    else if (insertChoice == 2)
                        list.AddStudentAtEnd(newStudent);
                    else if (insertChoice == 3)
                    {
                        Console.Write("Enter position: ");
                        int position = Convert.ToInt32(Console.ReadLine());
                        list.AddStudentAtPosition(newStudent, position);
                    }
                    else
                        Console.WriteLine("Invalid choice. Try Again\n");
                }
                else if (choice == 2)
                {
                    Console.Write("Enter ID to delete: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    list.DeleteStudent(id);
                }
                else if (choice == 3)
                {
                    Console.Write("Enter ID to search: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    list.SearchStudent(id);
                }
                else if (choice == 4)
                {
                    Console.Write("Enter ID to update: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    list.UpdateStudent(id);
                }
                else if (choice == 5)
                {
                    list.DisplayAllStudents();
                }
                else if (choice == 6)
                {
                    Console.WriteLine("Exiting...");
                    running = false;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Try Again.\n");
                }

            }
        }
    }

}
