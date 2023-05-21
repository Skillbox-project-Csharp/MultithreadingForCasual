using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultithreadingForCasual
{
    public static class CustomTaskFactory
    {

        public static List<Task> GetTasks(int numberOfThreads)
        {
            List<Task> tasks = new List<Task>();
            for (int i = 0; i < numberOfThreads; i++)
                tasks.Add(GetTask());
            return tasks;
        }
        public static Task GetTask()
        {
            return new Task(Messager.PrintMessage);
        }
    }
}
