/*
Задача 3: **(Дополнительное, не обязательно)
Назовём число «интересным» если его произведение цифр делится на их сумму. Напишите программу, 
которая заполняет массив на 10 «интересных» случайных целых чисел от 10 до 1000. 
(каждый эл-т массива – сгенерирован случайно)

[591, 532, 189, 523, 333, 546, 527, 275, 456, 264]
*/

void printArray(int[] arr){
    string res = "[";
    foreach (double value in arr ){
        res = res + Convert.ToString(value) + ", ";
    }
    res = res.TrimEnd(new Char[] {',', ' '}) + "]";

    Console.WriteLine(res);
}

int findSum(int intNumber){
    int sum = 0;
    while (intNumber > 0) {
        sum = sum + intNumber % 10;
        intNumber = intNumber / 10;
    }
    return sum;
}

int findProduct(int intNumber){
    int pro = 1;
    while (intNumber > 0) {
        pro = pro * (intNumber % 10);
        intNumber = intNumber / 10;
    }
    return pro;
}

bool notInteresting(int number){
    if (findProduct(number) % findSum(number) != 0){
        return true;
    }else{
        return false;
    }
}

int[] array = new int[10];
int i;
int value = 0;
Random rand = new Random();

for(i = 0;  i < 10; i++){
    do{
        value = rand.Next(10, 10000);
    }
    while (notInteresting(value)); // если не интересное число (не интересно == true) - цикл продолжает работать

    array[i] = value;
}

printArray(array);