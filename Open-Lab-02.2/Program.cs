using System;

namespace skuška
{
    class Program
    {
        public static void Main(string[] args)
        {
            float[] array1 = new float[] { 1.154f, 32.5f, 515.2456f, 7.1254f, 91.254f };
            float count = 0;
            foreach (float element in array1)
            {
                count++;
                Console.Write($"{element.ToString("N2")} ");
            }

        }



    }
}
