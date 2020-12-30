using System;

namespace Command001
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                var student = new Old.Student();
                student.Execute();
            }
        }
    }
}
