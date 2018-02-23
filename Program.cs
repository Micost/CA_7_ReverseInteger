using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_7_ReverseInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 1534236469;
            Solution s1 = new Solution();
            Console.Write(s1.Reverse(input));
            var a = Console.ReadKey();
        }
    }
    public class Solution
    {
        public int Reverse(int x)
        {
            int flag = 1;
            if ( x < 0 )
            {
                flag = -1;
            }
            int input = x * flag;
            int result = 0;
            while (true)
            {
                if ( input == 0)
                {
                    break;
                }
                try
                {
                    result = checked(result * 10 + input % 10);
                }
                catch (OverflowException)
                {
                    return 0;
                }
                input = input / 10;
            }
            return result* flag;
        }
    }
}
