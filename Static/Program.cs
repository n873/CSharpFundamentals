using System;

namespace Static
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Company name: " + CompanyInfo.GetCompanyName()); 
            Console.Read();
        }
    }

    static class CompanyInfo {
        public static string GetCompanyName() { return "BOZO Inc."; }
    }
}
