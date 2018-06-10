using System;

namespace ReferenceVsValue
{
    /// 1. What's Reference Types?
    ///    Reference types are objects that store references
    ///    to the actual data.
    ///    
    ///    Class, Interface, delegate, object & string
    class Program
    {
        //Object
        static object Book { get; set; } = "Star Trek";

        //Delegate
        delegate void del(string value);
        static void Main(string[] args)
        {
            del d = x => Console.WriteLine(x);
            d.Invoke(Book.ToString());

            Console.Read();
        }       

    }

    interface Student { }

    /// ======================================================
    /// 2. What are Value types?
    /// 
    ///    Value types actually hold values. Assigning one value type
    ///    to another literally copies that value.
    ///    
    ///    Structs, enums, bools, numeric types
    public struct Book {
        public string title;
        bool isRecommended;

        // Floating point, integral types (sbyte, byte, char, etc) 
        public decimal price;
    }

    enum Days { Sat, Sun, Mon, Tue, Wed, Thu, Fri};
}
