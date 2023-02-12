// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int InputNumbers(string str) 
{
    int numbers;
    string? text;
    while (true)
    {
        Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out numbers))
        {
           while (numbers < 0)
            {
                System.Console.WriteLine("Число не можкет быть отрицательным");
                System.Console.WriteLine("Введите число повторно: ");
                numbers = Convert.ToInt32(Console.ReadLine());
            }
            break;
        }

        else
        {
            Console.WriteLine("Ошибка!!! Введено не верное значение!");
        }
    }
    return numbers;
}

int Akerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return Akerman(m - 1, 1);
    }
    if (m > 0 && n > 0)
    {
        return Akerman(m - 1, Akerman(m, n - 1));
    }
    return 0;
}

int numbersm = InputNumbers("Введите число M: ");
int numbersn = InputNumbers("Введите число N: ");
int n = Akerman(numbersm, numbersn);
System.Console.WriteLine(n);
