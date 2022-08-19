
Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());

int num3 = 0;
for (int num2 = 1; num1 >0; num2++)

{

    num3 = num3 + num1 % 10;
    num1 = num1 / 10;

}

Console.WriteLine($"Сумма цифр в числе составит {num3}");