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
            //Array.Reverse(arr);
            //Console.WriteLine("Cau 2: Mang sau khi sap xep theo chieu dao nguoc la");
            //for (int i = 0;i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]+"\t");
            //}

            // Cau 3: Tim so phan tu giong nhau trong mang va hien thi so luong giong nhau
            // Cau 4: In cac phan tu duy nhat trong mang
            //int count = 1;
            //int[] arr_unique = arr.Distinct().ToArray();
            //Console.WriteLine($"Cau 4: Cac phan tu duy nhat trong mang la");
            //for (int i = 0; i < arr_unique.Length; i++)
            //{
            //    for (int j = 0; j < arr.Length; j++)
            //    {
            //        if (arr[j] == arr_unique[i]) count += 1;

            //            continue;
            //    }
            //}

            // Cau 5: Chia mang ban dau thanh mang chan va mang le
            int[] arr_odd = new int[] { };
            int index_odd = 0;
            int[] arr_even = new int[] { };
            int index_even = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    arr_odd.SetValue(arr[i], index: index_odd);
                    index_odd += 1;
                }
                else
                {
                    arr_even.SetValue(arr[i], index: index_even);
                    index_even += 1;
                }
            }
            for (int i = 0; i < arr_even.Length; i++)
            {
                Console.WriteLine(arr_even[i] + "\t");
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
