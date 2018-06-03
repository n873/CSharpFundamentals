using System;
using Xunit;

namespace Grades.Tests.Types
{
    public class TypeTests
    {
        [Fact]
        public void GradeBookVariablesHoldAReference() {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "Nathan's grade book";
            Assert.Equal(g1.Name, g2.Name);
        }

        [Fact]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;
            Assert.NotEqual(x1, x2);
        }

        [Fact]
        public void StringComparison()
        {
            string name1 = "Nathan";
            string name2 = "nathan";
             
            bool result = string.Equals(name1, name2, System.StringComparison.InvariantCultureIgnoreCase);
            Assert.True(result);
        }

        [Fact]
        public void ReferenceTypesPassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookAName(ref book2);
            Assert.Equal("A GradeBook", book2.Name);
        }

        [Fact]
        public void ValueTypesPassByValue()
        {
            int x = 46;
            IncrementNumber(ref x);
            Assert.Equal(47, x);
        }

        [Fact]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2018, 5, 2);
            date = date.AddDays(1);

            Assert.Equal(3, date.Day);
        }

        [Fact]
        public void UppercaseString()
        {
            string name = "nathan";
            name = name.ToUpper();

            Assert.Equal("NATHAN", name);
        }

        [Fact]
        public void UsingArrays()
        {
            float[] grades;
            grades = new float[3];

            AddGrades(grades);

            Assert.Equal(89.1f, grades[1]);
        }

        private void GiveBookAName(ref GradeBook book) {
            book = new GradeBook();
            book.Name = "A GradeBook";
        }

        private void IncrementNumber(ref int number)
        {
            number += 1;
        }

        private void AddGrades(float[] grades)
        {
            grades[1] = 89.1f;
        }
    }
}
