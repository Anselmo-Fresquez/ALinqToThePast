using System;
using System.Collections.Generic;


namespace Grades {
    class Program {
        static void Main (string[] args) {
            GradeBook GradeBook = new GradeBook();
            Random Random = new Random();

            for (int i = 0; i < 6; i++) {
                GradeBook.AddGrade(Random.Next(75, 100));
            }

            Console.WriteLine("Student's grades:");

            foreach (float grade in GradeBook.GetGrades()) {
                Console.WriteLine(grade);
            }

            Console.WriteLine("Average grade:" + GradeBook.AverageGrade());
            Console.WriteLine("Highest grade:" + GradeBook.HighestGrade());
            Console.WriteLine("Lowest grade:" + GradeBook.LowestGrade());
            Console.WriteLine("GPA: " + GradeBook.PointScale().ToString("#0.0"));

            Console.Read();
        }
    }
}