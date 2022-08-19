
int[] arr = new int[8];

Console.WriteLine("Введите 8 (восемь) целых чисел для создания массива");

for (int i = 0; i <arr.LongLength; i++)

{
    arr[i] = Convert.ToInt32(Console.ReadLine());

}

Console.WriteLine("Создали массив:");
Console.Write(string.Join(", ", arr));