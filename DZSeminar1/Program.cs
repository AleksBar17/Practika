Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2) 
{ 
    Console.WriteLine("большее число " + num1);
    Console.WriteLine("меньшее число " + num2);
}

else
{
    Console.WriteLine("большее число " + num2);
    Console.WriteLine("меньшее число " + num1);
}

