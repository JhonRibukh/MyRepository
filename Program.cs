
bool q = false;



float first = 0;
float second = 0;

do
{
    char operation = '\0';
try
{
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("1. сложение");
Console.WriteLine("2. вычитание");
Console.WriteLine("3. умножение");
Console.WriteLine("4. деление");
Console.WriteLine("5. степень");
Console.WriteLine("6. квадратный корень");
Console.WriteLine("7. 1 процент от числа");
Console.WriteLine("8. факториал из числа");
Console.WriteLine("9. выход");
Console.Write("Укажите операцию: ");
operation = char.Parse(Console.ReadLine());
}
catch
{

Console.WriteLine("ошибка не верное значение");

}



switch (operation)
{
    case '1':

        try
        {
            Console.WriteLine("укажите 1 число");
        first = float.Parse(Console.ReadLine());
        Console.WriteLine("укажите 2 число");
        second = float.Parse(Console.ReadLine());
        Console.WriteLine("Сумма чисел составляет: " + (first + second));
        }
        catch
        {
         Console.WriteLine("ошибка не верное значение");
        }


            ; break;

    case '2':

        try
        {
            Console.WriteLine("укажите 1 число");
            first = float.Parse(Console.ReadLine());
            Console.WriteLine("укажите 2 число");
            second = float.Parse(Console.ReadLine());
            Console.WriteLine("Разность чисел составляет: " + (first - second));
        }
        catch
        {
            Console.WriteLine("ошибка не верное значение");
        }

        break;
           
        case '3':
            try
            {
                Console.WriteLine("укажите 1 число");
                first = float.Parse(Console.ReadLine());
                Console.WriteLine("укажите 2 число");
                second = float.Parse(Console.ReadLine());
                Console.WriteLine("Произзведдение чисел составляет: " + (first * second));
            }
            catch
            {

                Console.WriteLine("ошибка не верное значение");

            }

            ; break;

        case '4':
            try
            {
                Console.WriteLine("укажите 1 число");
                first = float.Parse(Console.ReadLine());
                Console.WriteLine("укажите 2 число");
                second = float.Parse(Console.ReadLine());
                Console.WriteLine("Частное чисел составляет: " + (first / second));




            }
            catch
            {

                Console.WriteLine("ошибка не верное значение");

            }

            ; break;
        case '5':
            try
            {

                Console.WriteLine("укажите 1 число");
                first = float.Parse(Console.ReadLine());
                Console.WriteLine("укажите 2 число");
                second = float.Parse(Console.ReadLine());  
                Console.WriteLine("Степень числа составляет: " + (Math.Pow(first, second)));


            }
            catch
            {

                Console.WriteLine("ошибка не верное значение");

            }

            ; break;
        case '6':
            try
            {
                Console.WriteLine("укажите 1 число");
                first = float.Parse(Console.ReadLine());
                Console.WriteLine("Квадратный корень числа составляет: " + (Math.Sqrt(first)));
                


            }
            catch
            {

                Console.WriteLine("ошибка не верное значение");

            }

            ; break;
        case '7':
            try
            {
                Console.WriteLine("укажите 1 число");
                first = float.Parse(Console.ReadLine());
                Console.WriteLine("1 процент числа составляет: " + (first * 1 / 100));




            }
            catch
            {

                Console.WriteLine("ошибка не верное значение");

            }

            ; break;

        case '8':
            try
            {
                int a = 0;
                int i = 1;
                
                Console.WriteLine("укажите 1 число");
                a = int.Parse(Console.ReadLine());
                int b = a;
                a = a - 1;
                for (i = 1; i <= a;)
                {
                    b = b * i;
                    i = i + 1;
 
                }
                Console.WriteLine("факториал чисел" + b);



            }
            catch
            {

                Console.WriteLine("ошибка не верное значение");

            }

            ; break;

        case '9': q = true; break;
    }

}
while (!q);

Console.WriteLine("окончание работы");