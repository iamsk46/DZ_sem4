// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// System.Console.WriteLine("Введите число: ");
// string msg = System.Console.ReadLine();
// char[] array = msg.ToCharArray();
// int sum = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     sum += array[i];
// }

// System.Console.WriteLine(sum);


System.Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(System.Console.ReadLine());
int sum = 0;
while (N > 0)
{
    int num = N % 10;
    N = N / 10;
    sum = sum + num;
}
System.Console.WriteLine("Суммой является: " + sum);

