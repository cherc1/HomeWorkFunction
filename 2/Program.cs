Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];
Random rnd = new Random();
for(int i = 0; i < size; i++)
{
    array[i] = rnd.Next(99,999);
}
void NumberOfEvenNumbers(int[] arr)
{
    int n = 0;
    int kol = 0;
    while(n < array.Length)
    {
        if(array[n] % 2 == 0)
        {
            kol++;
        }
        n++;
    }
    Console.WriteLine("Ответ: " + kol);
}

NumberOfEvenNumbers(array);
