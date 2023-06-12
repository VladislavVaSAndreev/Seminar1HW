Console.WriteLine("Напишите число");
string input_string1 = Console.ReadLine();
int number1 = Convert.ToInt32(input_string1);
if (number1%2 == 0)
{
    Console.WriteLine($"Число {number1} является четным");

}
else
{
    Console.WriteLine($"Число {number1} не является четным");
}