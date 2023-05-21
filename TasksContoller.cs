using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadingForCasual
{
    public static class TasksContoller
    {
        public static void AddNewTasks(int numberTask)
        {
            TasksData.Tasks.AddRange(CustomTaskFactory.GetTasks(numberTask));
        }
        public static void AddNewTask()
        {
            TasksData.Tasks.Add(CustomTaskFactory.GetTask());
        }
        public static void StartTasks()
        {
            foreach (var task in TasksData.Tasks)
            {
                try
                {
                    task.Start();
                }
                catch (Exception) { }
            }
        }
        public static void ShowStatusTasks()
        {
            foreach (var task in TasksData.Tasks)
                Console.WriteLine($"{task.Id}-{task.Status}");
        }
        public static void ClerarComletTasks()
        {
            TasksData.Tasks.RemoveAll(task => task.Status == TaskStatus.RanToCompletion);
        }
    }

}
