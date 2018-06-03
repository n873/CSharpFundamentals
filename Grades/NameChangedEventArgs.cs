using System;
using System.Collections.Generic;
using System.Text;

namespace Grades
{
    public class NameChangedEventArgs : EventArgs
    {
        public string ExsitingName { get; set; }
        public string NewName { get; set; }
    }
}
