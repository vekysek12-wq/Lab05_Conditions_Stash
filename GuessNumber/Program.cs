// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// if (num > 0)
// {
//     Console.WriteLine("Число положительное.");
// }
// else if (num < 0)
// {
//     Console.WriteLine("Число отрицательное.");
// }
// else
// {
//     Console.WriteLine("Число равно нулю.");
// }

Console.Write("Введите количество посещений (из 19): ");
int attendance = int.Parse(Console.ReadLine());

Console.Write("Введите средний балл по практике: ");
double practiceGpa = double.Parse(Console.ReadLine());

bool goodAttendance = attendance >= 14; // 
bool goodGrades = practiceGpa >= 3.0;   // 

if (goodAttendance && goodGrades) {
    Console.WriteLine("+ Допуск к экзамену разрешён.");
}
else if (!goodAttendance && goodGrades) {
    Console.WriteLine("- Недостаточно посещений. Нужно отработать пропуски.");
}
else if (goodAttendance && !goodGrades) {
    Console.WriteLine("- Низкий балл по практике. Нужно пересдать работу.");
}
else {
    Console.WriteLine("- Проблемы и с посещаемостью, и с оценками. Срочно к преподавателю.");
}