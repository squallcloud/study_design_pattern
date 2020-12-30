using System;

namespace Command001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Old");
            {
                var student = new Old.Student();
                student.Execute();
            }

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("New");
            {
                var student = new New.Student();
                student.Execute();
            }
        }
    }
}
