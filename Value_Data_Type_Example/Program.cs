using System;

namespace Value_Data_Type_Example
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Size of int | {0}", sizeof(int)); // Output => Size of int | 4
            Console.WriteLine("Size of float | {0}", sizeof(float)); // Output => Size of float | 4
            Console.WriteLine("Size of double | {0}", sizeof(double)); // Output => Size of double | 8
            Console.WriteLine("Size of char | {0}", sizeof(char)); // Output => Size of char | 2
            Console.WriteLine("Size of bool | {0}", sizeof(bool)); // Output => Size of bool | 1
            Console.WriteLine("Size of byte | {0}", sizeof(byte)); // Output => Size of byte | 1
            Console.WriteLine("Size of short | {0}", sizeof(short));  // Output => Size of short | 2
            Console.WriteLine("Size of long | {0}", sizeof(long)); // Output => Size of long | 8
            Console.WriteLine("Size of decimal | {0}", sizeof(decimal)); // Output => Size of decimal | 16
            Console.WriteLine("Size of sbyte | {0}", sizeof(sbyte)); // Output => Size of sbyte | 1
            Console.WriteLine("Size of uint | {0}", sizeof(uint)); // Output => Size of uint | 4
            Console.WriteLine("Size of ulong | {0}", sizeof(ulong)); // Output => Size of ulong | 8
            Console.WriteLine("Size of ushort | {0}", sizeof(ushort)); // Output => Size of ushort | 2

            Console.ReadKey();
        }
    }
}