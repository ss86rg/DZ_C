﻿Console.WriteLine("введите целое положительное число");
string input_string1 = Console.ReadLine();
int namber1 = Convert.ToInt32(input_string1);
int namber2 = namber1;
while (namber2 <= 20)
{
    Console.WriteLine($"{namber2}");
    namber2=namber2+1;
}