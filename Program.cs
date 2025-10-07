using System;

namespace Kodanalys
{
    class Program
    {
        static string[] users = new string[10];
        static int userCount = 0;

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
            Console.Write("Ange namn: ");
            string userName = Console.ReadLine();
            if (userCount < users.Length)
            {
                users[userCount] = userName;
                userCount++;
            }
            else
            {
                Console.WriteLine("Listan är full!");
            }
        }

        static void ShowUsers()
        {
            Console.WriteLine("Användare:");
            for (int i = 0; i < userCount; i++)
            {
                Console.WriteLine(users[i]);
            }
        }

        static void RemoveUser()
        {
            Console.Write("Ange namn att ta bort: ");
            string nameToRemove = Console.ReadLine();
            int removeIndex = FindUserIndex(nameToRemove);

            if (removeIndex != -1)
            {
                for (int i = removeIndex; i < userCount - 1; i++)
                {
                    users[i] = users[i + 1];
                }
                userCount--;
            }
            else
            {
                Console.WriteLine("Användaren hittades inte.");
            }
        }

        static void SearchUser()
        {
            Console.Write("Ange namn att söka: ");
            string nameToSearch = Console.ReadLine();
            int foundIndex = FindUserIndex(nameToSearch);

            if (foundIndex != -1)
            {
                Console.WriteLine("Användaren finns i listan.");
            }
            else
            {
                Console.WriteLine("Användaren hittades inte.");
            }
        }

        static int FindUserIndex(string userName)
        {
            for (int i = 0; i < userCount; i++)
            {
                if (users[i] == userName)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
