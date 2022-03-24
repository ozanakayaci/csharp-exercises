using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İsminizi Yazın:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadınızı Yazın:");
            string surname = Console.ReadLine();
            Console.WriteLine(name + " " + surname);

            byte b = 5;         //1 byte
            sbyte sb = -5;      //1 byte

            short s = 5;        //2 byte
            ushort us = 5;      //2 byte

            Int16 i16 = 0;      //2 byte
            int i = 61;         //4 byte
            Int32 i32 = 5;      //4 byte
            Int64 i64 = 5;      //8 byte

            uint ui = 2;        //4 byte
            long l = 5;         //8 byte
            ulong ul = 5;       //8 byte

            float f = 5.5f;     //4 byte
            double d = 5.5;     //8 byte
            decimal d2 = 5.5m;  //16 byte

            char c = 'a';       //2 byte
            string str = "a";   //sınırsız

            bool b2 = true;     //1 byte

            DateTime date = DateTime.Now; //8 byte

            //object
            object o1 = '5';
            object o2 = "5";
            object o3 = 5;
            object o4 = 5.3;

            //string ifadeler
            string str2 = string.Empty;
            str2 = "Ozan";
            string ad = "Ozan";
            string soyad = "Kayacı";
            string adSoyad = ad + " " + soyad;

            //integer tanımlama şekilleri

            int int1 = 0;
            int int2 = 5;
            int int3 = int1 * int2;

            //boolean

            bool bool1 = true;

            //değişken dönüşümleri
            string str20 = "20";
            int int20 = 20;

            string yeniDeger = str20 + int20.ToString();//2020

            int int21 = int20 + Convert.ToInt32(str20);//40

            int int22 = int20 + int.Parse(str20);//40

            //datetime 

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");

            string hour = DateTime.Now.ToString("HH:mm");




        }
    }
}
