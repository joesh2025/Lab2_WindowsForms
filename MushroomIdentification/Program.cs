using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("========== PROBLEM 2 ==========");
        Console.WriteLine("Mushroom identification");
        Console.WriteLine();
        Console.WriteLine("Think of one of these mushrooms:");
        Console.WriteLine("  Agaric jaunissant");
        Console.WriteLine("  Amanite tue-mouches");
        Console.WriteLine("  Cepe de Bordeaux");
        Console.WriteLine("  Coprin chevelu");
        Console.WriteLine("  Girolle");
        Console.WriteLine("  Pied bleu");
        Console.WriteLine();
        Console.WriteLine("Answer yes or no. At most three questions will be asked.");
        Console.WriteLine();

        string mushroom = IdentifyMushroom();

        Console.WriteLine();
        Console.WriteLine("Your mushroom is: " + mushroom);
        Console.WriteLine();
        Console.Write("Press Enter to close.");
        Console.ReadLine();
    }

    static string IdentifyMushroom()
    {
        bool growsInForest = AskYesNo("Does your mushroom grow in a forest?");

        if (!growsInForest)
        {
            bool convexCup = AskYesNo("Does your mushroom have a convex cup?");
            if (convexCup)
                return "Agaric jaunissant";

            return "Coprin chevelu";
        }

        bool convexCupInForest = AskYesNo("Does your mushroom have a convex cup?");
        if (convexCupInForest)
        {
            bool hasRing = AskYesNo("Does your mushroom have a ring?");
            if (hasRing)
                return "Amanite tue-mouches";

            return "Pied bleu";
        }

        bool hasGills = AskYesNo("Does your mushroom have gills?");
        if (!hasGills)
            return "Cepe de Bordeaux";

        return "Girolle";
    }

    static bool AskYesNo(string question)
    {
        while (true)
        {
            Console.Write(question + " (yes/no): ");
            string answer = (Console.ReadLine() ?? "").Trim().ToLower();

            if (answer == "yes")
                return true;
            if (answer == "no")
                return false;

            Console.WriteLine("Please answer yes or no.");
        }
    }
}
