using System;
using System.Collections.Generic;
using System.IO;

namespace Grades
{
    public class GradeBook : GradeTracker
    {
        public GradeBook()
        {
            grades = new List<float>();
            name = "Empty";
        }
        protected readonly List<float> grades;
        

        public override void AddGrade(float gradeValue)
        {
            grades.Add(gradeValue);
        }

        public override GradeStatistics ComputeStatistics()
        {
            try
            {
                Console.WriteLine("GradeBook::ComputeStatistics");

                GradeStatistics stats = new GradeStatistics();
                float sum = 0;
                foreach (float grade in grades)
                {
                    stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                    stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                    sum += grade;
                }
                stats.AverageGrade = sum / grades.Count;
                return stats;
            }
            catch (Exception) { throw; }
        }

        public override void WriteGrades(TextWriter destination)
        {
           for (int i = grades.Count; i > 0; i--)
            { destination.WriteLine(grades[i - 1]); }
        }
    }
}