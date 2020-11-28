using System;

namespace YIE_Task_03
{
    class Program
    {

        public static int t = 3; // Кол-во попыток взято 3, для удобствa
        static void Main(string[] args)
        {

            string kesha1337 = "kesha1337"; // Пароль



            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Введите пароль: ");
                string password = Console.ReadLine();
                if (password == kesha1337)
                {

                    goto Finish_good;

                }

                else if (t == 0)
                {
                    goto Finish_bad;
                }
                else
                {

                    Console.WriteLine($"Пароль неверен, кол-во попыток: {t}");
                    t--;
                }



            }

        Finish_good:
            Console.WriteLine();
            Console.WriteLine("Пароль верен, Здравствуйте господин мы вас ждали \n");
            Console.ReadKey();
            Environment.Exit(0);

        Finish_bad:
            Console.WriteLine();
            Console.WriteLine("Вы превысили количество попыток  \n");
            Console.ReadKey();
            Environment.Exit(0);



        }
    }
}
