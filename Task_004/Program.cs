Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= number)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
        i++;
    }
    else
    {
        i++;
    }
}

//  for (int count = 2; count <= number; count += 2)
//  {
//   Console.Write($"{count}\t"); 