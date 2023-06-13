        Console.Write("Введите число A =");
        string inputedStringA = Console.ReadLine();
        Console.Write("Введите число B =");
        string inputedStringB = Console.ReadLine();

        int namberA = Convert.ToInt32(inputedStringA);
        Console.WriteLine($"Вы ввели число {namberA}!");
        int namberB = Convert.ToInt32(inputedStringB);
        Console.WriteLine($"Вы ввели число {namberB}!");

        if (namberA > namberB )
        {
            Console.WriteLine($"Число  {namberA} ,больше {namberB}");
        }
        else
        {
            Console.WriteLine($"Число  {namberA} меньше {namberB}");
        }
