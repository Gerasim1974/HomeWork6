namespace appHomeWork6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sNumberPhone;
            string sModelPhone;
            double dWeightPhone;

            do
            {

                Console.WriteLine("Введите номер телефона");
                sNumberPhone = Console.ReadLine();
                Console.WriteLine("введите модель телефона");
                sModelPhone = Console.ReadLine();
                Console.WriteLine("Введите вес телефона");
                dWeightPhone = double.Parse(Console.ReadLine());
                Phone myPhone = new(sNumberPhone, sModelPhone, dWeightPhone);

                Console.WriteLine($"Ваш номер телефона {myPhone.Number}");
                Console.WriteLine($"Модель Вашего телефона {myPhone.Model}");
                Console.WriteLine($"Вес Вашего телефона {myPhone.Wheight}");

                Console.WriteLine("Введите имя");
                string sNameMan = Console.ReadLine();
                myPhone.ReciveCall(sNameMan);
                Console.WriteLine("Для выхода из программ нажмите ESC, для продолжения нажмите любую кнопку");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

        }
    }
}