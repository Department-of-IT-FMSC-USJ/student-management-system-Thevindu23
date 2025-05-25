using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    class studentlist
    {
        private student head;

        public void InsertStudent(int indexNumber, string name, double gpa, int admissionYear, string nic)
        {
            student newStudent = new student(indexNumber, name, gpa, admissionYear, nic);
            if (head == null || head.indexNumber > indexNumber)
            {
                newStudent.next = head;
                head = newStudent;
                return;
            }

            student current = head;
            while (current.next != null && current.next.indexNumber < indexNumber)
            {
                current = current.next;
            }

            newStudent.next = current.next;
            current.next = newStudent;
        }

        public student SearchStudent(int indexNumber)
        {
            student current = head;
            while (current != null)
            {
                if (current.indexNumber == indexNumber)
                    return current;
                current = current.next;
            }
            return null;
        }

        public void RemoveStudent(int indexNumber)
        {
            if (head == null)
                return;

            if (head.indexNumber == indexNumber)
            {
                head = head.next;
                return;
            }

            student current = head;
            while (current.next != null && current.next.indexNumber != indexNumber)
            {
                current = current.next;
            }

            if (current.next != null)
            {
                current.next = current.next.next;
            }   
        }

        public void PrintStudents()
        {
            student current = head;
            while (current != null)
            {
                Console.WriteLine($"Index- {current.indexNumber}, Name- {current.name}, GPA- {current.gpa}, Year- {current.admissionYear}, NIC- {current.nic}");
                current = current.next;
            }
        }

    }
}
