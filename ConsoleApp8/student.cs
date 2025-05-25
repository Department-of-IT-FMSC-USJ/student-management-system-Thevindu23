using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    class student
    {
        public int indexNumber;
        public string name;
        public double gpa;
        public int admissionYear;
        public string nic;
        public student next;

        public student(int indexNumber, string name, double gpa, int admissionYear, string nic)
        {
            indexNumber = indexNumber;
            name = name;
            gpa = gpa;
            admissionYear = admissionYear;
            nic = nic;
            next = null;
        }



    }
}
