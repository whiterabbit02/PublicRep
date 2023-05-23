using System;

namespace Lab1test
{
    class Program
    {

        public static int[] input()
        {
            string st;
            int a;
            Console.WriteLine("Введите количество товаров: ");
            st = Console.ReadLine();
            a = Convert.ToInt32(st);

            int[] tovar = new int[a];

            Console.WriteLine("Введите стоимость товаров: ");

            for (int i = 0; i < a; i++)
            {
                st = Console.ReadLine();
                tovar[i] = Convert.ToInt32(st);
            }

            return tovar;
        }

        public static int kolVishSr(int[] tovar)
        {
            int summ, k, sr, sch;
            summ = 0;
            sch = 0;
            k = tovar.Length;

            for (int i = 0; i < k; i++)
            {
                summ = summ + tovar[i];
                sch++;
            }

            sr = summ / sch;
            sch = 0;

            for (int i = 0; i < k; i++)
            {
                if (tovar[i] > sr)
                {
                    sch++;
                }
            }

            return sch;
        }

        public static int[] sort(int[] tovar)
        {
            string st;
            int[] index = new int[1];
            int dell, schet = 0, m, p;

            Console.WriteLine("Товар какой стоимостью удалить?");
            st = Console.ReadLine();
            dell = Convert.ToInt32(st);

            for (int i = 0; i < tovar.Length; i++)
            {
                if (tovar[i] == dell)
                {
                    schet++;
                }
            }

            int[] tovarIsp = new int[tovar.Length - schet];

            m = tovar.Length;
            p = 0;

            do
            {
                if (tovar[p] == dell)
                {
                    for (int j = p; j < m - 1; j++) tovar[j] = tovar[j + 1];
                    m--;
                }
                else
                {
                    p++;
                }
            }
            while (p <= m);

            for (int i = 0; i < tovarIsp.Length; i++)
            {
                tovarIsp[i] = tovar[i];
            }

            return tovarIsp;
        }

        public static void output(int[] a)
        {
            Console.WriteLine("Новый массив оставшихся товаров: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        public static void Main(string[] args)
        {
            int[] tov = input();
            Console.WriteLine("Количество товаров, стоимость которых выше средней стоимости: " + kolVishSr(tov));
            int[] ispTov = sort(tov);
            output(ispTov);

            Console.ReadKey();
        }
    }
}