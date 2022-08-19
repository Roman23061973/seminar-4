;
Console.WriteLine("Введите целое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int num2 = Convert.ToInt32(Console.ReadLine());

int num3 = 1;
for (int i = 1; i <=num2; i++)

{

    num3 = num3 * num1;

}

Console.WriteLine($"Если {num1} возвести в степень {num2}, получим {num3}");

