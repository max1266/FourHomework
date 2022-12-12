Console.Clear();
Console.WriteLine("введите число");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];
for(int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите {i+1} число");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"[{String.Join(", ", array)}]");
