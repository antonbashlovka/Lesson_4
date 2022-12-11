/*
Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Не использовать функцию Math.Pow
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/


int baseNumber;
int expNumber;
int i;


int inputNumber (string message){
    int res;
    string number;
    Console.WriteLine(message);
    number = Console.ReadLine();
    while (int.TryParse(number, out res) == false){
        Console.WriteLine("Ошибка. Вы ввели текст, необходимо число. Попробуйте еще раз");
        number = Console.ReadLine();   
    }
    return res;
}

baseNumber = inputNumber ("Введите число для возведения в степень");
expNumber = inputNumber ("Введите показатель степени");

int res = baseNumber;

for (i = 1; i < expNumber; i++)
{
    res = res * baseNumber;
}

Console.WriteLine("результат " + res);