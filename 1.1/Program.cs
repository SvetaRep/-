// Напишите программу, которая принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Enter a five-digit number ");
int x=Convert.ToInt32(Console.ReadLine());
int x1=x;
while (x1<10)  x1=x1/10;
int x2=x%10;
int x3=x/1000;
x3=x3%10;
int x4=x%100;
x4/=10;
if (x1==x2^x3==x4) Console.WriteLine("Palindrome true");
else Console.WriteLine("Palindrome false");
