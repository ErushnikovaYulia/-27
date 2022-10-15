// Напишите функцию и запустите ее, которая на вход принимает
// число и выдает сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetSum(int S)
{
    int sum = 0;

    while (S > 0)
    {
        sum = sum + (S % 10);
        S = S / 10;
    }
    return sum;
}

Console.Clear();
Console.Write ("Введите число: ");
int N = int.Parse (Console.ReadLine ()!);
Console.WriteLine ($"Сумма цифр в числе {N} равна {GetSum(N)}. ");