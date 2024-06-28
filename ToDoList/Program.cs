using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> tasks = new List<string>();
            string choice = string.Empty;

            do
            {
                Console.WriteLine("Enter: 1 - to add a task to the list");
                Console.WriteLine("Enter: 2 - to remove a task from the list");
                Console.WriteLine("Enter: 3 - to view the list");
                Console.WriteLine("Enter: \"exit\" - to exit the program\n");

                choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.WriteLine("Enter a task to be added to the list: ");
                    tasks.Add(Console.ReadLine());
                }

                else if (choice == "2")
                {
                    Console.WriteLine("Choose a task to be removed from the list: ");
                    tasks.Remove(Console.ReadLine());
                }

                else if (choice == "3")
                {
                    foreach (string task in tasks)
                    {
                        Console.Write(task + " ");
                    }
                    Console.WriteLine(Environment.NewLine);
                }
                else if (choice == "exit")
                {
                    Console.WriteLine("The program is closing!");
                }

                else
                {
                    Console.WriteLine("Invalid Input. Try again.\n");
                }
            }
            while (choice != "exit");
        }
    }
}