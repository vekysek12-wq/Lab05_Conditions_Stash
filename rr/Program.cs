//№1

// string password = "ret";
// string r = Console.ReadLine();

// if (password == r)
// {
//     Console.WriteLine("Пароль принят");
// }
// else
// {
//     Console.WriteLine("Пароль не принят");
// }


//№2
// int age = int.Parse(Console.ReadLine());

// if (age >= 18)
// {
//     Console.WriteLine("Доступ разрешен");
// }
// else
// {
//     Console.WriteLine("Доступ запрещен");
// }


//№3
// double a = double.Parse(Console.ReadLine());
// double b = double.Parse(Console.ReadLine());
// string op = Console.ReadLine();

// double result = 0;

// switch (op)
// {
//     case "+":
//         result = a + b;
//         break;
//     case "-":
//         result = a - b;
//         break;
//     case "":
//         result = a * b;
//         break;
//     case "/":
//         result = a / b;
//         break;
//     default:
//         Console.WriteLine("Неизвестная операция");
//         return;
// }
// Console.WriteLine($"{a} {op} {b} = {result}");

// №4
// int a = int.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());
// int c = int.Parse(Console.ReadLine());

// int sum = 0;

// if (a > 0) sum += a;
// if (b > 0) sum += b;
// if (c > 0) sum += c;

// Console.WriteLine(sum);


// №5
// Console.WriteLine("Тёмный Лабиринт");
//         Console.WriteLine("A - дракон, B - тёмный коридор");
//         string choice = Console.ReadLine();

// if (choice == "A" || choice == "a")
// {
//     Console.WriteLine("Загадка дракона: весит груша нельзя скушат ");
//     string answer = Console.ReadLine();

//     if (answer == "груша")
//         Console.WriteLine("Верно! Дракон пропускает вас.");
//     else
//         Console.WriteLine("Неверно! Дракон вас съел.");
// }
// else if (choice == "B" || choice == "b")
// {
//     Console.WriteLine("Дверь 1 - сокровища, Дверь 2 - ловушка");
//     string door = Console.ReadLine();

//     if (door == "1")
//         Console.WriteLine("Вы нашли сокровища! Победа!");
//     else
//         Console.WriteLine("Ловушка! Вы погибли.");
// }
// else
// {
//     Console.WriteLine("Неверный выбор.");
// }