using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DES
{
    class Mathemat
    {
        static private bool TestFerma(long x)
        {


            //	BigInteger.ModPow()
            Random rand = new Random();
            if (x == 0)
                return false;
            if (x == 2)
                return true;

            for (int i = 0; i < 100; i++)
            {
                long a = rand.Next((int)x);
                if (a <= 2)
                    a = a + 2;
                if (BigInteger.ModPow(a, x - 1, x) != 1)
                {
                    return false;
                }
            }

            return true;
        }

        private long GCD(long a, long b)
        {
            while (a != 0 && b != 0)
            {
                if (a >= b) a = a % b;
                else b = b % a;
            }

            return a + b; // Одно - ноль
        }

        int Gcd(int a, int b, out int x, out int y)
        {
            if (a == 0)
            {
                x = 0;
                y = 1;
                return b;
            }

            int x1, y1;
            int d = Gcd(b % a, a, out x1, out y1);
            x = y1 - (b / a) * x1;
            y = x1;
            return d;
        }

        public void Encrypt(out int e, out int n, out int d)
        {

            int p, q, w, fi;
            bool c;
            Random rand = new Random();
            do
            {
                p = rand.Next(32000);
                c = TestFerma(p);
            } while (!c);

            q = p;
            do
            {
                q++;
                c = TestFerma(q);
            } while (!c);

            n = p * q;
            fi = (p - 1) * (q - 1);
            do
            {
                e = rand.Next(6000);
                Gcd(e, fi, out w, out d);
            } while ((GCD(fi, e) != 1) || (w < 0));

            d = w;
        }


    }
}
