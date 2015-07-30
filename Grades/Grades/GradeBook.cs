using System;
using System.Collections.Generic;

namespace Grades {
    class GradeBook {
        List<float> Grades = new List<float>();

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

        public float PointScale () {
            float pointScale = 0;
            float averageGrade = AverageGrade();

            pointScale = averageGrade / 22.5f;

            return Math.Min(pointScale, 4.0f);
        }

        public List<float> GetGrades () {
            return Grades;
        }
    }
}
