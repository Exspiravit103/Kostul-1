using System.Text;


namespace Костыль__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание №1 на ввод данных для КГБ и товарища Майора)");
            Console.WriteLine("Введите ФИО");
            string fullname = Console.ReadLine().Trim();
            Console.WriteLine("Введите ваш возраст");
            int age = int.Parse(Console.ReadLine().Trim());
            Console.WriteLine("Введите ваш адрес(улица, дом, квартира)");
            string adress = Console.ReadLine().Trim();
            Console.WriteLine("Введите ваш номер телефона");
            string number_of_phone = Console.ReadLine().Trim();
            Console.WriteLine("Введите ваш рост");
            string height_in = Console.ReadLine().Trim();
            height_in = height_in.Replace(",", ".");
            double height_out = double.Parse(height_in);
            Console.WriteLine(fullname);
            Console.WriteLine(age);
            Console.WriteLine(adress);
            Console.WriteLine(number_of_phone);
            Console.WriteLine(height_out);
        }
    }
}
