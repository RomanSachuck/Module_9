using System;

namespace Task2
{
    internal class Program
    {
        private delegate void myDelegate(int i, string[] s);
        private static event myDelegate pressing1or2 = MySort;

        static void MySort(int direction, string[] surnames)
        {
            if (direction == 1)
                Array.Sort(surnames);
            if (direction == 2)
                Array.Sort(surnames, (x, y) => y.CompareTo(x));
        }
        static void Main(string[] args)
        {
            string[] surnames =
            {
                "Янукович",
                "Бибка",
                "Савенко",
                "Путин",
                "Иванов"
            };

            while (true)
            {
                string key = Console.ReadLine();
                int direction = 0;

                try
                {
                    if (!int.TryParse(key, out direction))
                        throw new MyException("Это не число!");
                }
                catch (MyException ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }

                if (direction == 1 || direction == 2)
                {
                    pressing1or2.Invoke(direction, surnames);
                }
                else
                {
                    Console.WriteLine("Неверное число!");
                    continue;
                }    
                foreach (string s in surnames)
                    Console.WriteLine(s);
            }
        }
    }
}
