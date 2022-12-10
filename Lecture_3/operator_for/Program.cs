//Пример цикла:

string Method4(int count, string text)
{
    //int i = 0;
    string result = String.Empty; //String.Empty - пустая строка, можно было записать как: "" 
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    //while (i < count)
    //{
    //    result = result + text;
    //    i++;
    //}
    return result;
}

string res = Method4(10, "asdf "); //склеивание текста 10 раз
Console.WriteLine(res);

//Цикл в цикле (таблица умножения):

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i}*{j}={i * j}");
    }
    Console.WriteLine();// для разрыва (пустой строки) между разными числами    
}


//задача 1: 
//Дан текст. В тексте нужно все пробелы заменить черточками, 
//маленькие буквы к заменить большими К, а большие С заменить маленькими с.

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

//string s = "qwerty"
//            012345
// s[3] есть r

string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty; //инициализация пустой строки
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replase(text, ' ', '|');
Console.WriteLine(newText);

newText = Replase(text, 'к', 'К');
Console.WriteLine(newText);