Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int second_digit = (number / 10) % 10;

Console.WriteLine(second_digit);
