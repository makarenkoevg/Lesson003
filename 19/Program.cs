// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число:");
int num = int.Parse(Console.ReadLine());
num = Math.Abs(num);
if (num<10000 || num>99999)
{
     Console.WriteLine("Число должно быть пятизначное!");
}
else
{
    int number1 = num/10000;
    int number2 = num/1000%10;
    int number4 = num/10%10;
    int number5 = num%10;
    
    if(number1==number5&&number2==number4) Console.WriteLine("Число является полиандром");
    else Console.WriteLine("Число не является полиандром");
}