using System;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = LinqTasks.Task16();
            foreach (var a in t)
            {
                Console.WriteLine(a);
            }
            // var y = LinqTasks.Task13(new[] { 1, 1, 1, 1, 1, 1, 10, 1, 1, 1, 1 });
            // Console.WriteLine(y);

        }
    }
}
