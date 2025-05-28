using System.Collections.Generic;

namespace ConsoleApp9student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SlinglyList studentList = new SlinglyList();
            Console.WriteLine("Welcome to student Management System");
           
            
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Delete Student");
                Console.WriteLine("3. Search Student");
                Console.WriteLine("4. Display Students");
                Console.WriteLine("5. Exit");

                int choice = int.Parse(Console.ReadLine());


         

               
                switch (choice) 
                {
                    case 1:
                       Student student = new Student(0, "", 0.0, 0, "");
                        Console.WriteLine("Enter student index number");
                        student.Indexnumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter student name");
                        student.Name = Console.ReadLine();
                        Console.WriteLine("Enter GPA");
                        student.Gpa = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter admission year");
                        student.Admissionyear = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter NIC number");
                        student.Nic = Console.ReadLine();
                    
                        studentList.Add(new Node { Student = student });
                    

                        break;
                    case 2:
                        Console.WriteLine("Enter student index number to delete");
                        int deleteIndexNumber = Convert.ToInt32(Console.ReadLine());
                        studentList.Removestudent(deleteIndexNumber);
                        Console.WriteLine("Student deleted successfully.");
                        break;
                    case 3:
                        Console.WriteLine("Enter student index number to search");
                        int searchIndexNumber = Convert.ToInt32(Console.ReadLine());
                        Node foundNode = studentList.searchstudent(searchIndexNumber);
                        if (foundNode != null)
                        {
                            Console.WriteLine($"Student found: {foundNode.Student.Name}");
                        }
                        else
                        {
                            Console.WriteLine("Student not found.");
                        }
                        break;
                 
                        break;
                    case 4:
                        studentList.Display();
                        break;
                    case 5:
                        exit = true;
                        Console.WriteLine("Exiting the program.");
                        break;
                        
                   
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;

                }
            }
        }
    }
}
