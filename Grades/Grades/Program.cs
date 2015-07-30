using System;
using System.Collections.Generic;
using System.IO;


namespace Grades {
    class Program {
        static void Main (string[] args) {
            GradeBook GradeBook     = new GradeBook();
            bool Done               = false;
            int MaxNumberOfAttempts = 5;
            int NumberOfAttempts    = 0;

            while (!Done) {
                Console.WriteLine("Please enter name of file containing student grades.");

                try {
                    using (FileStream stream = File.Open(Console.ReadLine(), FileMode.Open))
                    using (StreamReader reader = new StreamReader(stream)) {
                        string line = reader.ReadLine();

                        while (line != null) {
                            float grade = float.Parse(line);
                            GradeBook.AddGrade(grade);
                            line = reader.ReadLine();
                        }

                        Console.WriteLine("Student's grades:");

                        foreach (float grade in GradeBook.GetGrades()) {
                            Console.WriteLine(grade);
                        }

                        Console.WriteLine(GradeBook.Name);
                        Console.WriteLine("Average grade:" + GradeBook.LetterGrade + " (" + GradeBook.AverageGrade() +")");
                        Console.WriteLine("Highest grade:" + GradeBook.HighestGrade());
                        Console.WriteLine("Lowest grade:" + GradeBook.LowestGrade());

                        Done = true;
                    }
                } catch (DirectoryNotFoundException ex) {
                    Console.WriteLine("Invalid entry, please try again.");
                } catch (ArgumentException ex) {
                    Console.WriteLine("Invalid entry, please try again.");
                } catch (FileNotFoundException ex) {
                    Console.WriteLine("Could not find the file grades.txt");
                } catch (UnauthorizedAccessException ex) {
                    Console.WriteLine("You do not have access to grades.txt");
                }

                NumberOfAttempts++;
                if (NumberOfAttempts > MaxNumberOfAttempts) {
                    Console.WriteLine("Max number of attempts exceeded, exiting.");
                    Done = true;
                }
                
            }

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