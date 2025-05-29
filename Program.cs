using System.Collections.Generic;

namespace ConsoleApp9student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SlinglyList studentList = new SlinglyList();
            Console.WriteLine("Welcome to student Management System");
           
            
            bool exit = true;
            while (exit)
            {
                Console.WriteLine("Please select an option :");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Delete Student");
                Console.WriteLine("3. Search Student");
                Console.WriteLine("4. Display Students");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your option:");
                int choice = int.Parse(Console.ReadLine());


         

               
                switch (choice) 
                {
                    case 1:
                       Student student = new Student();
                        Console.Write("Enter student index number :");
                        student.Indexnumber = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter student name :");
                        student.Name = Console.ReadLine();
                        Console.Write("Enter GPA :");
                        student.Gpa = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter admission year :");
                        student.Admissionyear = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter NIC number :");
                        student.Nic = Console.ReadLine();
                    
                        Node stu = new Node();
                        stu.Student = student;
                        studentList.Add(stu);
                    

                        break;
                    case 2:
                        Console.Write("Enter student index number to delete :");
                        int deleteIndexNumber = Convert.ToInt32(Console.ReadLine());
                        studentList.Removestudent(deleteIndexNumber);
                        Console.Write("Student deleted successfully.");
                        break;
                    case 3:
                        Console.Write("Enter student index number to search :");
                        int searchIndexNumber = Convert.ToInt32(Console.ReadLine());
                        Node foundNode = studentList.searchstudent(searchIndexNumber);
                        if (foundNode != null)
                        {
                            Console.Write($"Student found: {foundNode.Student.Name}");
                        }
                        else
                        {
                            Console.Write("Student not found.");
                        }
                        break;
                    case 4:
                        studentList.Display();
                        break;
                    case 5:
                        exit = false;
                        Console.Write("Exiting the program.");
                        break;
                        
                   
                    default:
                        Console.Write("Invalid choice. Please try again.");
                        break;

                }
            }
        }
    }
}
