// Является ли пятизначное число палиндромом?
Console.WriteLine("Введите пятизначное число");
int.TryParse (Console.ReadLine(), out int N);
int number1 = N / 10000;
int number2 = (N / 1000) % 10;
int number4 = (N%100) / 10;
int number5 = N % 10;
if ((number1 == number5) && (number2 == number4))
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не палиндром");
}

