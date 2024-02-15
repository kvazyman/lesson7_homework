// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

 static int Acker(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            else if (n == 0)
            {
                return Acker(m - 1, 1);
            }
            else
            {
                return Acker(m - 1, Acker(m, n - 1));
            }

        }

Console.Write("Введите значение M:");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение N:");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Acker(m,n));
