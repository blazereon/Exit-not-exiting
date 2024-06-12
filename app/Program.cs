using System;

class Program
{
    static Random random = new Random();
    static int maxNum = 5; // Maximum number of recursion

    static void Main(string[] args)
    {
        int numberOfStrings = 1; // Maximum number of loop
        for (int i = 0; i < numberOfStrings; i++)
        {
            string randomString = GenerateRandomString("START", 0); // Start with depth 0
            Console.WriteLine(randomString);
            if(randomString == "EXIT"){
                break;
            }
        } 
    }

    static string GenerateRandomString(string symbol, int numCount)
    {
        if (numCount >= maxNum)
        {
            Console.WriteLine(numCount);
            return "EXIT";
        }
        
        switch (symbol)
        {
            case "START":
                return "START" + "->" + GenerateRandomString("ROOM", numCount + 1) + GenerateRandomString("CONTENT", numCount + 1);

            case "CONTENT":
                int choice = random.Next(3);
                if (choice == 0)
                {
                    return GenerateRandomString("ROOM", numCount + 1);
                }
                else if (choice == 1)
                {
                    return GenerateRandomString("KEY", numCount + 1) + GenerateRandomString("CONTENT", numCount + 1) + GenerateRandomString("LOCK", numCount + 1) + GenerateRandomString("CONTENT", numCount + 1);
                }
                else
                {
                    Console.WriteLine(numCount);
                    return GenerateRandomString("CONTENT", numCount + 1);
                }

            // terminals:
            case "ROOM":
                return "ROOM" + "->";
            
            case "KEY":
                return "KEY" + "->";
            
            case "LOCK":
                return "LOCK" + "->";

            default:
                return "";
        }
    }
}
