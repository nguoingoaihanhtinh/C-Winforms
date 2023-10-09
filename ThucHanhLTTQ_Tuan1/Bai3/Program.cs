using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections;
using System.Globalization;

namespace Bai3
{

    public class Program
    {
        static bool check(int a)
        {
            for(int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0) return false;
            }
            return a >= 2;

        }
        static void Main()
        {
            int n, m;
            Console.Write("Nhap n so dong: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap m so cot: ");
            m = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();
            int[,] a = new int[n, m];
            for (int i = 0; i < n; i++ )
            {
                for(int j = 0; j < m; j++ )
                {
                    a[i,j] = r.Next(1000);
                }
            }
            int max = 0;
            int min = Int32.MaxValue;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    Console.Write("{0} ", a[i, j]);
                    min = Math.Min(min, a[i, j]);
                    max = Math.Max(max, a[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Min:{0} , Max:{1}", min, max);

            //Cau c
            int maxRow = 0;
            int maxRowIndex = 0;
            for(int i = 0; i < n; i++)
            {
                int sum = 0;
                for(int j = 0; j < m; j++)
                {
                    sum += a[i, j];
                }
                if(maxRow < sum)
                {
                    maxRow = sum;
                    maxRowIndex = i + 1;
                }
            }
            Console.WriteLine("Dong co tong lon nhat la: {0}", maxRowIndex);

            //Cau d
            int sum_notprime = 0;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    if (!check(a[i,j]))
                    {
                        sum_notprime += a[i, j];
                    }
                }
            }
            Console.WriteLine("Tong cac so khong phai so nguyen to la: {0}", sum_notprime);

            //Cau e
            Console.WriteLine("Nhap so dong can xoa");
            int rowDelete = Convert.ToInt32(Console.ReadLine()) - 1;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    if(i == n - 1)
                    {
                        a[i, j] = 0;
                        continue;
                    }
                    if(i >= rowDelete)
                    {
                        a[i, j] = a[i + 1, j];
                    }
                }
            }
            n--;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m;j++)
                {
                    Console.Write("{0} ", a[i, j]);
                }
                Console.WriteLine();
            }
            //Cau f
            Console.WriteLine("Mang sau khi xoa di cot chua phan tu lon nhat:");
            int maxEle = 0;
            int maxEleColIdx = -1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] > maxEle)
                    {
                        maxEle = a[i, j];
                        maxEleColIdx = j;
                    }
                }
            }
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if (j == m - 1) continue;
                    if (j >= maxEleColIdx)
                    {
                        a[i, j] = a[i, j + 1];
                    }
                }
            }
            m--;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0} ", a[i, j]);
                }
                Console.WriteLine();
            }
        }

    }
}