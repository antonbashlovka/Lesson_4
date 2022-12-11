/*
Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Не использовать функцию Math.Pow
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/


string number;
int baseNumber;
int expNumber;
int i;


Console.WriteLine("Введите число для возведения в степень");
number = Console.ReadLine();
while (int.TryParse(number, out baseNumber) == false){
    Console.WriteLine("Ошибка. Вы ввели текст, необходимо число. Попробуйте еще раз");
    number = Console.ReadLine();   
}

Console.WriteLine("Введите показатель степени");
number = Console.ReadLine();
while (int.TryParse(number, out expNumber) == false){
    Console.WriteLine("Ошибка. Вы ввели текст, необходимо число. Попробуйте еще раз");
    number = Console.ReadLine();   
}

int res = baseNumber;

for (i = 1; i < expNumber; i++)
{
    res = res * baseNumber;
}

Console.WriteLine("результат " + res);