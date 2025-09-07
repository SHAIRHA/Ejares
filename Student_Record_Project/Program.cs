using System;

class NodeStudent
{
    public int ID;
    public string Name;
    public string Course;
    public int YearLevel;
    public double GPA;
    public NodeStudent Next;

    public NodeStudent(int id, string name, string course, int yearLevel, double gpa)
    {
        ID = id;
        Name = name;
        Course = course;
        YearLevel = yearLevel;
        GPA = gpa;
        Next = null;
    }
}

class StudentList
{
    private NodeStudent head;

    public void AddStudentAtBeginning(NodeStudent newStudent)
    {
        newStudent.Next = head;
        head = newStudent;
        Console.WriteLine("Student added at the beginning of the list.\n");
        DisplayStudentDetails("BEGINNING", newStudent);
    }

    public void AddStudentAtEnd(NodeStudent newStudent)
    {
        if (head == null)
        {
            head = newStudent;
            Console.WriteLine("Student added at the beginning of the list.\n");
            DisplayStudentDetails("BEGINNING", newStudent);
        }
        else
        {
            NodeStudent temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newStudent;
            Console.WriteLine("Student added at the end of the list.\n");
            DisplayStudentDetails("END", newStudent);
        }
    }

    public void AddStudentAtPosition(NodeStudent newStudent, int position)
    {
        if (position <= 1 || head == null)
        {
            AddStudentAtBeginning(newStudent);
            return;
        }

        NodeStudent temp = head;
        int count = 1;

        while (temp != null && count < position - 1)
        {
            temp = temp.Next;
            count++;
        }

        if (temp == null)
        {
            Console.WriteLine("Invalid Position. Try Again!.\n");
            AddStudentAtEnd(newStudent);
        }
        else
        {
            newStudent.Next = temp.Next;
            temp.Next = newStudent;
            Console.WriteLine("Student added at position " + position + ".\n");
            DisplayStudentDetails("POSITION " + position, newStudent);
        }
    }

    private void DisplayStudentDetails(string location, NodeStudent student)
    {
        Console.WriteLine($"------------------------------------------------------------------------------------------------------------");
        Console.WriteLine($"                                       Student Record:                                                      ");
        Console.WriteLine($" {location}                                                                                                 ");
        Console.WriteLine($" ID={student.ID}, Name={student.Name}, Course={student.Course}, Year={student.YearLevel}, GPA={student.GPA} ");
        Console.WriteLine($"------------------------------------------------------------------------------------------------------------");
    }

    public void DeleteStudent(int id)
    {
        if (head == null)
        {
            Console.WriteLine("Student List is empty.\n");
            return;
        }

        if (head.ID == id)
        {
            head = head.Next;
            Console.WriteLine("Student deleted.\n");
            return;
        }

        NodeStudent temp = head;
        while (temp.Next != null && temp.Next.ID != id)
        {
            temp = temp.Next;
        }

        if (temp.Next == null)
        {
            Console.WriteLine("Student not found. Try Again!\n");
        }
        else
        {
            temp.Next = temp.Next.Next;
            Console.WriteLine("Student deleted.\n");
        }
    }

    public void SearchStudent(int id)
    {
        NodeStudent temp = head;
        while (temp != null)
        {
            if (temp.ID == id)
            {
                Console.WriteLine($"Found: ID={temp.ID}, Name={temp.Name}, Course={temp.Course}, Year={temp.YearLevel}, GPA={temp.GPA}\n");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Student not found. Try Again!\n");
    }

    public void UpdateStudent(int id)
    {
        NodeStudent temp = head;
        while (temp != null)
        {
            if (temp.ID == id)
            {
                Console.Write("Enter new Name: ");
                temp.Name = Console.ReadLine();
                Console.Write("Enter new Course: ");
                temp.Course = Console.ReadLine();
                Console.Write("Enter new Year Level: ");
                temp.YearLevel = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter new GPA: ");
                temp.GPA = (float)Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Student record updated.\n");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Student not found. Try Again!\n");
    }

    public void DisplayAllStudents()
    {
        if (head == null)
        {
            Console.WriteLine("No student records found.\n");
            return;
        }

        NodeStudent temp = head;
        Console.WriteLine("All Student Records:");
        while (temp != null)
        {
            Console.WriteLine($"ID={temp.ID}, Name={temp.Name}, Course={temp.Course}, Year={temp.YearLevel}, GPA={temp.GPA}");
            temp = temp.Next;
        }
        Console.WriteLine();
    }
}

