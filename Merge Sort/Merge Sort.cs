using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Sort
{
   
    class Program
    {
        static void Main()
        {
            Console.Title = "Merge Sort";
            var numbers = new[] { 10, 3, 1, 7, 9, 2, 0 };

            // In ra dãy số chưa được sắp xếp
            Console.WriteLine("Truoc khi sap xep:");
            PrintArray(numbers);

            // Sắp xếp dãy số bằng thuật toán merge sort
            MergeSort(numbers, 0, numbers.Length - 1);

            // In ra dãy số đã được sắp xếp
            Console.WriteLine("\nSau khi sap xep:");
            PrintArray(numbers);

            Console.ReadKey(); // Chờ người dùng nhấn một phím trước khi đóng cửa sổ console
        }

        // Hàm sắp xếp merge sort
        static void MergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;

                // Sắp xếp nửa đầu và nửa sau của mảng
                MergeSort(array, left, mid);
                MergeSort(array, mid + 1, right);

                // Trộn hai nửa đã sắp xếp
                Merge(array, left, mid, right);
            }
        }

        // Hàm trộn hai mảng con đã sắp xếp
        static void Merge(int[] array, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            // Tạo mảng tạm để lưu các phần tử
            int[] L = new int[n1];
            int[] R = new int[n2];

            // Sao chép dữ liệu vào mảng tạm
            for (int i = 0; i < n1; i++)
            {
                L[i] = array[left + i];
            }
            for (int j = 0; j < n2; j++)
            {
                R[j] = array[mid + 1 + j];
            }

            // Trộn mảng tạm vào mảng chính array[left..right]
            int k = left;
            int p = 0, q = 0;
            while (p < n1 && q < n2)
            {
                if (L[p] >= R[q])
                {
                    array[k] = L[p];
                    p++;
                }
                else
                {
                    array[k] = R[q];
                    q++;
                }
                k++;
            }

            // Sao chép các phần tử còn lại của L[] nếu có
            while (p < n1)
            {
                array[k] = L[p];
                p++;
                k++;
            }

            // Sao chép các phần tử còn lại của R[] nếu có
            while (q < n2)
            {
                array[k] = R[q];
                q++;
                k++;
            }
        }

        // Hàm in ra mảng
        static void PrintArray(int[] array)
        {
            foreach (var number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
