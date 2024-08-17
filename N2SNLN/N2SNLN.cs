using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nhap so nguyen lon thu 1:");
        string input1 = Console.ReadLine();

        Console.WriteLine("Nhap so nguyen lon thu 2:");
        string input2 = Console.ReadLine();

        // Chuyển đổi chuỗi thành mảng số nguyên
        int[] number1 = input1.Select(c => c - '0').Reverse().ToArray();
        int[] number2 = input2.Select(c => c - '0').Reverse().ToArray();

        // Thực hiện phép nhân
        int[] result = Multiply(number1, number2);

        // In kết quả
        Console.WriteLine("Ket qua cua phep nhan:");
        Console.WriteLine(string.Join("", result.Reverse()));
    }

    static int[] Multiply(int[] num1, int[] num2)
    {
        int len1 = num1.Length;
        int len2 = num2.Length;
        int[] result = new int[len1 + len2];

        for (int i = 0; i < len1; i++)
        {
            for (int j = 0; j < len2; j++)
            {
                result[i + j] += num1[i] * num2[j];
                result[i + j + 1] += result[i + j] / 10;
                result[i + j] %= 10;
            }
        }

        // Xóa các số 0 ở đầu kết quả
        int k = result.Length - 1;
        while (k > 0 && result[k] == 0)
        {
            k--;
        }

        return result.Take(k + 1).ToArray();
    }
}
