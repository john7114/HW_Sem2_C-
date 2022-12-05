Console.WriteLine("Введите число: ");
string a = Console.ReadLine();

int no_third_digit = Convert.ToInt32(a);

if (no_third_digit < 99) 
{
    Console.WriteLine("Третьей цифры нет");
}
int third_digit = (int)Char.GetNumericValue(a[2]);

Console.WriteLine(third_digit);
