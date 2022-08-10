Console.WriteLine("Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");

var num = 0;
var str = "";

while(true) {
Console.WriteLine("Введите любое число: ");
str = Console.ReadLine();
if(int.TryParse(str, out int number)) {
    num = number;
    if(str.Length < 3) {
        Console.WriteLine("Третьей цифры у числа " + num + " нет!");
        break;
    }
    else {
        Console.WriteLine("Третья цифра числа " + num + ": " + str[2]);
        break;
    }
}
else Console.WriteLine("Некорректно введено число!");
}
