using System;

namespace Grades
{
    public class GradeStatistics
    {
        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;

        public GradeStatistics()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }

        public string LetterGrade {
            get {
                var roundedAverageGrade = Math.Round(AverageGrade);
                string result;
                if (roundedAverageGrade >= 90)
                    result = "A";
                else if (roundedAverageGrade >= 80)
                    result = "B";
                else if (roundedAverageGrade >= 70)
                    result = "C";
                else if (roundedAverageGrade >= 60)
                    result = "D";
                else
                    result = "F";
                return result;
            }
        }

        public string Description {
            get {
                string result;
                switch (LetterGrade)
                {
                    case "A":
                        result = "Excellent";
                        break;
                    case "B":
                        result = "Good";
                        break;
                    case "C":
                        result = "Average";
                        break;
                    case "D":
                        result = "Below Average";
                        break;
                    default:
                        result = "Failure";
                        break;
                }
                return result;
            }
        }
    }
}