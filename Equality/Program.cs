using System;
using System.Text;

namespace Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            var int1 = 1;
            var int2 = 1;

            var variable1 = "Im a variable";
            var variable2 = string.Copy(variable1);

            var builder1 = new StringBuilder();
            var builder2 = new StringBuilder();

            var six = 6.0000000f;
            var nearlySix = 6.0000001f;

            var x = 5.05f;
            var y = 0.95f;

            #region Value Comparison
            Console.WriteLine($"stringbuilder equality: {builder1 == builder2}");
            Console.WriteLine($"int equality: {int1 == int2}");
            Console.WriteLine($"string equality: {variable1 == variable2}");
            #endregion

            #region Reference Comparison
            //Casting the value type to object (reference) type - boxing
            Console.WriteLine($"object equality: {(object)int1 == (object)int2}");
            Console.WriteLine($"interface equality: {(IComparable<int>)int1 == (IComparable<int>)int2}");
            #endregion

            Console.WriteLine($"float equality: {six == nearlySix}");
            Console.WriteLine($"float equality: 5.05 + 0.95 == 6? {x + y == 6.0f}");


            Console.Read();
        }
    }
}
