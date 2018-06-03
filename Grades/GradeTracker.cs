using System.IO;

namespace Grades
{
    public abstract class GradeTracker
    {
        public abstract void AddGrade(float grade);
        public abstract GradeStatistics ComputeStatistics();
        public abstract void WriteGrades(TextWriter destination);

        protected string name;
        public event NameChangedDelegate NameChanged;
        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if (name != value)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.ExsitingName = name;
                        args.NewName = value;

                        NameChanged(this, args);
                    }
                    name = value;
                }
            }
        }
    }
}
