using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9student
{
    class Student
    {
        private int indexnumber;
        private string name;
        private double  gpa;
        private int admissionyear;
        private string nic;

        public int Indexnumber { get => indexnumber; set => indexnumber = value; }
        public string Name { get => name; set => name = value; }
        public double Gpa { get => gpa; set => gpa = value; }
        public int Admissionyear { get => admissionyear; set => admissionyear = value; }
        public string Nic { get => nic; set => nic = value; }


        //public Student(int indexnumber, string name, double gpa, int admissionyear, string nic)
        //{
        //    this.indexnumber = indexnumber;
        //    this.name = name;
        //    this.gpa = gpa;
        //    this.admissionyear = admissionyear;
        //    this.nic = nic;
        //}
    }
}
