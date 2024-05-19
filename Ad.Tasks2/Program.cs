//// Task1

using System.Text;
Console.OutputEncoding = System.Text.Encoding.UTF8;

//Console.WriteLine("Введіть 3 будь-які цифри!");
//Console.WriteLine("Перша цифра: "); 
//var digit1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Друга цифра: ");
//var digit2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Третя цифра: ");
//var digit3 = Convert.ToInt32(Console.ReadLine());

//int result1 = digit1 + digit2 + digit3;
//int result2 = (digit1 + digit2 + digit3)/3;

//Console.WriteLine($"Сума: \n{result1}");
//Console.WriteLine($"Середнє значення: \n{result2}");

//Task2

//Console.WriteLine("Вартість ноутбуку: ");
//float cost = Convert.ToSingle(Console.ReadLine());
//Console.WriteLine("Кількість: ");
//int amount = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Відсоток знижки: ");
//int discount = Convert.ToInt32(Console.ReadLine());

//float totalcost = cost * amount;
//float discouncost = (totalcost / 100) * discount;
//float costwithdiscount = totalcost - discouncost;

//Console.WriteLine($"Сумма замовлення без знижки: \n{totalcost}");
//Console.WriteLine($"Сума знижки: \n{discouncost}");
//Console.WriteLine($"Сума замовлення зі знижкою: \n{costwithdiscount}");

////Task3

//float salary = 100;
//Console.WriteLine($"Фіксована зарплата за місяць($): \n{salary}");
//Console.WriteLine("Сума продаж за місяць ($): ");
//float sales = Convert.ToSingle(Console.ReadLine());
//float rate = (sales / 100) * 5;
//Console.WriteLine($"Відсоток від продажів ($): \n{rate}");
//float resultsalary = salary + rate;
//Console.WriteLine($"Підсумкова зарплата за місяць($): \n{resultsalary}");

////Task4
Console.WriteLine("Введіть розмір файлу в GB: ");
float gb = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Введіть швидкість підключення до Інтернету в bit: ");
double bit = Convert.ToDouble(Console.ReadLine());

double convertgbinbit = 1024 * 1024 * 1024;         // 1 гігабайт рівний 1024 мегабайтам, а 1 мегабайт рівний 1024 кілобайтам, а 1 кілобайт рівний 1024 байтам. 
//double sizeinbits = gb * 8 * Math.Pow(1024, 3);   // Альтернативний варіант, який знайшла, але який ми не вчили)) 
double sizeinbits = gb * 8 * convertgbinbit;         // значення "8" тому що  1 байт складається з 8 бітів 
double timeinsecond = sizeinbits / bit;

int hours = (int)timeinsecond / 3600;
int minutes = (int)((timeinsecond % 3600) / 60);
int seconds = (int)(timeinsecond % 60);

Console.WriteLine($"Час завантаження файлу: \n{hours} годин, {minutes} хвилин, {seconds} секунд");
