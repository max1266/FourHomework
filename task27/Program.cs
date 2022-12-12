Console.Clear();
int a = Convert.ToInt32(Console.ReadLine());
int resultt = 0;
while(a >10 )
{
    resultt = resultt + (a%10);
    a = a/10;
}
resultt = resultt + a;
Console.WriteLine(resultt);


