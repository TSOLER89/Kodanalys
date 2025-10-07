using System;

namespace Kodanalys
{
    class  Program
    {
        static string[] users = new string[10];
        static int userCount = 0;

        static void Main(string[] args)
        {
            bool isRunning= true;
            while (isRunning)
            {
                Console.WriteLine("Välj ett alternativ:");
                Console.WriteLine("1. Lägg till användare");
                Console.WriteLine("2. Visa alla användare");
                Console.WriteLine("3. Ta bort användare");
                Console.WriteLine("4. Sök användare");
                Console.WriteLine("5. Avsluta");
                string menuChoice = Console.ReadLine();

                if (menuChoice == "1")
                {
                    Console.Write("Ange namn: ");
                    string userName = Console.ReadLine();
                    if (userCount < 10)
                    {
                        users[userCount] = userName;
                        userCount++;
                    }
                    else
                    {
                        Console.WriteLine("Listan är full!");
                    }
                }
                else if (menuChoice == "2")
                {
                    Console.WriteLine("Användare:");
                    for (int i = 0; i < userCount; i++)
                    {
                        Console.WriteLine(users[i]);
                    }
                }
                else if (menuChoice == "3")
                {
                    Console.Write("Ange namn att ta bort: ");
                    string nameToRemove = Console.ReadLine();
                    int removeIndex = -1;
                    for (int i = 0; i < userCount; i++)
                    {
                        if (users[i] == nameToRemove)
                        {
                            removeIndex = i;
                            break;
                        }
                    }

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
                else if (menuChoice == "4")
                {
                    Console.Write("Ange namn att söka: ");
                    string nameToSearch = Console.ReadLine();
                    bool found = false;
                    for (int i = 0; i < userCount; i++)
                    {
                        if (users[i] == nameToSearch)
                        {
                            found = true;
                            break;
                        }
                    }
                    if (found)
                    {
                        Console.WriteLine("Användaren finns i listan.");
                    }
                    else
                    {
                        Console.WriteLine("Användaren hittades inte.");
                    }
                }
                else if (menuChoice == "5")
                {
                    isRunning = false;
                }
                else
                {
                    Console.WriteLine("Ogiltigt val.");
                }
                Console.WriteLine();
            }
        }
    }
}
