//Task Tracker App 
/*
Features :
1. Add Task
2. Delete Task
3. Update Task
4. View All Task
5. Exit
 */

namespace TaskTracker
{
    public class Program
    {
        static string[] Tasks = new string[100];
        static int TaskIndex = 0;
        static void Main(string[] args)
        {

            Console.WriteLine("""
                ---------------------------------
                Welcome To my simple Task Tracker
                ---------------------------------
                """);

            while (true)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("Choose an option : ");

                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. Delete Task");
                Console.WriteLine("3. Update Task");
                Console.WriteLine("4. View All Task");
                Console.WriteLine("5. Exit");
                Console.WriteLine("--------------------");
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            AddTask();
                            break;
                        case 2:
                            DeleteTask();
                            break;
                        case 3:
                            UpdateTask();
                            break;
                        case 4:
                            ViewAllTask();
                            break;
                        case 5:
                            Console.WriteLine("Thank You for using Task Tracker");
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }


        }
        private static void AddTask()
        {
            Console.WriteLine("Enter Task Name : ");
            Tasks[TaskIndex] = Console.ReadLine();
            TaskIndex++;
            Console.WriteLine("Task Added Successfully");
        }
        private static void DeleteTask()
        {
            Console.WriteLine("Enter Task Number : ");
            int taskID = Convert.ToInt32(Console.ReadLine());
            Tasks[taskID-1] = "";
            Console.WriteLine("Task Deleted Successfully");
        }
        private static void UpdateTask()
        {
            Console.WriteLine("Enter Task Number : ");
            int taskID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter New Task Name : "); 
            Tasks[taskID - 1] = Console.ReadLine();
            Console.WriteLine("Task Updated Successfully");
        }
        private static void ViewAllTask()
        {
            for (int i = 0; i < TaskIndex+1; i++)
            {
                if (Tasks[i] != null)
                {
                    Console.WriteLine($"{i+1}. {Tasks[i]}");
                }
            }
            Console.WriteLine("                   - All Tasks You have");
        }
    }

}
