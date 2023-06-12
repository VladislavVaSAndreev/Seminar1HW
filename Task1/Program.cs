Console.WriteLine("Напишите первое число");
string input_string1 = Console.ReadLine();
Console.WriteLine("Напишите второе число");
string input_string2 = Console.ReadLine();
int number1 = Convert.ToInt32(input_string1);
int number2 = Convert.ToInt32(input_string2);
if (number2 > number1)
{
    Console.WriteLine($"Число {number2} является Max, {number1} является Min");

}
else
{
    Console.WriteLine($"Число {number1} является Max, {number2} является Min");
}