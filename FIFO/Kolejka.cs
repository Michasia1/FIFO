using System;
using System.Collections.Generic;
using System.Text;

namespace FIFO
{
    public class Kolejka
    {
        private int[] tab;
        private int indeks;

        public Kolejka(int n)
        {
            tab = new int[n];
            indeks = 0;

        }
        public void Dodaj(int a)
        {
            if(a<0)
            {
                throw new UnsupportedQueueArgument(a);
            }
            else if (indeks >= tab.Length)
            {
                throw new FullQueueException();
            }
            else
            {
                tab[indeks++] = a;
            }

        }
        public int Zdejmij()
        {
            if (indeks == 0)
            {
                throw new EmptyQueueException();
            }
            else
            {
                int tmp = tab[0];

                for (int i = 1; i < indeks; i++)
                {
                    tab[i - 1] = tab[i];
                }
                indeks -= 1;

                return tmp;
            }
        }

        public void PrintQueue()
        {
            Console.WriteLine("KOLEJKA:");
            for(int i=0; i<indeks; i++)
            {
                Console.WriteLine(tab[i]);
            }
        }
    }
}
