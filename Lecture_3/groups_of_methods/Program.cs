//Группы методов:

//Первая группа:
// не принимает никаких аргументов и ничего не возвращает

void Method1()
{
    Console.WriteLine("Автор ...");
}

//Вызов метода:
Method1();

//Вторая группа:
//Принимает аргументы, но ничего не возвращает

void Method2(string str)
{
    Console.WriteLine(str);
}
//Вызов метода:
Method2("Текст сообщения");

//или

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Вызов метода:
Method21(msg: "Text", count: 4); //count показывает сколько раз выводить текст

//Третья группа:
//Может что-то возвращать, но ничего не принимает.
//Например, вывод рандомных чисел или:

int Method3()
{
    return DateTime.Now.Year;
}
//Вызов метода:
int year = Method3();
Console.WriteLine(year);

//Четвертая группа:
//Что-то принимает (аргумент, данные) и что-то возвращает.

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; //String.Empty - пустая строка, можно было записать как: "" 
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "asdf "); //склеивание текста 10 раз
Console.WriteLine(res);

