using System;
using System.Collections.Generic;

namespace Generics
{

    class TestGenericList {
        private class ExampleClass { }
        static void Main()
        {
            //Declare a list of type int
            var list1 = new List<int>();
            //Declare a list of type string
            var list2 = new List<string>();
            //Declare a list of type ExampleClass
            var list3 = new List<ExampleClass>();

            list2.Add("Generic Nate");
            Console.WriteLine(list2[0]);
            Console.Read();
        }
    }
}
