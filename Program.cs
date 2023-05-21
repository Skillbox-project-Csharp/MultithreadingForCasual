using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadingForCasual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            
           /* while (true)
            {
                TaskController.Message = Console.ReadLine();
                List<Task> tasks = TaskController.GetTasks(5);
                foreach (Task task in tasks)
                    task.Start();
            }
            Console.ReadLine();*/
            
        }
    }
}
