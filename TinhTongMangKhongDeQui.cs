using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhTongMangKhongDeQui
{
       

    class Program
    {
        static void Main()
        {
            int n = 5;
            int mid = n / 2;
            int sum1 = SumRange(1, mid);
            int sum2 = SumRange(mid + 1, n);
            int totalSum = sum1 + sum2;

            Console.WriteLine("Tong tu 1 den {n} la: {totalSum}");
        }

        static int SumRange(int start, int end)
        {
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                sum += i;
            }
            return sum;
        }
    }

}
