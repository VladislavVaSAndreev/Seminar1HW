Console.WriteLine("Напишите число");
string input_string1 = Console.ReadLine();
int number1 = Convert.ToInt32(input_string1);
int number2 = 2;
while (number2 <= number1)
{   
    Console.Write(number2);
    number2++;
    number2++;
}
