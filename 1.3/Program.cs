// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
void function()
{
  Console.Write("Enter number: ");
  int n=Convert.ToInt32(Console.ReadLine());
  for(int i=0;i<=n;i++)
  {
    Console.Write($"{i*i*i}, ");
  }
}
try
{
    function();
}
catch
{
    Console.WriteLine("Invalid input");
}
