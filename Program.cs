// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// Console.Write("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// if (firstNumber > secondNumber)
// {
//     Console.WriteLine("Первовое число " + firstNumber + 
//                     " больше, а второе число " + secondNumber + " меньше");
// }
// else if (firstNumber < secondNumber)
// {
//     Console.WriteLine("Второе число " + secondNumber + 
//                     " больше, а первое число " + firstNumber + " меньше");
// }
// else
// {
//     Console.WriteLine("Первовое число " + firstNumber + 
//                     " равно, второму числу " + secondNumber);
// }



// Задача 4: Напишите программу, которая принимает на вход три числа
//  и выдаёт максимальное из этих чисел.

// Console.Write("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите третее число: ");
// int number3 = Convert.ToInt32(Console.ReadLine());

// int max = number1;


// if (number2 > max) max = number2;
// if (number3 > max) max = number3;


// Console.WriteLine("max = " + max);



// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number%2 == 0)
// {
//     Console.WriteLine("Число " + number + " четное");
// }
// else{
//     Console.WriteLine("Число " + number + " нечетное");
// }



// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());


if (N < 2) // если N включаем в диапазон, если нет, то <=
{
    Console.WriteLine("Нет четных четных чисел в диапазоне");
}
else
{
    int start = 2;
    while (start <= N) // если N не включаем, то <
    {
        Console.WriteLine(start);
        start += 2;
    }
}