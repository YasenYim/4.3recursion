using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_3递归
{
    class Program
    {
        static void Loop(int n)
        {
            if (n == 0) { return; }
            
            Loop(n - 1);
            Console.WriteLine(n);
        }
        // 等比数列
        static int A(int n)
        {
            if(n == 1)
            { return 1; }
            return A(n - 1) * 2;
        }
        // 斐波那契数列 1 1 2 3 5 8 13 21 34 45
        static int Fib(int n)
        {
            if (n==0 || n==1)
            { return 1; }
            return Fib(n - 1) + Fib(n - 2);
        }
        //static int F()
        //{
        //    return G();
        //}
        //static int G()
        //{
        //    return H();
        //}
        //static int H()
        //{
        //    return K();
        //}
        //static int K()
        //{
        //    return 1;
        //}
        static void Main(string[] args)
        {
            //Console.WriteLine("F() return:" + F());
            Loop(10);    // 结果是10 9 8 7 6 5 4 3 2 1
            //Console.WriteLine(A(5)); // 16
            //Console.WriteLine(A(6)); // 32

            //for(int i = 0;i<11;i++)
            //{
            //    Console.WriteLine(Fib(i));
            //}

            Console.ReadKey();
        }
    }
}
