using System;
using System.Collections;


namespace Bai1
{
    class Program
    {
        public 
        static void Main(string[] args)
        {
            Random rand = new Random();
            ArrayList arrList = new ArrayList();

            for(int i = 0; i < 20; i++)
            {
                int randomNumber = rand.Next(1, 1000);
                arrList.Add(randomNumber);
            }

            int choice = 0;
            while (choice >= 1 || choice <= 9)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Xuat day so");
                Console.WriteLine("2. Dao nguoc day so");
                Console.WriteLine("0. Thoat khoi chuong trinh");
                Console.WriteLine();

                Console.Write("Vui long nhap lua chon cua ban: ");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Thoat chuong trinh.");
                        Environment.Exit(0);
                        break;

                    case 1:
                        Console.WriteLine("Day so nguyen random: ");
                        foreach(int num in arrList)
                        {
                            Console.Write(num + " ");
                        }
                        Console.WriteLine();
                        break;

                    case 2:
                        ArrayList reversedArrList = new ArrayList();
                        for(int i = arrList.Count - 1; i >= 0; i--)
                        {
                            reversedArrList.Add(arrList[i]);
                        }
                        Console.WriteLine("Day so da dao nguoc la:");
                        foreach(int num in reversedArrList)
                        {
                            Console.Write(num + " ");
                        }
                        Console.WriteLine();
                        break;
                        
                    case 3:
                        Console.WriteLine("Nhap so can tim: ");
                        int x = int.Parse(Console.ReadLine());

                        if(arrList.Contains(x))
                        {
                            Console.WriteLine("Tim thay " + x + " trong day so!");
                        }
                        else
                        {
                            Console.WriteLine("Khong tim thay " + x + " trong day so!");
                        }

                    default:
                        Console.WriteLine("Lua chon khong hop le, vui long chon lai!");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
