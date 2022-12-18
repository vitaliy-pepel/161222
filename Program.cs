int inputNumber(string str)
{
    int number;
    string text;

    while (true)
    {
        System.Console.WriteLine(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}

int Pos(int m)
{
    int c = 0;
    for (int i = 0; i < m; i++)
    {   
        System.Console.Write($"Введите {i + 1}-е число: ");
        int numb = Convert.ToInt32(Console.ReadLine());
        if (numb > 0)
        {
            c += 1;
        }
    }
    return c;
}

double Equation_x(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double Equation_y(double b1, double k1, double dot_x)
{
    double y = k1 * dot_x + b1;
    return y;
}

int rep = 0;
while (rep == 0)
{
    Console.WriteLine("Выберите номер задания \n 1. Положительные числа в ряду \n 2. Точка пересечения прямых \n 0. Выход");
    Console.Write("Ввод: ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (n == 1)
    {
        int m = inputNumber("Сколько чисел будем вводить: ");
        int positive_num = Pos(m);
        System.Console.WriteLine($"Кол-во чисел больше нуля: {positive_num}");

        Console.WriteLine("____________");
    }
    else if (n == 2)
    {
        System.Console.Write("b1 = ");
        double b1 = Convert.ToDouble(Console.ReadLine());
        System.Console.Write("k1 = ");
        double k1 = Convert.ToDouble(Console.ReadLine());
        System.Console.Write("b2 = ");
        double b2 = Convert.ToDouble(Console.ReadLine());
        System.Console.Write("k2 = ");
        double k2 = Convert.ToDouble(Console.ReadLine());
        double dot_x = Equation_x(b1, k1, b2, k2);
        double dot_y = Equation_y(b1, k1, dot_x);
        System.Console.WriteLine($"Точка пересечения двух прямых: ({Math.Round(dot_x, 1)}; {Math.Round(dot_y, 1)})");

        Console.WriteLine("____________");
    }
    else if (n == 0)
    {
        Console.WriteLine(">>>>>>>>>>>>>>>>>>>> FLŰGGÅƏNK∂€ČHIŒβØL∫ÊN! <<<<<<<<<<<<<<<<<<<<");
        break;
    }
    else
    {
        rep = 0;
    }

    await Task.Delay(2000);
}