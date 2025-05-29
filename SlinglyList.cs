using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9student
{
    class SlinglyList
    {
        private Node head;
        private Node tail;

        internal Node Head { get => head; set => head = value; }
        internal Node Tail { get => tail; set => tail = value; }

        public SlinglyList()
        {
            head = null;
            tail = null;
        }

        public void Add(Node student)
        {
            // Case 1: Empty list or student should be first
            if (head == null || student.Student.Indexnumber < head.Student.Indexnumber)
            {
                student.Next = head;
                head = student;
                return;
            }

            Node current = head;

            // Traverse until the correct position
            while (current.Next != null && current.Next.Student.Indexnumber < student.Student.Indexnumber)
            {
                current = current.Next;
            }

            // Check for duplicate
            if (current.Next != null && current.Next.Student.Indexnumber == student.Student.Indexnumber)
            {
                Console.WriteLine("Student with this Index Number already exists.");
                return;
            }

            // Insert student
            student.Next = current.Next;
            current.Next = student;
        }



        public Node searchstudent(int indexnumber)
        {

            Node current = head;
            while (current != null)
            {
                if (current.Student.Indexnumber == indexnumber)
                {
                    return current;
                }
                else
                {
                    current = current.Next;
                }
                
            }
            return null;
        }

        public void Removestudent(int indexnumber)
        {
            if (head == null)
            {
                return;
            }
            if (head.Student.Indexnumber == indexnumber)
            {
                head = head.Next;
                return;
            }
            Node current = head;
            Node previous = head;
            while (current != null && current.Student.Indexnumber != indexnumber)
            {
                previous = current;
                current = current.Next;
            }
            if (current == null) return;
            previous.Next = current.Next;
        }
        public void Display()
        {
            
            if(head == null)
            {
                Console.WriteLine("No students Records");
                return;
            }
            Node current = head;
            while (current != null) 
            {
                
                Console.WriteLine("Index Number: " + current.Student.Indexnumber);
                Console.WriteLine("Name: " + current.Student.Name);
                Console.WriteLine("GPA: " + current.Student.Gpa);
                Console.WriteLine("Admission Year: " + current.Student.Admissionyear);
                Console.WriteLine("NIC: " + current.Student.Nic);
                Console.WriteLine("-----------------------------");
                current = current.Next;
            } 
        }
    }
}