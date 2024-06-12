using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

class Program
{
    static Random random = new Random();
    static int maxNum = 5; // Maximum number of recursion

    static void Main(string[] args)
    {
            string randomString = genRoom("START", 0); // Start with depth 0
            Console.Write(randomString);
            Console.Write("EXIT");
    }

    static string genRoom(string symbol, int numCount)
    {
        int keyNum = 0;
        
        if (symbol == "START")
        {
            return "START" + " -> " + genRoom("ROOM", numCount + 1) + genRoom("CONTENT", numCount + 1);
        }
        else if (symbol == "CONTENT")
        {
            int choice = random.Next(3);
            if (choice == 0)
            {
                return genRoom("ROOM", numCount + 1);
            }
            else if (choice == 1 && keyNum < 3)
            {
                keyNum ++;
                return genRoom("KEY", numCount + 1) + genRoom("CONTENT", numCount + 1) + genRoom("LOCK", numCount + 1) + genRoom("CONTENT", numCount + 1);
            }
            else
            {
                return genRoom("CONTENT", numCount + 1);
            }
        }
        else if (symbol == "ROOM")
        {
            return "ROOM" + " -> ";
        }
        else if (symbol == "KEY")
        {
            return "KEY" + " -> ";
        }
        else if (symbol == "LOCK")
        {
            return "LOCK" + " -> ";
        }
        else
        {
            return "";
        }
    }
}
