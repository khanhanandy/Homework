using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so phan tu n");
            int[] arr = new int[int.Parse(Console.ReadLine())];

            // Cau 1
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Gia tri cua phan tu thu {i} la");
                arr[i] = int.Parse(Console.ReadLine());
            }

            // Cau 2: In mang du lieu tren theo chieu dao nguoc
            Array.Reverse(arr);
            Console.WriteLine("Cau 2: Mang sau khi sap xep theo chieu dao nguoc la");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + "\t");
            }

            // Cau 3: Tim so phan tu giong nhau trong mang va hien thi so luong giong nhau 
            //int[] arr_distinct = arr.Distinct().ToArray();
            //for (int i = 0; i < arr_distinct.Length; i++)
            //    Console.WriteLine(arr_distinct[i]);
            //for (int i = 0; i < arr_distinct.Length; i++)
            //{
            //    int count = 0;
            //    for (int j = 0; j < arr.Length; j++)
            //    {
            //        if (arr[j] == arr_distinct[i]) count += 1;
            //        continue;
            //    }
            //    if (count > 1) Console.WriteLine($"Cau 3: Phan tu giong nhau trong mang la {arr_distinct[i]} voi so lan xuat hien la {count}");
            //}

            // Cau 4: In phan tu duy nhat 
            //int[] arr_distinct = arr.Distinct().ToArray();
            //for (int i = 0; i < arr_distinct.Length; i++)
            //    Console.WriteLine(arr_distinct[i]);
            //for (int i = 0; i < arr_distinct.Length; i++)
            //{

            //    int count = 0;
            //    for (int j = 0; j < arr.Length; j++)
            //    {
            //        if (arr[j] == arr_distinct[i]) count += 1;
            //        continue;
            //    }
            //    if (count == 1) Console.WriteLine($"Cau 4: Phan tu duy nhat la {arr_distinct[i]}");
            //}

            // Cau 5: Chia mang ban dau thanh mang chan va mang le
            int[] arr_odd = new int[] { };
            int[] arr_even = new int[] { };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0) arr_odd.Append(arr[i]);
                else arr_even.Append(arr[i]);
               }
            for (int i = 0; i < arr_odd.Length; i++)
            {
                Console.Write($"Mang le la {arr_odd[i]} + \t");
            }


            // Cau 6: Sap xep mang theo thu tu giam dan
            //Array.Sort(arr);
            //Array.Reverse(arr);
            //Console.WriteLine("Cau 6: Sap xep mang theo thu tu giam dan la");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i] + "\t");
            //}
            // Cau 7: Tim phan tu lon thu 2 trong mang
            //Console.WriteLine($"Cau 7: Phan tu lon thu 2 trong mang ban dau la {arr[1]}");


            Console.ReadKey();


        }
    }
}
