/*
    Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    452 -> 11
    82 -> 10
    9012 -> 12
*/

int intNumber;

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

intNumber = inputNumber("Введите число для расчета суммы цифр в нем");

int sum = 0;

while (intNumber > 0) {
    sum = sum + intNumber % 10;
    intNumber = intNumber / 10;
}

Console.WriteLine(sum);