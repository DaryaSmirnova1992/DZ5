Console.WriteLine ("Введите число");
int num1 = int.Parse(Console.ReadLine());
if(num1 > 99)
{
    string str = num1.ToString();
    Console.WriteLine(str[2]);
}
else
{
    Console.Write("Нет третьей цифры");
}