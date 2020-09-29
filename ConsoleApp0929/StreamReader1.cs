using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0929
{
    class StreamReader1
    {
        static void Main()
        {
            using (StreamReader sr = new StreamReader("test.log", Encoding.UTF8))
            {
                //ReadLine()는 한 줄을 읽어서 string으로 반환
                //만약 file의 끝인 경우 null을 반환
                int cnt = 0;
                string content;
                while ((content = sr.ReadLine()) != null)
                {
                    Console.WriteLine("Line: {0, 2}, {1}", ++cnt, content);
                }

                //string content = sr.ReadLine();
                //while (content != null)
                //{
                //    Console.WriteLine(content);
                //    content = sr.ReadLine();
                //}
            }

            //using (StreamReader sr = new StreamReader("test.log", Encoding.UTF8))
            //{
            //    string content = sr.ReadToEnd(); 설정 파일 읽어올때(크기가 크지 않을때)
            //    Console.WriteLine(content);
            //}
        }
    }
}
