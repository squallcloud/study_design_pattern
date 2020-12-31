using System;

namespace TemplateMethod001
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Example.Client();
            client.Execute();
        }
    }
}
