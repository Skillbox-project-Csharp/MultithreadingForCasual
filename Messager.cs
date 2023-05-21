using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadingForCasual
{
    public static class Messager
    {
        public static string Message { get; set; } = "Hello world";
        public static Random Rand { get; set; } = new Random();
        public static void PrintMessage()
        {
            lock (Message)
            {
                lock (Rand)
                {
                    int delay = Rand.Next(1000, 3000);
                    Task.Delay(delay).Wait();
                    Console.WriteLine($"{Message} :Поток номер {Task.CurrentId} с ожиданием {delay}");
                }
            }
        }
    }
}
