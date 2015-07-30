using System;
using System.Collections.Generic;
using System.IO;


namespace Grades {
    class Program {
        static void Main (string[] args) {
            GradeBook GradeBook = new GradeBook();
            FileStream   stream = null;
            StreamReader reader = null;

            try {
                stream = File.Open("grades.txt", FileMode.Open);
                reader = new StreamReader(stream);

                string line = reader.ReadLine();
                while (line != null) {
                    float grade = float.Parse(line);
                    GradeBook.AddGrade(grade);
                    line = reader.ReadLine();
                }
            } catch (FileNotFoundException ex) {
                Console.WriteLine("Could not find the file grades.txt");
            } catch (UnauthorizedAccessException ex) {
                Console.WriteLine("You do not have access to grades.txt");
            } finally {
                if (reader != null) {
                    reader.Close();
                }
                if (stream != null) {
                    stream.Close();
                }
            }

            Console.WriteLine("Student's grades:");

            foreach (float grade in GradeBook.GetGrades()) {
                Console.WriteLine(grade);
            }

            Console.WriteLine(GradeBook.Name);
            Console.WriteLine("Average grade:" + GradeBook.AverageGrade() + GradeBook.LetterGrade);
            Console.WriteLine("Highest grade:" + GradeBook.HighestGrade());
            Console.WriteLine("Lowest grade:" + GradeBook.LowestGrade());

            Console.Read();
        }

        private static void FillGradeBookWithRandomGrades (GradeBook GradeBook) {
            Random Random = new Random();
            GradeBook.Name = "John Doe";

            for (int i = 0; i < 6; i++) {
                GradeBook.AddGrade(Random.Next(75, 100));
            }
        }
    }
}