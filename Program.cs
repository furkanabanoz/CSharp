using System;

namespace c_2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b=5;
            sbyte c=5;
            short s=5;
            ushort us=5;
            Int16 i16=2;
            int i=2;
            Int32 i32=2;
            Int64 i64=2;
            uint ui=2;
            long l=4;
            ulong ul=4;
            float f=5;
            double d=5.2;
            decimal de=5;
            char ch='k';
            string st ="naberrr";
            bool b1=true;
            DateTime dt=DateTime.Now;

            Console.WriteLine(dt);

            object o1='y';
            object o2=4.3;

            string str1=string.Empty;
            str1="furkan abanoz";
            bool b2=10>2;

            string str20="20";
            int int20=20;

            string newvalue=str20+int20.ToString();

            Console.WriteLine(newvalue);

            int newvalue2=int20+Convert.ToInt32(str20);

            Console.WriteLine(newvalue2);

            int int22=int20+int.Parse(str20);

            Console.WriteLine(int22);


            string datetime=DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);




        }
    }
}
