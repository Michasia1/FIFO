using System;

namespace FIFO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rozmiar kolejki");
            int n = int.Parse(Console.ReadLine());
            Kolejka kolejka = new Kolejka(n);
            Console.Clear();
            while (true)
            {
                Console.WriteLine("1 - Dodaj");
                Console.WriteLine("2 - Zdejmij");
                Console.WriteLine("3 - Wypisz kolejke");
                switch (Console.ReadLine())
                {
                    case "1":
                        try
                        {
                            
                            Console.WriteLine("Podaj liczbe do dodania: ");
                            int a = int.Parse(Console.ReadLine());
                            kolejka.Dodaj(a);
                        }
                        catch(FullQueueException ex)
                        {
                            Console.WriteLine(ex.Message);
                            Console.WriteLine(ex.StackTrace);
                            Console.ReadKey();

                        }
                        catch (UnsupportedQueueArgument ex)
                        {
                            Console.WriteLine(ex.Message);
                            Console.ReadKey();
                            goto case "1";
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            Console.WriteLine(ex.StackTrace);
                        }
                        break;
                    case "2":
                        try
                        {
                            int b = kolejka.Zdejmij();
                            Console.WriteLine("zdjeta liczba to: " + b);
                            Console.ReadKey();
                            
                        }
                        catch(EmptyQueueException ex)
                        {
                           // Console.WriteLine(ex.Message);
                            Console.WriteLine(ex.StackTrace);
                            return;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            Console.WriteLine(ex.StackTrace);
                        }
                        break;
                    case "3":
                        kolejka.PrintQueue();
                        Console.ReadKey();
                        break;

                }
                Console.Clear();
            }
        }
    }
}
