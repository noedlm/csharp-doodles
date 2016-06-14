using System;
using System.Collections;

namespace doodles {
    class BubbleSortClass
    {
        public int[] randomsArray { get; set; }

        public BubbleSortClass()
        {
            Random randomnumber = new Random();
            randomsArray = new int[100];
            for (int i = 0; i < 100; i++)
            {
                randomsArray[i] = randomnumber.Next(0, 300);
            }
        }
    }

    public class MainClass {
        static void Main() {
            /*********bubblesort*********/
            int[] nums = randomGenerator();
            foreach (int num in nums) {
                Console.WriteLine("Before sort: " + num);
            }
            bubbleSort(nums);
            foreach (int num in nums) {
                Console.WriteLine("After sort: " + num);
            }
            /****************************/

            /*********vampire numbers*********/
            bool fang = vampireNumber(6, 21);
            Console.WriteLine(fang);

            fang = vampireNumber(8, 21);
            Console.WriteLine(fang);

            /*********************************/
        }

        public static void bubbleSort(int[] nums) {
            for (int i = 0; i < nums.Length - 1; i++) {
                for (int j = i + 1; j < nums.Length - 1; j++) {
                    if (nums[i] > nums[j]) {
                        nums[i] += nums[j];
                        nums[j] = nums[i] - nums[j];
                        nums[i] = nums[i] - nums[j];
                    }
                }
            }
        }

        public static double twoDecimals(double n) {
            return Math.Round(n, 2, MidpointRounding.AwayFromZero);
        }

        public static bool vampireNumber(long x, long y) {
            string result = (x * y).ToString();
            string fangs = x.ToString() + y.ToString();

            if (x < 0 && y < 0) { return false; }
            foreach (char f in fangs) {
                if (result.Length == 0) { return false; }

                if (result.Contains(f.ToString())) {
                    int remove = result.LastIndexOf(f);
                    result = result.Remove(remove, 1);
                } else {
                    return false;
                }
            }
            return true;
        }

        public static int[] randomGenerator() {
            Random rand = new Random();
            int[] numbers = new int[100];

            for(int i = 0; i < 100; i++) {
                numbers[i] = rand.Next(0, 500);
            }
            return numbers;
        }
    }
}