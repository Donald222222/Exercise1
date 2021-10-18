using System;
using System.Linq;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            //a
            //// use LINQ  intesection or uion comparison
            int[] list1 = new int[] { 1, 2, 3, 4, 5 };
            int[] list2 = new int[] { 3, 4, 5, 6, 7 };

            var CommonList = list1.Intersect(list2);
            foreach (int value in CommonList)
                Console.WriteLine(value);

            //b items in List1 not in list 2/ used LING except
            var NotInBothArrays = list1.Except(list2);
            foreach (int c in NotInBothArrays)
                Console.WriteLine(c);

            //Reverse b,
            var NotInBs = list2.Except(list1);
            foreach (int c in NotInBs)
                Console.WriteLine(c);

        }
    }
}
