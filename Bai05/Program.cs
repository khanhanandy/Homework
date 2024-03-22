using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    internal class Program
    {
        public static void PrintArray(int[] arr_input) 
        { for (int i = 0;i < arr_input.Length; i ++)
                Console.WriteLine(arr_input[i]);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so phan tu n");
            int[] arr = new int[int.Parse(Console.ReadLine())];

            #region Cau 01
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Gia tri cua phan tu thu {i} la");
                arr[i] = int.Parse(Console.ReadLine());
            }
            #endregion

            #region Cau 02  In mang du lieu tren theo chieu dao nguoc
            //Array.Reverse(arr);
            //Console.WriteLine("Cau 2: Mang sau khi sap xep theo chieu dao nguoc la");
            //PrintArray(arr);
            #endregion

            #region Cau 03 Tim so phan tu giong nhau trong mang va hien thi so luong giong nhau 
            //int[] arr_distinct = arr.Distinct().ToArray();
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

            // Sua cau 03
            //var dup = arr.GroupBy(x => x).Select(x => new { Value = x.Key, Count = x.Count() }) ; 
            //foreach (var item in dup)
            //{
            //    Console.WriteLine($"Gia tri {item.Value} lap lai {item.Count}");
            //}
            #endregion

            #region Cau 04 In cac phan tu duy nhat
            //int[] arr_distinct = arr.Distinct().ToArray();
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

            // Sua cau 04
            // var arr_distinct = arr.Distinct();
            #endregion

            #region Cau 05  Chia mang ban dau thanh mang chan va mang le
            //int[] arr_odd = new int[] { };
            //int[] arr_even = new int[] { };

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 2 != 0)
            //        arr_odd = arr_odd.Concat(new int[]{arr[i]}).ToArray();
            //    else arr_even = arr_even.Concat(new int[] { arr[i] }).ToArray();
            //}
            //Console.WriteLine("Mang le la");
            // PrintArray(arr_odd);
            //Console.WriteLine("Mang chan la");
            // PrintArray(arr_even);
            #endregion

            //Sua cau 05: dung thuat toan LINQ
            //var sochan = arr.Where(item => item % 2 == 0).OrderBy(x => x).ToArray();
            //var sole = arr.Where(item => item % 2 != 0).OrderByDescending(x => x).ToArray();
            //Console.WriteLine("Mang le la");
            //PrintArray(sochan);
            //Console.WriteLine("Mang chan la");
            //PrintArray(sole);


            #region Cau 06 Sap xep mang theo thu tu giam dan
            //Array.Sort(arr);
            //Array.Reverse(arr);
            //Console.WriteLine("Cau 6: Sap xep mang theo thu tu giam dan la");
            //PrintArray(arr);
            #endregion

            #region Cau 07 Tim phan tu lon thu 2 trong mang
            //int[] arr_new = new int[] { };
            //for (int i = 0; i < arr.Length; ++i)
            //{
            //    if (arr[i] == arr.Max())
            //        continue;
            //        arr_new = arr_new.Concat(new int[] { arr[i] }).ToArray();
            //}
            //Console.WriteLine($"Cau 7: Phan tu lon thu 2 trong mang ban dau la {arr_new.Max()}");
            #endregion

            Console.ReadKey();


        }
    }
}
