using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_MiniProject_Sahil_Chikhale
{   
    //Mini project(Assignment Week 2) for creating an operational Task Manager using List and loops:-
    class Task1
    {
        static void Main(string[] args)
        {
            //Creating an list to store the users data
            List<(string Title, string Description)> taskList = new List<(string, string)>();
            Console.WriteLine("Welcome to Sahil's Task Manager");
            do
            {
                //choices for Task Manager
                Console.WriteLine("1.Create task");
                Console.WriteLine("2.Read tasks");
                Console.WriteLine("3.Update task");
                Console.WriteLine("4.Delete task");
                Console.WriteLine("5.Exit");

                Console.Write("Please Enter your choice: ");
                int ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    //Task Creation Case
                    case 1:
                        Console.Write("Enter task title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter task description: ");
                        string description = Console.ReadLine();
                        taskList.Add((title, description));
                        Console.WriteLine("Task Created!");
                        break;
                    //Task Displaying Case
                    case 2:
                        int i = 0;
                        foreach ((string Title, string Description) task in taskList)
                        {
                            Console.WriteLine($"Task {i}: Title: {task.Title}, Description: {task.Description}");
                            Console.WriteLine("--------------------------------------------------");
                            i++;
                        }
                        break;

                    //Task Updation Case
                    case 3:
                        Console.Write("Enter index of the task to update: ");
                        int updateIndex = int.Parse(Console.ReadLine());

                        if (updateIndex >= 0 && updateIndex < taskList.Count)
                        {
                            Console.Write("Enter updated title: ");
                            string updatedTitle = Console.ReadLine();
                            Console.Write("Enter updated description: ");
                            string updatedDescription = Console.ReadLine();
                            taskList[updateIndex] = (updatedTitle, updatedDescription);

                            Console.WriteLine("Task updated successfully");
                        }
                        else
                        {
                            Console.WriteLine("Sorry! Invalid task number. Try again");
                        }
                        break;

                    //Task Deletion Case
                    case 4: 
                        Console.Write("Enter the number of the task to delete: ");
                        int deleteIndex = Convert.ToInt32(Console.ReadLine());

                        if (deleteIndex >= 0 && deleteIndex < taskList.Count)
                        {
                            taskList.RemoveAt(deleteIndex);
                            Console.WriteLine("Task deleted successfully");
                        }
                        else
                        {
                            Console.WriteLine("Sorry Invalid task number! Try again");
                        }
                        break;
                    case 5:
                        Environment.Exit(0);    //helps to get out of the console app
                        break;
                    default:
                        Console.WriteLine("Sorry Wrong choice,Please Try Again: ");
                        break;
                }
            } while (true);
        }
    }
}
