using System;
using System.Collections.Generic;

namespace Kodanalys
{
    class Program
    {
        static List<string> Users = new();

        static void Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning)
            {
                PrintMenu();
                string menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        AddUser();
                        break;
                    case "2":
                        ShowUsers();
                        break;
                    case "3":
                        RemoveUser();
                        break;
                    case "4":
                        SearchUser();
                        break;
                    case "5":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val.");
                        break;
                }
                Console.WriteLine();
            }
        }

        static void PrintMenu()
        {
            Console.WriteLine("Välj ett alternativ:");
            Console.WriteLine("1. Lägg till användare");
            Console.WriteLine("2. Visa alla användare");
            Console.WriteLine("3. Ta bort användare");
            Console.WriteLine("4. Sök användare");
            Console.WriteLine("5. Avsluta");
        }

        static void AddUser()
        {
            if (Users.Count >= 10)
            {
                Console.WriteLine("Listan är full!");
                return;
            }
            Console.Write("Ange namn: ");
            string userName = Console.ReadLine();
            Users.Add(userName);
        }

        static void ShowUsers()
        {
            Console.WriteLine("Användare:");
            foreach (var user in Users)
            {
                Console.WriteLine(user);
            }
        }

        static void RemoveUser()
        {
            Console.Write("Ange namn att ta bort: ");
            string nameToRemove = Console.ReadLine();
            if (!Users.Remove(nameToRemove))
            {
                Console.WriteLine("Användaren hittades inte.");
            }
        }

        static void SearchUser()
        {
            Console.Write("Ange namn att söka: ");
            string nameToSearch = Console.ReadLine();
            if (Users.Contains(nameToSearch))
            {
                Console.WriteLine("Användaren finns i listan.");
            }
            else
            {
                Console.WriteLine("Användaren hittades inte.");
            }
        }
    }
}