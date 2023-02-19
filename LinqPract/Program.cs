// 1. Создать список / массив который состоит из чисел второго списка, которых нет в первом.

var list1 = new List<int>() { 1, 3, 6, 7, 8, 0, 55 };
var list2 = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var res = list2.Except(list1);

// 2. Найти максимальное и минимальное число одного из массивов/списка.

var list3 = new List<int>() { 1, 3, 6, 7, 8, 0, 55 };
int min = list3.Min();  
int max = list3.Max();

// 3. Пользователь вводит число, твоя задача вывести ему, сколько раз оно повторяется.

var list4 = new List<int>() { 2, 6, 3, 5, 4, 2, 4, 6, 6, 7, 8, 7, 9, 0, 2 };
Console.WriteLine("Введите число:");
Console.WriteLine(int.TryParse(Console.ReadLine(), out int result) ? 
    $"Ваше число повторяется {list4.Count(x => x == result)} раз." : "Error!"); 

// 4. У вас есть список городов. Нужно выбрать только те города, которые начинаются с буквы "K".

List<string> cities = new List<string>() { "Dnipro", "Kharkiv", "Odesa", "Lviv", "Zaporizhzhia", "Uzhhorod", "Pavlohrad", "Zhytomyr", "Poltava", "Vinnytsia", "Mykolaiv", "Cherkasy", "Chernivtsi", "Sumy", "Rivne", "Lutsk", "Kremenchuk", "Ternopil", "Nikopol", "Lysychansk", "Irpin", "Enerhodar", "Izium", "Varash", "Volodymyr", "Chuhuiv", "Khust", "Boryspil", "Yalta", "Berdiansk", "Luhansk", "Donetsk", "Kyiv" };
var citiesK = cities.Where(x => x.StartsWith("K"));

// 5. Выбрать только те города, чье название состоит из 5, либо меньше символов.

var citiesShortName = cities.Where(x => x.Length <= 5);

