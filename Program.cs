namespace Week_6_Challenge_Labs._1
{
    internal class Program
    {
        static int SingleNumber(int[] nums)
        {
            int result = 0;

            foreach (int num in nums)
            {
                result ^= num;
            }

            return result;
        }

        static void Main(string[] args)
        {
            int[] nums1 = { 2, 2, 1 };
            int[] nums2 = { 4, 1, 2, 1, 2 };
            int[] nums3 = { 1 };

            Console.WriteLine(SingleNumber(nums1)); 
            Console.WriteLine(SingleNumber(nums2)); 
        }
    }
}
