Console.WriteLine ("Введите трехзначное число");
int num1 = int.Parse(Console.ReadLine());
if(99 < num1 && num1 < 1000)
{
    int dec = ( num1 - (num1 / 100) * 100 ) / 10;
    Console.Write(dec);
}
else
{
    Console.Write("Fatal error! Введено не трехзначное число!");
}