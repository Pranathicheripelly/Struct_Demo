using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Demo
{
   

            

struct Student
        {
            public string Name;
            public int Age;
            public string Course;
            public double GPA;
        }
        class Program
        {
            static void Main(string[] args)
            {
                doApp();
            }

            static void doApp()
            {
                Student student1;
                student1.Name = "Nani";
                student1.Age = 24;
                student1.Course = "Computer Science";
                student1.GPA = 5.8;

                Student student2;
                student2.Name = "babu";
                student2.Age = 26;
                student2.Course = "Python";
                student2.GPA = 8.5;

                Console.WriteLine("Student 1 Details:");
                Console.WriteLine($"Name: {student1.Name}");
                Console.WriteLine($"Age: {student1.Age}");
                Console.WriteLine($"Course: {student1.Course}");
                Console.WriteLine($"GPA: {student1.GPA}");

                Console.WriteLine("\nStudent 2 Details:");
                Console.WriteLine($"Name: {student2.Name}");
                Console.WriteLine($"Age: {student2.Age}");
                Console.WriteLine($"Course: {student2.Course}");
                Console.WriteLine($"GPA: {student2.GPA}");
            Console.ReadLine();
            }
        }
    }
 