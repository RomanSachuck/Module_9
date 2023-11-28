using System;

namespace Task1
{
    internal class Program
    {
        static void ThrowExeptions(Exception exeption)
        {
            try
            {
                throw exeption;
            }
            catch (ArgumentNullException ex)
            {

                Console.WriteLine(ex.Message + "\n");
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message + "\n");
            }
            catch (DivideByZeroException ex)
            {

                Console.WriteLine(ex.Message + "\n");
            }
            catch (IndexOutOfRangeException ex)
            {

                Console.WriteLine(ex.Message + "\n");
            }
            catch (MyException ex)
            {

                Console.WriteLine(ex.Message + "\n");
            }
        }
        static void Main(string[] args)
        {
            Exception[] exceptions = {
                new ArgumentNullException("Аргумент, передаваемый в метод — null."),
                new ArgumentException("Непустой аргумент, передаваемый в метод, является недопустимым."),
                new DivideByZeroException("Знаменатель в операции деления или целого числа Decimal равен нулю."),
                new IndexOutOfRangeException("Индекс находится за пределами границ массива или коллекции."),
                new MyException("Свой тип исключения.")};

            for (int i = 0; i < exceptions.Length; i++)
            {
                ThrowExeptions(exceptions[i]);
            }  
        }
    }
}
