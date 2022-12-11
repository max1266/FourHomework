Console.Clear();
Console.WriteLine("введите первое число");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите второе число");
double b = Convert.ToDouble(Console.ReadLine());
double i = 0;
double result = 1;
while(i < b)
{
    result = result * a;
    i++;
}
Console.WriteLine(result);