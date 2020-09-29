using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0929
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = " Hello, World! ";
            string t;

            Console.WriteLine(s.Length);
            Console.WriteLine(s[8]);

            Console.WriteLine(s.Insert(8, "C# "));
            Console.WriteLine(s.PadLeft(20, '.'));
            Console.WriteLine(s.PadRight(20, '.'));
            Console.WriteLine(s.Remove(6));
            Console.WriteLine(s.Remove(6, 7));
            Console.WriteLine(s.Replace('l', 'm'));
            Console.WriteLine(s.ToLower());
            Console.WriteLine(s.ToUpper());
            Console.WriteLine('/' + s.Trim() + '/');
            Console.WriteLine('/' + s.TrimStart() + '/');
            Console.WriteLine('/' + s.TrimEnd() + '/');

            string[] a = s.Split(',');
            foreach (var i in a)
                Console.WriteLine('/' + i + '/');

            char[] destination = new char[10];
            s.CopyTo(8, destination, 0, 6);
            Console.WriteLine(destination);

            Console.WriteLine('/' + s.Substring(8) + '/');
            Console.WriteLine('/' + s.Substring(8, 5) + '/');

            Console.WriteLine(s.Contains("ll"));
            Console.WriteLine(s.IndexOf('o'));
            Console.WriteLine(s.LastIndexOf('o'));
            Console.WriteLine(s.CompareTo("abc"));

            Console.WriteLine(String.Concat("Hi~", s));
            Console.WriteLine(String.Compare("abc", s));
            Console.WriteLine(t = String.Copy(s));

            String[] val = { "apple", "orange", "grape", "pear" };
            String result = String.Join(", ", val);
            Console.WriteLine(result);

            //문제1  주문번호 : yyyyMMdd일련번호5자리 (2020092900005) 를 출력하시오.
            string str = DateTime.Now.ToString("yyyyMMdd") + "5".PadLeft(5, '0');
            Console.WriteLine(str);

            //문제2  입력받은 아이디가 6자리 이상인지 체크하시오.
            Console.WriteLine("입력받은 아이디가 6자리 이상인지 체크하시오.");
            string id;
            while (true)
            {
                id = Console.ReadLine();
                if (id.Length < 6)
                    Console.WriteLine("id는 6자리 이상입니다.");
                else
                    break;
            }
            Console.WriteLine(id);


            //문제3  파일명 : yyyyMMddHHmmss + 랜덤3자리(영문대문자 + 숫자)
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 3; i++)
            {
                int rndval = rnd.Next(0, 36);
                if (rndval < 10)
                    sb.Append(rndval);
                else
                    sb.Append((char)(rndval + 55));
            }
            Console.WriteLine($"{DateTime.Now.ToString("yyyyMMddHHmmss")}{sb.ToString()}");
        }
    }
}
