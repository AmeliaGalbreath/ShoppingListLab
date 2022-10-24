bool runProgram = true;
double price = 0;

Dictionary<string, double> menu = new Dictionary<string, double>();
menu.Add("Strawberries", 3.49);
menu.Add("Red Grapes", 3.98);
menu.Add("Green Grapes", 3.98);
menu.Add("Lemon", 0.79);
menu.Add("Red Raspberries", 2.77);
menu.Add("Honeycrisp Apple", 0.89);
menu.Add("Avocado", 1.99);
menu.Add("Pineapple", 2.19);

List<string> ShoppingCart = new List<string>(); //list of keys

Console.WriteLine("Welcome to our local market!\n");
Console.WriteLine(String.Format("{0, -20} {1, -20}", "Item", "Price"));
Console.WriteLine("================================");
foreach (KeyValuePair<string, double> kvp in menu)
{
    Console.WriteLine(String.Format("{0,-20} ${1,-20}", kvp.Key, kvp.Value));
}
while (runProgram)
{


    while (true)
    {
        Console.WriteLine("\nWhich item would you like?");
        string item = Console.ReadLine();

        if (menu.ContainsKey(item)) //I forgot how to do the opposite of ToLower except for only one specific letter
        {
            price = menu[item];
            ShoppingCart.Add(item);
            Console.WriteLine($"{item} for ${price} has been added to your cart");
            break;
        }
        else
        {
            Console.WriteLine("Sorry, we do not have that.");
        }
    }

    while (true)
    {
        Console.WriteLine("\nWould you like to continue shopping? y/n:");
        string keepShopping = Console.ReadLine().ToLower().Trim();
        if (keepShopping == "y")
        {
            break;
        }
        else if (keepShopping == "n")
        {
            runProgram = false;
            break;
        }
        else
        {
            Console.WriteLine("That was not y/n");
        }
    }
}

Console.WriteLine("\nThanks for your order! \nHere's what you got:");
price = 0;
foreach (string itemName in ShoppingCart)
{

    price += menu[itemName];
    Console.WriteLine(String.Format("{0,-20} ${1,-20}", itemName, menu[itemName]));
}
Console.WriteLine("\nYour total is: $" + price);
