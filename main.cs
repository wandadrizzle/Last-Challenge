using System;
using System.Collections.Generic;
using System.Linq; //Need this to use the keys.ToArray() method

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Wanda's Cafe!\nAs the barista you can type today's discount and the system will print out the menu with the discounted prices.\n\n");
        Console.Write("What's today's discount[%]? ");
        int discount = Convert.ToInt32(Console.ReadLine());
        //int discount = 10;

        Dictionary<string, double> coffee = new Dictionary<string, double>();
        coffee.Add("Americano", 50);
        coffee.Add("Latte", 70);
        coffee.Add("Flat White", 60);
        coffee.Add("Espresso", 60);
        coffee.Add("Cappuccino", 80);
        coffee.Add("Mocha", 90);
        //KeyValuePair<string, string> kvp in myDictionary
        foreach (KeyValuePair<string, double> kvp in coffee)
        {
            double discountedValue = kvp.Value - (kvp.Value * ((double)discount / 100));
            Console.WriteLine("{0}: {1}", kvp.Key, discountedValue);
        }
/*
        //Challenge - reimplement using coffee.Keys.ToArray()
        Console.WriteLine("\nLet's try to do this again!");
        string[] keys = coffee.Keys.ToArray(); //A temporary list of sorts
        foreach (string key in keys)
        {
            double discountedValue = coffee[key] - (coffee[key] * ((double)discount / 100));
            Console.WriteLine("{0}: {1}", key, discountedValue);
        }
        Console.WriteLine("\nONE MORE TIME!!");
        for (int i = 0; i < keys.Length; i++)
        {
            double discountedValue = coffee[keys[i]] - (coffee[keys[i]] * ((double)discount / 100));
            Console.WriteLine("{0}: {1}", keys[i], discountedValue);
        }
*/
    }
}

/*
When I first tried this I used what I thought was the best way from a quick microsoft learn read: https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=net-8.0
I thereafter read the question specs and changed my approach
*/