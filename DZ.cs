// // 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
// Console.Write("Введите трёхзначное число: ");
// int numberUser = Convert.ToInt32(Console.ReadLine());
// if (numberUser >=100 && numberUser <1000)
// {
//     int secondDigital = (numberUser % 100 - numberUser % 10) / 10;
//     Console.WriteLine($"В числе {numberUser} -> {secondDigital} вторая цифра");
// }
// else
//     Console.Write($"Число {numberUser} не трёхзначное");

// // 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. До 10 символов
Console.Write("Введите число, содержащее до 10 символов: ");
string? numberUser = Console.ReadLine();
int numberint;
bool number = int.TryParse(numberUser, out numberint);
if (number)
{
    if (numberUser.Length <= 2)
    {
        Console.WriteLine($"В числе {numberUser} нет третьей цифры");
    }
    if (numberUser.Length > 2)
    {
        Console.WriteLine($"В числе {numberUser} третья цифра {numberUser[2]}");
    }
}
else
{
    Console.WriteLine("Требуется ввести число");
}

// // 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
// Console.Write("Введите число дня недели, чтобы проверить выходной это или нет: ");
// int numberDay = Convert.ToInt32(Console.ReadLine());
// if (numberDay <= 5)
// {
//     Console.WriteLine($"Нет, {numberDay} день недели является рабочим днём");
// }
// if (numberDay > 5 && numberDay <=7)
// {
//     Console.WriteLine($"Да, {numberDay} день недели является выходным днём");
// }
// if (numberDay > 7)
// {
//     Console.WriteLine("В неделе только 7 дней, пожалуйста, придерживайтесь этого диапозона");
// }

// Доп. Назовём число «интересным» если его произведение цифр делится на их сумму БЕЗ остатка. Напишите программу, 
// которая заполняет массив на 10 «интересных» случайных целых чисел от 10 до 1000(999 - последнее). (каждый эл-т массива – сгенерирован случайно)
// int Number = new Random().Next(10, 1000); 
// int firstDigital =  Number / 100;
// int secondDigital = (Number % 100 - Number % 10) / 10;
// int thirdDigital = (Number % 10);
// int unusialNumber = (firstDigital * secondDigital * thirdDigital) % (firstDigital + secondDigital + thirdDigital);
// if (unusialNumber==0)
// {
//     int [] unusialNumbers = new int [10] {unusialNumber, unusialNumber, unusialNumber, unusialNumber, unusialNumber, unusialNumber,unusialNumber, unusialNumber, unusialNumber, unusialNumber};
//     // void unusialNumbers(int[] collection) 
//     // {
//     //     int length = collection.Length;
//     //     int index = 0;
       
//     //     while (index < length)
//     //     {
//     //         collection[index] = new Random().Next(1, 1000);
//     //         index++;

//     //     }
//     // }
//    Console.WriteLine("[{0}]", string.Join(", ", unusialNumbers));
// }