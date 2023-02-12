// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int InputNumbers(string str) //проверка введенного числа в размер массива
{
    int numbers;
    string? text;
    while (true)
    {
        Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out numbers))
        {
            break;
        }

        else
        {
            Console.WriteLine("Ошибка!!! Введено не верное значение!");
        }
    }
    return numbers;
}


int Numbers(int M, int N)
{
    {

        if (M == N)
        {
            return M;
        }
        if (M < N)
        {
            return N + Numbers(M, N - 1);
        }
        else
        {
            return N + Numbers(M, N + 1);
        }
    }
}

int numbersm = InputNumbers("Введите число M: ");
int numbersn = InputNumbers("Введите число N: ");
int j = Numbers(numbersm, numbersn);
System.Console.WriteLine($"сумму натуральных элементов в промежутке от {numbersm} до {numbersn} = {j}");
