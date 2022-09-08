// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
double getNum()
{
Console.Write("Enter a coordinate A x1: ");
double x1=Convert.ToDouble(Console.ReadLine());
Console.Write("Enter a coordinate A y1: ");
double y1=Convert.ToDouble(Console.ReadLine());
Console.Write("Enter a coordinate A z1: ");
double z1=Convert.ToDouble(Console.ReadLine());
Console.Write("Enter a coordinate B x2: ");
double x2=Convert.ToDouble(Console.ReadLine());
Console.Write("Enter a coordinate B y2: ");
double y2=Convert.ToDouble(Console.ReadLine());
Console.Write("Enter a coordinate B z2: ");
double z2=Convert.ToDouble(Console.ReadLine());
double res=Math.Cbrt((x2-x1)*(x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1)*(z2-z1));
return res;
}

try 
{
Console.WriteLine(getNum());
}
catch 
{
    Console.WriteLine("invalid input");
}
