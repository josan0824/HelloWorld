using System;

namespace HelloWorld
{
    //1. F5可以直接启动程序
    class Program
    {
        //整个程序的入口
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            ////为了避免控制窗体一闪而过
            //Console.Write("Press any key to continue...");
            //Console.ReadKey(true);

            Console.WriteLine("\nWhat is your name");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"\nHello, {name}, on {date: d} at {date:t}!");
            Console.Write("\n Press any key to exit...");
            Console.ReadKey();
        }
    }
}
