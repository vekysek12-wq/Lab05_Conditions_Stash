// // Console.WriteLine("Введите число: ");
// // int num = int.Parse(Console.ReadLine());
// // if (num > 0)
// // {
// //     Console.WriteLine("Число положительное.");
// // }
// // else if (num < 0)
// // {
// //     Console.WriteLine("Число отрицательное.");
// // }
// // else
// // {
// //     Console.WriteLine("Число равно нулю.");
// // }

// // Console.Write("Введите количество посещений (из 19): ");
// // int attendance = int.Parse(Console.ReadLine());

// // Console.Write("Введите средний балл по практике: ");
// // double practiceGpa = double.Parse(Console.ReadLine());

// // bool goodAttendance = attendance >= 14; // 
// // bool goodGrades = practiceGpa >= 3.0;   // 

// // if (goodAttendance && goodGrades) {
// //     Console.WriteLine("+ Допуск к экзамену разрешён.");
// // }
// // else if (!goodAttendance && goodGrades) {
// //     Console.WriteLine("- Недостаточно посещений. Нужно отработать пропуски.");
// // }
// // else if (goodAttendance && !goodGrades) {
// //     Console.WriteLine("- Низкий балл по практике. Нужно пересдать работу.");
// // }
// // else {
// //     Console.WriteLine("- Проблемы и с посещаемостью, и с оценками. Срочно к преподавателю.");
// // }

// // Console.Write("Введите ваш возраст: ");
// // int age = int.Parse(Console.ReadLine());
// // string ageGroup = age >= 18 ? "совершеннолетний" : "несовершеннолетний";
// // Console.WriteLine($"Вы {ageGroup}.");

// // Console.Write("\nВведите температуру за окном (°C): ");
// // double temp = double.Parse(Console.ReadLine());
// // string weather = temp >= 20 ? "тепло" : (temp >= 0 ? "прохладно" : "мороз");
// // Console.WriteLine($"За окном {weather}.");

// // Console.Write("\nВведите число: ");
// // int n = int.Parse(Console.ReadLine());
// // string parity = n % 2 == 0 ? "чётное" : "нечётное";
// // Console.WriteLine($"Число {n} — {parity}.");

// // if (day == 1) Console.WriteLine("Понедельник");
// // else if (day == 2) Console.WriteLine("Вторник");
// // else if (day == 3) Console.WriteLine("Среда");

// // switch (day)
// // {
// //     case 1: Console.WriteLine("Понедельник"); break;
// //     case 2: Console.WriteLine("Вторник"); break;
// //     case 3: Console.WriteLine("Среда"); break;
// //     default: Console.WriteLine("Неизвестный день"); break;
// // }

// // Console.WriteLine("Меню");
// // Console.WriteLine("1. Посмотреть расписание");
// // Console.WriteLine("2. Посмотреть оценки");
// // Console.WriteLine("3. Связаться с преподавателем");
// // Console.WriteLine("4. Выйти");
// // Console.Write("Выберите пункт (1-4): ");

// // string choice = Console.ReadLine();

// // switch (choice)
// // {
// //     case "1":
// //         Console.WriteLine("Расписание: ИСП-244, каб. 102, 08:30");
// //         break;
// //     case "2":
// //         Console.WriteLine("Ваши оценки: ИРСПО - 20, РМП - 35,");
// //         break;
// //     case "3":
// //         Console.WriteLine("Email: denis.leontev92@yandex.ru");
// //         break;
// //     case "4":
// //         Console.WriteLine("До свидания!");
// //         break;
// //     default:
// //         Console.WriteLine($"Ошибка: пункт «{choice}» не существует. Введите число от 1 до 4.");
// //         break;
// // }

// Console.Write("\nВведите номер дня недели (1-7): ");
// int dayNumber = int.Parse(Console.ReadLine());

// switch (dayNumber)
// {
//     case 1:
//     case 2:
//     case 3:
//     case 4:
//     case 5:
//         Console.WriteLine("Рабочий день - пора учится!");
//         break;
//     case 6:
//     case 7:
//         Console.WriteLine("Выходной - отдых");
//         break;
//     default:
//         Console.WriteLine("Такого дня не существует");
//         break;
// }

Random random = new Random();
int secret = random.Next(1, 101);

int attempts = 0;
bool guessed = false;

Console.WriteLine("Угадай число (1-100)");
Console.WriteLine("Я загадал число. Попробуй угадать!");

while (!guessed)
{
    Console.Write("Введите число: ");
    string input = Console.ReadLine();

    if (!int.TryParse(input, out int guess))
    {
        Console.WriteLine("!!! Введите корректное число!");
        continue;
    }

    if (guess < 1 || guess > 100)
    {
        Console.WriteLine("!!! Число должно быть от 1 до 100!");
        continue;
    }

    attempts++;

    if (guess < secret)
    {
        int diff = secret - guess;
        string hint = GetHint(diff);
        Console.WriteLine($"↑ Больше! {hint}\n");
    }
    else if (guess > secret)
    {
        int diff = guess - secret;
        string hint = GetHint(diff);
        Console.WriteLine($"↓ Меньше! {hint}\n");
    }
    else
    {
        guessed = true;
    }
}

string result = attempts <= 7
    ? $"Отличный результат! Всего {attempts} попыток."
    : $"Число найдено за {attempts} попыток. Можно лучше!";

Console.WriteLine($"🎉 Правильно! Загаданное число: {secret}");
Console.WriteLine($"{result}");

string GetHint(int diff)
{
    switch (diff)
    {
        case <= 3:
            return "🔥 Горячо!";
        case <= 10:
            return "🌡 Тепло";
        case <= 20:
            return "❄ Прохладно";
        default:
            return "🧊 Холодно";
    }
}