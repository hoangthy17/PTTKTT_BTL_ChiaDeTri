using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKTT_BTL_ChiaDeTri
{
    internal class Program
    {
      
            public static int BinarySearch(int[] array, int target)
            {
                int left = 0;               // Chỉ số bắt đầu của mảng
                int right = array.Length - 1; // Chỉ số kết thúc của mảng

                while (left <= right)
                {
                    // Tính toán chỉ số giữa
                    int mid = left + (right - left) / 2;

                    // Kiểm tra nếu phần tử giữa là phần tử cần tìm
                    if (array[mid] == target)
                    {
                        return mid; // Trả về chỉ số của phần tử nếu tìm thấy
                    }

                    // Nếu phần tử cần tìm lớn hơn phần tử giữa, bỏ qua nửa trái
                    if (array[mid] < target)
                    {
                        left = mid + 1;
                    }
                    // Nếu phần tử cần tìm nhỏ hơn phần tử giữa, bỏ qua nửa phải
                    else
                    {
                        right = mid - 1;
                    }
                }

                return -1; // Trả về -1 nếu không tìm thấy phần tử
            }

        // Hàm chính để chạy chương trình
        static void Main(string[] args)
        {
            // Khởi tạo mảng đã được sắp xếp
            int[] array = { 3, 9, 10, 27, 38, 43, 82 };
            int target = 43; // Phần tử cần tìm

            // In ra mảng đã sắp xếp và phần tử cần tìm
            Console.WriteLine("Mang đa sap xep: " + string.Join(", ", array));
            Console.WriteLine("Phan tu can tim: " + target);

            // Gọi hàm BinarySearch để tìm phần tử trong mảng
            int index = BinarySearch(array, target);

            // In ra kết quả tìm kiếm
            if (index != -1)
            {
                Console.WriteLine("Phan tu " + target + " đuoc tim thay tai chi so: " + index);
            }
            else
            {
                Console.WriteLine("Phan tu " + target + " khong co trong mang.");
            }
        }
    
    }
}
