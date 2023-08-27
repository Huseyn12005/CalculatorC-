static void Add(double num1, double num2)
{
    double result = num1 + num2;
    Console.WriteLine($"{num1} + {num2} = {result}");
}

static void Mult(double num1, double num2)
{
    double result = num1 * num2;
    Console.WriteLine($"{num1} * {num2} = {result}");
}

static void Div(double num1, double num2)
{
    double result = num1 / num2;
    Console.WriteLine($"{num1} / {num2} = {result}");
}

static void Subt(double num1, double num2)
{
    double result = num1 - num2;
    Console.WriteLine($"{num1} - {num2} = {result}");
}


string[] menu = { "Add", "Mult", "Div", "Subt" };
int choice_menu = 0;

do
{
    Console.Clear();

    Console.WriteLine();
    for (int i = 0; i < menu.Length; i++)
    {
        if (choice_menu == i)
        {
            Console.Write("                                                        ");
            Console.Write("-> ");
        }
        else
        {
            Console.Write("                                                        ");
            Console.Write("   ");
        }

        Console.WriteLine(menu[i]); ;
    }

    ConsoleKeyInfo choice = Console.ReadKey();

    switch (choice.Key)
    {
        case ConsoleKey.UpArrow:
            if (choice_menu == 0)
                choice_menu = 3;
            else
                --choice_menu;
            break;

        case ConsoleKey.DownArrow:
            if (choice_menu == 3)
                choice_menu = 0;
            else
                ++choice_menu;
            break;

        case ConsoleKey.Enter:
            Console.Clear();
            Console.Write("1ci ededi daxil edin: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2ci ededi daxil edin: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            if (choice_menu == 0)
                Add(num1, num2);

            else if (choice_menu == 1)
                Mult(num1, num2);

            else if (choice_menu == 2)
                Div(num1, num2);

            else if (choice_menu == 3)
                Subt(num1, num2);

            Console.ReadKey();
            break;



    }
    if (choice.Key == ConsoleKey.Escape)
        break;


} while (true);
