// Напишите программу, которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N  
Console.WriteLine("Input an inger number");
int n = Convert.ToInt32(Console.ReadLine());
int index = 1;
for(int a = 1; a <= n; a++);
{
    index = (int)Math.Pow(a, 3);
}
Console.WriteLine(index + " ");