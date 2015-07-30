using System;
using System.Collections.Generic;

namespace Grades {
    class GradeBook {
        public string       Name;
        private List<float> Grades = new List<float>();

        public string LetterGrade {
            get {
                float averageGrade = AverageGrade();

                if (averageGrade >= 90) {
                    return "A";
                } else if (averageGrade >= 80) {
                    return "B";
                } else if (averageGrade >= 70) {
                    return "C";
                } else if (averageGrade >= 60) {
                    return "D";
                } else {
                    return "F";
                }
            }
            private set { }
        }

        public void AddGrade (float grade) {
            Grades.Add(grade);
        }

        public float AverageGrade () {
            float sum = 0;

            foreach (float grade in Grades) {
                sum += grade;    
            }

            return sum / Grades.Count;
        }

        public float HighestGrade () {
            float highestGrade = 0;

            foreach (float grade in Grades) {
                if (grade > highestGrade) {
                    highestGrade = grade;
                }
            }

            return highestGrade;
        }

        public float LowestGrade () {
            float lowestGrade = -1;

            foreach (float grade in Grades) {
                if (lowestGrade == -1 || grade < lowestGrade) {
                    lowestGrade = grade;
                }
            }

            return lowestGrade;
        }

        public List<float> GetGrades () {
            return Grades;
        }
    }
}
