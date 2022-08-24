Console.WriteLine ("Введите цифру, обозначающую день недели");
int num1 = int.Parse(Console.ReadLine());
if(num1 == 6 || num1 == 7)
{
Console.Write("да");
}
    else if(0 < num1 && num1 < 6 )
    {
    Console.Write("нет");
    }
else
{
Console.Write("Число не соответствует входным параметрам");
}