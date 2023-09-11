int num;
do
{
    Console.WriteLine("Какой ваш любимый цвет?");
    Console.WriteLine("1. Розовый");
    Console.WriteLine("2. Фиолетовый");
    Console.WriteLine("3. Салатовый");
    Console.WriteLine("4. Черный");
    Console.WriteLine("5. нкикакой выйди изх программы пж");

    string txt = Console.ReadLine();
    num = Convert.ToInt32(txt);
} while (num != 5);

