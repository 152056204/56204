using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool f = true;
            bool n = true;
            char t;
            do
            {
                char ch;
                string x1;
                string y1;
                string z;
                float sum = 0;
                Console.WriteLine("*******欢迎使用计算器********");
                Console.WriteLine("请输入第一个运算数");
                x1 = Console.ReadLine();
                jisuanqi.A = x1;
                Console.WriteLine("请输入您要执行的运算(加(+)、减(-)、乘(*)、除(/))");
                ch = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("请输入第二个运算数");
                y1 = Console.ReadLine();
                jisuanqi.B = y1;
                switch (ch)
                {
                    case '+':
                        if (jisuanqi.m == false && jisuanqi.n == false)
                        {
                            z = jisuanqi.zuhe();
                            Console.WriteLine(x1 + " " + ch + " " + y1 + "  " + "=" + "  " + z);
                            n = false;
                        }
                        else
                        {
                            sum = jisuanqi.jiafa(x1, y1);
                            n = true;
                        }
                        break;
                    case '-':
                        if (jisuanqi.m == false && jisuanqi.n == false)
                        {
                            z = jisuanqi.jianqu();
                            Console.WriteLine(x1 + " " + ch + " " + y1 + "  " + "=" + "  " + z);
                            n = false;
                        }
                        else
                        {
                            sum = jisuanqi.jianfa(x1, y1);
                            n = true;
                        }
                        break;
                    case '*':
                        sum = jisuanqi.chengfa(x1, y1);
                        n = true;
                        break;
                    case '/':
                        sum = jisuanqi.chufa(x1, y1);
                        n = true;
                        break;
                    default: Console.WriteLine("输入错误");
                        n = false;
                        break;
                }
                if (n)
                {
                    Console.WriteLine(x1 + " " + ch + " " + y1 + "  " + "=" + "  " + sum);
                    n = true;
                }
                Console.WriteLine("是否继续输入？Y or N");
                t = Convert.ToChar(Console.ReadLine());
            } while (t == 'Y');
            Console.WriteLine("*********谢谢使用**********");
        }
    }
    class jisuanqi
    {
        public static int a;
        public static int b;
        public static string _a;
        public static string _b;
        public static bool m = true;
        public static bool n = true;
        public static string A
        {
            set
            {
                try
                {
                    a = Convert.ToInt32(value);
                }
                catch (FormatException e)
                {
                    m = false;
                    _a = value;
                }
            }
        }
        public static string B
        {
            set
            {
                try
                {
                    b = Convert.ToInt32(value);
                }
                catch (FormatException e)
                {
                    n = false;
                    _b = value;
                }
            }
        }
        public static string zuhe()
        {
            return (_a + _b);
        }
        public static string jianqu()
        {
            return (_a.Replace(_b, ""));
        }
        public static float jiafa(string a, string b)
        {
            return Convert.ToInt32(a) + Convert.ToInt32(b);
        }
        public static float jianfa(string a, string b)
        {
            return Convert.ToInt32(a) - Convert.ToInt32(b);
        }
        public static float chengfa(string a, string b)
        {
            return Convert.ToInt32(a) * Convert.ToInt32(b);
        }
        public static float chufa(string a, string b)
        {
            return Convert.ToInt32(a) / Convert.ToInt32(b);
        }
    }
}
