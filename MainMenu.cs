using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadingForCasual
{
    public class MainMenu
    {
        private bool exitCheck = false;
        public void Show()
        {
            while (!exitCheck)
            {
                Console.WriteLine("1.Запустить поток");
                Console.WriteLine("2.Запустить потоки");
                Console.WriteLine("3.Просмотреть статус потоков");
                Console.WriteLine("4.Изменить сообщение");
                Console.WriteLine("5.Удалить отработавшие потоки");
                Console.WriteLine("6.Выход");
                switch (Console.ReadLine())
                {
                    case "1":
                        TasksContoller.AddNewTask();
                        TasksContoller.StartTasks();
                        break;
                    case "2":
                        TasksContoller.AddNewTasks(10);
                        TasksContoller.StartTasks();
                        break;
                    case "3":
                        TasksContoller.ShowStatusTasks();
                        break;
                    case "4":
                        Messager.Message = Console.ReadLine();
                        break;
                    case "5":
                        TasksContoller.ClerarComletTasks();
                        break;
                    case "6":
                        exitCheck = true;
                        break;
                    default:
                        break;
                
                }
            }
        }
    }
}
