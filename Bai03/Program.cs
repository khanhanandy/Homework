using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bai03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            #region Bài 01
            //Console.WriteLine("Nhap vao 1 so nguyen");
            //float a = int.Parse(Console.ReadLine());
            //bool isInt = a % 1 != 0;
            //if (isInt == false) break;
            //else Console.WriteLine(a % 3 == 0 ? $"So {a} chia het cho 3" : $"So {a} ko chia het cho 3");
            #endregion

            #region Bài 02
            //Console.WriteLine("Nhap vao 1 so nguyen");
            //int a = int.Parse(Console.ReadLine());

            //if (a < 0) Console.WriteLine($"{a} khong phai so nguyen duong");
            //else
            //    for (int i = 1; i < 11; i++) Console.WriteLine($"{a} x {i} = {a*i}");
            #endregion

            #region Bai 03
            //Console.WriteLine("Nhap vao 1 so nguyen");
            //int a = int.Parse(Console.ReadLine());
            //int tong = 1;
            //double tong_all = 0;
            //string text = "";
            //string text_all = "";

            //if (a == 0)
            //{
            //    Console.WriteLine("Tong giai thua cua so 0 la 1");
            //}
            //else
            //{
            //    for (int i = 1; i <= a; i++)
            //    {
            //        tong *= i;
            //        tong_all += tong;
            //    }
            //    Console.WriteLine($"Tong giai thua cua so tu 1 den {a} la {tong_all}");

            //}
            #endregion

            #region Bai 04
            //Console.WriteLine("Nhap vao 1 so nguyen");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine(Math.Sqrt(a) % 1 != 0 ? $"So {a} ko phai so chinh phuong": $"So {a} la so chinh phuong");
            #endregion

            #region Bai 05
            //Console.WriteLine("Nhap vao 1 so nguyen");
            //int a = int.Parse(Console.ReadLine());
            //switch (a)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine($"Thang {a} co 31 ngay");
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine($"Thang {a} co 31 ngay");
            //        break;
            //    case 2:
            //        Console.WriteLine("Thang 2 co 28 ngay hoac 29 ngay");
            //        break;
            //    default:
            //        Console.WriteLine("Thang ko hop le. Vui long chay lai");
            //        break;
            //}
            #endregion

            #region Bai 06
            //Console.WriteLine("Nhap vao 1 so nguyen");
            //int a = int.Parse(Console.ReadLine());
            //double S = 0;
            //string output = "";

            //for (int i = 1; i <= a; i++)
            //{
            //    S += Math.Pow(i, i);
            //    output += i == a ? $"{i}^{i}" : $"{i}^{i} + ";

            //}
            //Console.WriteLine($"{output} = {S}");

            #endregion

            #region Bai 07
            //Console.WriteLine("Nhap vao 1 so nguyen");
            //int a = int.Parse(Console.ReadLine());
            //int tong = 0;

            //for (int i = 1; i < a; i += 2)
            //{
            //    tong += i; 
            //}
            //Console.WriteLine($"Tong cac so le tu 1 den {a} la {tong}");

            #endregion

            #region Bai 08
            //Console.WriteLine("Nhap vao 1 so nguyen");
            //int a = int.Parse(Console.ReadLine());
            //int count = 0;
            //if (a <= 1)
            //{
            //    Console.WriteLine($"So {a} ko phai so nguyen to");
            //}
            //else
            //    for (int i = 2; i < a / 2; i++)
            //        if (a % i == 0)
            //        {
            //            count ++;
            //        }
            //Console.WriteLine(count > 0 ? $"So {a} ko la so nguyen to" : $"So {a} la so nguyen to");
            #endregion

            #region Bai 09
            //Console.WriteLine("Nhap vao 1 so nguyen");
            //int a = int.Parse(Console.ReadLine());
            //string star_line = "";
            //for (int i = 1; i < a + 1; i++)
            //{
            //    star += "*";
            //    Console.WriteLine(star);
            //}
            #endregion

            #region Bai 10
            //Console.WriteLine("Nhap vao 1 so nguyen");
            //int a = int.Parse(Console.ReadLine());
            //int x = 0; int y = 1;
            //Console.Write("0 1");
            //for (int i = 0; i < a; i++)
            //{
            //    int z = x + y;
            //    Console.Write($" {z}");
            //    x = y; y = z;
            //}
            #endregion

            Console.ReadLine();
        }
    }
}
