Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];
Random rnd = new Random();
for(int i = 0; i < size; i++)
{
    array[i] = rnd.Next(1, 10);
    Console.Write($"{array[i]} ");
}
void FlipOver(int [] arr)
{
    int size2 = arr.Length;
    int [] arr2 = new int[size2];
    int i = 0;
    while (i < size2)
    {
        arr2[i] = arr[size2 - i];
    }
    i++;
    Console.Write($"Ответ: {arr2[i]} ");
}
FlipOver(array);
