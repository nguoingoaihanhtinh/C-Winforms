using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections;
namespace Test
{

    public class Program
    {
        public static bool scp(int a)
        {
            int sqrt = (int)Math.Sqrt(a);
            if (sqrt * sqrt == a)
            {
                return true;
            }
            else return false;
        }
        public static bool snt(int a)
        {
            if (a < 2) return false;
            int sqrt = (int)Math.Sqrt(a);
            for (int i = 2; i <= sqrt;i++)
            {
                if(a % i == 0) return false;
            }
            return true;
        }
        public static void Main()
        {


            int n;
            int[] a = new int[50];
            Console.WriteLine("Nhap vao so phan tu: ");
            n = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();
            int sum = 0;
            int cnt = 0;
            int mincp = 100;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i] = r.Next(100));
            }
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 1)
                {
                    sum = sum + Convert.ToInt32(a[i]);
                }
                if (snt(a[i]))
                {
                    cnt++;
                }
                if (scp(a[i]))
                {
                    if (a[i] < mincp)
                    {
                        mincp = a[i];
                    }
                }
                else mincp = -1;
            }
            Console.WriteLine("Tong: " + sum);
            Console.WriteLine("Co: " + cnt + " so nguyen to");
            Console.WriteLine("So chinh phuong nho nhat la: " + mincp);
        }
    }
}
