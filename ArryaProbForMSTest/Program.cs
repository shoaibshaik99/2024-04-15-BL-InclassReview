namespace ArryaProbForMSTest
{
    public class Arrays
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 5, 4, 3, 2, 1 };
            Console.WriteLine(CheckArrSum(arr1, arr2));
        }

        public static bool CheckArrSum(int[] arr1, int[] arr2)
        {
            if (arr1.Sum() == arr2.Sum())
            {
                return true;
            }
            return false;
        }
    }
}
