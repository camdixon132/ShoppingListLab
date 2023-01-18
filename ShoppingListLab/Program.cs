

bool againItem = true;
bool ValidItem = true;

Dictionary<string, decimal> Menu = new Dictionary<string, decimal>();
Menu.Add("milk", 2.99m);
Menu.Add("bread", 4.99m);
Menu.Add("eggs", 7.99m);
Menu.Add("bacon", 8.69m);
Menu.Add("sausage", 8.50m);
Menu.Add("yogurt", 12.75m);
Menu.Add("potatoes", 11.69m);
Menu.Add("olives", 5.99m);




List<string> ShoppingList = new List<string>();

foreach(KeyValuePair<string, decimal> kvp in Menu)
{
    Console.WriteLine($"{kvp.Key}: ${kvp.Value}");
}


do
{
        Console.WriteLine("Please enter a name");
    string choice = Console.ReadLine();
    string Choice = choice.ToLower();

   
        if (Choice == "milk" || Choice == "bread" || Choice == "eggs" || Choice == "bacon" || Choice == "sausage" ||
            Choice == "yogurt" || Choice == "potatoes" || Choice == "olives")
        {
            decimal price = Menu[choice];
            Console.WriteLine("Adding " + Choice + " to cart at $" + price);
            ShoppingList.Add(Choice);        
        }
        else
        {
            Console.WriteLine("Sorry, we don't have that");
            foreach (KeyValuePair<string, decimal> kvp in Menu)
            {
                Console.WriteLine($"{kvp.Key}: ${kvp.Value}");
            }
        }
    
    Console.WriteLine("Would you like to add another?");
    string another = Console.ReadLine();
    if (another == "yes" || another == "y")
    {
        againItem = true;
    }
    else
    {
        againItem = false;
    }
} while (againItem == true);

Console.WriteLine("Ok, here is your total bill");
foreach(string items in ShoppingList)
{
    Console.WriteLine($"{items} {Menu[items]}");
}


decimal TotalPrice = 0;
foreach(string items in ShoppingList)
{
    TotalPrice += Menu[items];
}
//TotalPrice = TotalPrice.Substring(0, TotalPrice.Length - 1);
Console.WriteLine($"{TotalPrice}");
