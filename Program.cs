Console.WriteLine("Введите трехзначное число:");
int number =Convert.ToInt32(Console.ReadLine());

if(number/100!=0&&number/1000==0)
{
    Console.WriteLine($"Вторая цифра равна {(number%100)/10}");
}
else
{
    Console.WriteLine("число не является трехзначным!");
}