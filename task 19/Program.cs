
int testFor5Simb()                         //получаем число и проверяем его.
{
    int number;
    while (true)
    {

        System.Console.WriteLine("Введите пятизначное, положительное число: ");
        number = Convert.ToInt32(Console.ReadLine());
        if (number < 10000 || number > 99999)
        {
            System.Console.WriteLine("Ошибка! Только Пятизначные числа!");
        }
        else break;
    }
    return number;
}

string Reverse(string word)                //разворачиваем предварительно переводим число в строку.
{
    string result = string.Empty;
    int i = word.Length - 1;
    while (i > -1)
    {
        result += word[i];
        i--;
    }
    return result;
}

int num = testFor5Simb();

string rev = Reverse(Convert.ToString(num));

if (rev == Convert.ToString(num)) //сравниваем изначальное с развернутым
{
    System.Console.WriteLine("Введенное число палиндром");
}
else System.Console.WriteLine("Введенное число  не палиндром");

System.Console.WriteLine(rev);


