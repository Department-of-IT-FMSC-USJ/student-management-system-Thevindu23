namespace assignments
{
    internal class Program
    {
        static void Main(string[] arg)
        {
            studentlist StudentList = new studentlist();

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Insert Student");
                Console.WriteLine("2. Search Student");
                Console.WriteLine("3. Remove Student");
                Console.WriteLine("4. Print All Students");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter  Index Number: ");
                        int index = int.Parse(Console.ReadLine());
                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter GPA: ");
                        double gpa = double.Parse(Console.ReadLine());
                        Console.Write("Enter Admission Year: ");
                        int year = int.Parse(Console.ReadLine());
                        Console.Write("Enter NIC: ");
                        string nic = Console.ReadLine();

                       
                        StudentList.InsertStudent(index, name, gpa, year, nic);
                        break;
                    case 2:
                        Console.Write("Enter the index number to search: ");
                        student found = StudentList.SearchStudent(int.Parse(Console.ReadLine()));
                        if (found != null)
                            Console.WriteLine($"Found: {found.name} with GPA {found.gpa}");
                        else
                            Console.WriteLine("Student not found.");
                        break;
                    case 3:
                        Console.Write("Enter index number to remove: ");
                        StudentList.RemoveStudent(int.Parse(Console.ReadLine()));
                        Console.WriteLine("Student removed.");
                        break;
                    case 4:
                        StudentList.PrintStudents();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid. Try again.");
                        break;
                }
            }
        }
    }
}