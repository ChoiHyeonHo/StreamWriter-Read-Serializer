using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0929
{
    [Serializable]
    class PersonS
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        public PersonS(string name, string phone, int age)
        {
            this.Name = name;
            this.Phone = phone;
            this.Age = age;
        }
    }
    class ClassSerialize
    {
        static void Main()
        {
            PersonS[] arr = new PersonS[3];
            arr[0] = new PersonS("김연아", "010-1111", 30);
            arr[1] = new PersonS("류현진", "010-2222", 30);
            arr[2] = new PersonS("손흥민", "010-3333", 32);

            FileStream fs = new FileStream("b.dat", FileMode.Create);
            BinaryFormatter serializer = new BinaryFormatter();

            serializer.Serialize(fs, arr);
            fs.Close();

            Console.WriteLine("객체 직렬화 성공");
            
            FileStream rs = new FileStream("b.dat", FileMode.Open);
            arr = (PersonS[])serializer.Deserialize(rs);

            Console.WriteLine("객체 역직렬화 성공");

            foreach (PersonS item in arr)
            {
                Console.WriteLine(item.Name);
            }

        }
    }
}
