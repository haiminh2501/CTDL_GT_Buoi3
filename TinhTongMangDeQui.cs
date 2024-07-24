using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhTongMangDeQui
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = 5;
            int sum = DivideAndConquerSum(1, n);
            Console.WriteLine("Tong tu 1 den {n} la: {sum}");
        }

        static int DivideAndConquerSum(int start, int end)
        {
          
            if (start == end)
            {
                return start;
            }

          
            int mid = (start + end) / 2;

            
            int leftSum = DivideAndConquerSum(start, mid);
            int rightSum = DivideAndConquerSum(mid + 1, end);

            
            return leftSum + rightSum;
        }
    }

}
