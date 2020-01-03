using System;
using System.Threading;

namespace WakeUpNeo
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green; // text color
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight); // console size
            Console.SetWindowPosition(0, 0); // console position

            Console.WriteLine("Wake up, Neo...");
            Thread.Sleep(3000); // 3 seconds
            
            Console.Clear();
            Console.WriteLine("The matrix has you...");
            Thread.Sleep(3000);

            Console.Clear();
            Console.WriteLine("Follow of the white rabbit.");
            Thread.Sleep(3000);

            Console.Clear();
            Console.WriteLine("Knock, knock, Neo...");
            Thread.Sleep(3000);
        }
    }
}