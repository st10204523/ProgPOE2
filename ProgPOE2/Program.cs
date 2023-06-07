using ProgPOE2;
{
    Recipe recipe = new Recipe();
    bool running = true;


    while (running) // creation of the menu display, of which the user will see
    {
        Console.WriteLine("Please select an option: ");

        Console.WriteLine("1. Please enter your recipe details: ");

        Console.WriteLine("2. Display the recipe captured: ");

        Console.WriteLine("3. Scale your recipe: ");

        Console.WriteLine("4. Reset all quantities that have been captured: ");

        Console.WriteLine("5. Clear all data captured: ");

        Console.WriteLine("6. Exit");

        Console.Write("Option: ");

        string input = Console.ReadLine();
        Console.WriteLine();

        switch (input) // switch statement to test the values from the lists
        {
            case "1":
                recipe.EnterDetails();
                break;
            case "2":
                recipe.Display();
                break;
            case "3":
                recipe.Scale();
                break;
            case "4":
                recipe.ResetQuantities();
                break;
            case "5":
                recipe = new Recipe();
                break;
            case "6":
                running = false;
                break;
            default:
                Console.WriteLine("YOUR SELECTION IS INVALID, PLEASE SELECT A VALID OPTION");
                break;

        }

        Console.WriteLine();
    }

}