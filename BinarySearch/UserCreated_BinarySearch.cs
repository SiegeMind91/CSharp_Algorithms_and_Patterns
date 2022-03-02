using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int theValue = 43;
            int[] array = new int[] {11, 22, 43, 54, 57, 59, 62, 78};
            
            Console.WriteLine("Our array contains: ");
            Array.ForEach(array, x => Console.WriteLine(x + " "));

            Console.WriteLine($"\n\nThe result of a binary search for  {theValue} is: ");
            Console.WriteLine(binarySearch(array, theValue));
        }

        ///<summary>
        /// a = array
        /// x = what we're searching
        /// p = first index
        /// q = midpoint
        /// r = last index
        ///</summary>
        public static int binarySearch(int[] a, int x)
        {
            int p = 0;             //beginning of the range
            int r = a.Length - 1;  // the end of the range, the last slot

            while(p <= r)
            {
                int q = (p+r)/2;   // Find the midpoint
                if (x<a[q])        // if the searched value is less than the value at the midpoint
                {
                    r = q - 1;     // set the new end of range to be one spot less than the midpoint
                }
                else if (x > a[q]) // if the searched value is more than the value at the midpoint
                {
                    p = q + 1;     // set the new beginning of the range to be one spot more than the midpoint
                }
                else               // If the searched value is not higher or lower than the checked value 
                {
                    return q;      // then it must be what we need, so we return its position
                }
            }
            //We didn't find the value we were searching for, so return -1 
            return -1;
        }
    }
}