
// Stores items names and prices
Dictionary<string, decimal> menu = new Dictionary<string, decimal>(StringComparer.OrdinalIgnoreCase)
{
    {"Breadsticks", 6.99m },
    {"Pizza", 7.99m },
    {"Salad", 4.50m },
    {"Fries", 2.99m },
    {"Soda", 2.50m },
    {"Cinnamonsticks", 5.99m },
    {"Italian Sub", 6.50m },
    {"Breadbowl", 5.50m }
};

// This list will hold the customer's order
List<string> shoppingList = new List<string>();

while (true)
{
    Console.WriteLine("Menu:");
    foreach (var item in menu)
    {
        Console.WriteLine($"{item.Key}: ${item.Value}");
    }

    Console.WriteLine("What would you like to order?");
    string input = Console.ReadLine();

    if (menu.ContainsKey(input))
    {
        shoppingList.Add(input);
        Console.WriteLine($"{input} added to your order for ${menu[input]}.");
    }
    else
    {
        Console.WriteLine("Sorry we don't have that item.");
        continue;
    }

    Console.WriteLine("Would you like to add another item? (yes/no): ");
    string output = Console.ReadLine().ToLower();

    if (output == "no")
    {
        break;
    }

    Console.WriteLine("Your Order:");
    decimal total = 0;

    foreach (string item in shoppingList)
    {
        decimal price = menu[item];
        Console.WriteLine($"{item}: ${price}");
        total += price;
    }
    Console.WriteLine($"Total: ${total}");
}