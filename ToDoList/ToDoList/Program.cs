using System;
using System.Collections.Generic;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello!\nHere are your daily tasks.\n");

            Task onetask = new Task(1, "Turn on lights.");
            onetask.StatusReport();

            Task twotask = new Task(2, "Turn on computer.");
            twotask.StatusReport();

            Task threetask = new Task(3, "Make coffee.");
            threetask.StatusReport();

            Task fourtask = new Task(4, "Feed fish.");
            fourtask.StatusReport();

            Task fivetask = new Task(5, "Check emails.");
            fivetask.StatusReport();


            var tasks = new List<Task>();
            tasks.Add(onetask);
            tasks.Add(twotask);
            tasks.Add(threetask);
            tasks.Add(fourtask);
            tasks.Add(fivetask);

            int taskCount = tasks.Count;

            while (taskCount > 0)
            {

                Console.WriteLine($"\nWhich item would you like to mark complete?");
                var itemId = Convert.ToInt32(Console.ReadLine());
                foreach (var task in tasks)
                {
                    if (itemId == task.Id)
                    {
                        task.Status = true;
                    }
                    task.StatusReport();
                }

                taskCount--;
                Console.WriteLine($"\nYou have {taskCount} items left to do.");
            }
            Console.WriteLine($"\nAll items have been complete. The system will exit.");
        }
    }
}
