using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    internal class Student
    {
        private int id;
        private string name;
        private int marks;

        public Student(int id, string name, int marks)
        {
            this.id = id;
            this.name = name;
            this.marks = marks;
        }
        public int GetMarks()
        {
            return marks;
        }
        public string GetName()
        {
            return name;
        }
        public void Display()
        {
            Console.WriteLine(id + "\t" + name + "\t" + marks);
        }

        ~Student()
        {

        }
    }
    class Program
    {
        static void Main()
        {
            Console.Write("Enter number of students: ");
            int n = int.Parse(Console.ReadLine());

            Student[] students = new Student[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nEnter details for Student " + (i + 1));

                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Marks: ");
                int marks = int.Parse(Console.ReadLine());

                students[i] = new Student(id, name, marks);

            }
            Console.WriteLine("\n--- Student List ---");
            Console.WriteLine("ID\tName\tMarks");

            for (int i = 0; i < n; i++)
            {
                students[i].Display();
            }

            int total = 0;
            int topperIndex = 0;
            int highestMarks = students[0].GetMarks();

            for (int i = 0; i < n; i++)
            {
                int currentMarks = students[i].GetMarks();
                total += currentMarks;

                if (currentMarks > highestMarks)
                {
                    highestMarks = currentMarks;
                    topperIndex = i;
                }
            }

            double average = (double)total / n;

            Console.WriteLine("\n--- Result Analysis ---");
            Console.WriteLine("Average Marks: " + average);
            Console.WriteLine("Topper: " + students[topperIndex].GetName());
            Console.WriteLine("Highest Marks: " + highestMarks);
        }
    }
}
