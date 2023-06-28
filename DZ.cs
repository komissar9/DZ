// 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
// Console.Write("Введите первое число: ");
// double firstDigit = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите второе число: ");
// double secondDigit = Convert.ToDouble(Console.ReadLine());
// if (firstDigit > secondDigit)
// {
//     Console.WriteLine("Число " + firstDigit + " больше числа " + secondDigit);
// }
// else
// {
//     Console.WriteLine("Число " + secondDigit + " больше числа " + firstDigit);
// }

//4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисе
// Console.Write("Введите первое число: ");
// double firstDigit = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите второе число: ");
// double secondDigit = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите третье число: ");
// double thirdDigit = Convert.ToDouble(Console.ReadLine());
// double max = firstDigit;
// if (max < secondDigit) max = secondDigit;
// if (max < thirdDigit) max = thirdDigit;
// Console.Write("Максимальное число: " + max);

//6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
// Console.Write("Введите число: ");
// double numberUser = Convert.ToDouble(Console.ReadLine());
// if (numberUser % 2 == 0)
//  {
//     Console.WriteLine("Число " + numberUser + " четное");
//  }
// else 
// {
//     Console.WriteLine("Число " + numberUser + " нечетное");
// }

//8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
// Console.Write("Введите число: ");
// int numberUser = Convert.ToInt32(Console.ReadLine());
// int evenDigit = 2;
// Console.WriteLine("Все четные числа до " + numberUser + ":");
// while (evenDigit < numberUser)
// {
//     Console.WriteLine(evenDigit);
//     evenDigit += 2;
// }
// 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
// 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. До 10 символов
// 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
// Доп. Назовём число «интересным» если его произведение цифр делится на их сумму БЕЗ остатка. Напишите программу, 
// которая заполняет массив на 10 «интересных» случайных целых чисел от 10 до 1000(999 - последнее). (каждый эл-т массива – сгенерирован случайно)