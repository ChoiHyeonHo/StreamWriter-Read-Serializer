using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp0929
{
    class StreamWriter1
    {
        [STAThread]
        static void Main()
        {
            //C:\Users\GDC6\Desktop\새 폴더\ConsoleApp0929\ConsoleApp0929\bin\Debug
            //System.Environment.CurrentDirectory = "C:\\";

            SaveFileDialog dlg = new SaveFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName = dlg.FileName;
                using (StreamWriter sw = new StreamWriter(fileName, true, Encoding.UTF8))
                {
                    sw.WriteLine("안녕하세요. {0}님!", "홍길동");
                    sw.WriteLine(123456);
                    sw.WriteLine("ABCabc");
                    sw.Flush();
                }
            }
        }
    }
}
