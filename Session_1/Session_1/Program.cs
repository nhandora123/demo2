using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string count = "1";
            while (count == "1")
            {
                //Bai2_KiemTraSo(Bai1_XuLyInput());
                //Bai1_Class();
                //Bai2_Class();
                //Bai6_Class();
                Bai2_Home();
                Console.WriteLine("Do you want to loop again ? Press 1 to loop, press any word to stop");
                count = Console.ReadLine();
            }
            Console.ReadLine();
        }
        static int Bai1_XuLyInput()
        {
            int x;

            Console.WriteLine("Input a Number ");
            try
            {
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("That is " + x.GetType());
                return x;
            }
            catch (Exception)
            {
                Console.WriteLine("It have a error");
                return 0;
            }
        }
        static void Bai2_KiemTraSo(int x)
        {
            if (x > 0) Console.WriteLine("That is So Duong");
            else if (x == 0) Console.WriteLine("That is So Khong");
            else Console.WriteLine("That is So Am");
        }

        // Exercise at class

        static void Bai1_Class() {
            try
            {
                Console.WriteLine("Input Don Gia");
                int donGia = int.Parse(Console.ReadLine());
                Console.WriteLine("Input So Luong");
                int soLuong = int.Parse(Console.ReadLine());

                int thanhTien = donGia * soLuong;

                double giamGia= 0;
                if (thanhTien > 100) giamGia = thanhTien * 0.03;

                double tongTien;
                //tongTien = thanhTien - giamGia;

                tongTien = thanhTien > 100 ? thanhTien * 0.97 : thanhTien;
                Console.WriteLine("Tong Tien la" + tongTien);
            }
            catch (Exception)
            {
                Console.WriteLine("Input Fail. You have to press data type Number");
            }

        }
        static void Bai2_Class() {
            try
            {
                Console.WriteLine("Input Dien Tieu Thu");
                int dienTieuThu = int.Parse(Console.ReadLine());

                int thanhTien;

                if (dienTieuThu > 301) thanhTien = (dienTieuThu - 300) * 20 + 100 * 15 + 50 * 10 + 50 * 7 + 100 * 5;
                else if (dienTieuThu > 200) thanhTien = (dienTieuThu - 200) * 15 + 50 * 10 + 50 * 7 + 100 * 5;
                else if (dienTieuThu > 150) thanhTien = (dienTieuThu - 150) * 10 + 50 * 7 + 100 * 5;
                else if (dienTieuThu > 100) thanhTien = (dienTieuThu - 100) * 7 + 100 * 5;
                else thanhTien = dienTieuThu * 5;


                Console.WriteLine("Thanh Tien la" + thanhTien);
            }
            catch (Exception)
            {
                Console.WriteLine("Input Fail. You have to press data type Number");
            }
        }
        static void Bai3_Class()
        {
            for (int i = 1; i < 10; i++)
            {
                for (int y = 1; y < 10; y++)
                {
                    Console.Write(y + " x " + i + " = " + i * y + " ");
                }
                Console.WriteLine();
            }
        }
        static void Bai4_Class() {
            for (int i = 1; i < 10; i++)
            {
                for (int y = 1; y < 10; y++)
                {
                    Console.Write(i  + " x " + y + " = " + i * y + " ");
                }
                Console.WriteLine();
            }
        }
        static void Bai5_Class() {
            Console.WriteLine("Input Width");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Height");
            int height = int.Parse(Console.ReadLine());
            for (int i = 0; i < height; i++)
            {
                for (int y = 0; y < width; y++)
                {
                    Console.Write("*    ");
                }
                Console.WriteLine();
            }
        }
        static void Bai6_Class() {
            try
            {
                Console.WriteLine("Input Width");
                int width = int.Parse(Console.ReadLine());
                Console.WriteLine("Input Height");
                int height = int.Parse(Console.ReadLine());
                for (int i = 0; i < height; i++)
                {
                    for (int y = 0; y < width; y++)
                    {
                        if (i > 0 && y > 0 && i < height - 1 && y < width - 1)// i==1 && y==1 && y ==bb
                        {
                            Console.Write("     ");
                        }
                        else
                            Console.Write("*    ");
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please input data type Number");
            }

        }

        static void Bai7_Class() {
            int n;
            int y = 0;
            int sum = 0;
            do
            {
                if (y > 0) Console.WriteLine("Input Number again");
                Console.WriteLine("Input n ");
                n = int.Parse(Console.ReadLine());
                y++;

            } while (n<0);

            for (int i = 1; i <= n; i++)
            {
                sum += i * i;
            }
            Console.WriteLine("Sum is " + sum);
        }
        static int Bai8_Class(int n)
        {
            if (n <= 0) return 0;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return 0;
            }
            return 1;
        }

        static int Bai82_Class() {
            int n;
            int y = 0;
            int test = 0;
            do
            {
                if (y > 0) Console.WriteLine("Input Number again");
                Console.WriteLine("Input n ");
                n = int.Parse(Console.ReadLine());
                y++;

            } while (n < 0);

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    test = 0;
                    break;
                }
                else test = 1;
            }
            if (test ==1)
            {
                Console.WriteLine("La so nguyen");
            }else
            Console.WriteLine("Khong phai la so nguyen");
            return test;
        }
        static void Bai9_Class() {
            int n;
            int y = 0;
            do
            {
                if (y > 0) Console.WriteLine("Input Number again");
                Console.WriteLine("Input n ");
                n = int.Parse(Console.ReadLine());
                y++;

            } while (n < 0);
            for (int i = 0; i < n; i++)
            {
                if (Bai8_Class(i) == 1) Console.Write(i + " ");
            }
        }
        static void Bai10_Class() {
            int n;
            string i = "0";
            int count = 0;

            int tong = 0;
            int max=0; 
            int min=0;
            do
            {
                Console.WriteLine("Input n ");
                n = int.Parse(Console.ReadLine());
                if (count == 0)
                {
                    max = n;
                    min = n;
                }
                Console.WriteLine("Input Number again. Press 0 if you want to stop");
                i = Console.ReadLine();
                tong += n;

                if (n > max) max = n;
                if (n < min) min = n;
                count++;
            } while (i!="0");
            Console.WriteLine("tong: " + tong + " max: " + max + " min: "+min);
        }

        static void Bai2_Home()
        {
            for (int i = 10; i < 99; i++)
            {
                if (i % 10 != i / 10) Console.Write(i + "   ");
            }
        }
    }
}
