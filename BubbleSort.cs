using System;

namespace doodles {
    class BubbleSort
    {
        public int[] randomsArray { get; set; }

        public BubbleSort()
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
            //BubbleSort bubble = new BubbleSort();

            //Console.WriteLine(bubble.randomsArray[0]);
            //bool isFangs = vampireNumber(10, 11);
            //Console.WriteLine("Are they fangs? " + isFangs.ToString());
            //foreach (int bubba in bubble.randomsArray)
            //{
            //    Console.WriteLine(bubba.ToString());
            //}

            int[] nums = randomGenerator();
            Console.WriteLine(nums.Length);
            for(int i = 0; i < nums.Length - 1; i++ ) {
                for(int j = i + 1; j < nums.Length - 1; j++) {
                    if(nums[i] > nums[j]) {
                        nums[i] += nums[j];
                        nums[j] = nums[i] - nums[j];
                        nums[i] = nums[i] - nums[j];
                    }
                }
                Console.WriteLine(nums[i]);
            }
        }

        public static double twoDecimals(double n) {
            return Math.Round(n, 2, MidpointRounding.AwayFromZero);
        }

        public static bool vampireNumber(long x, long y) {
            string result = (x * y).ToString();
            string fangs = x.ToString() + y.ToString();
            Console.WriteLine(fangs);

            //foreach(string s in result) {
            //    if (result.Split(s).Length - 1 != fangs.Split(s).Length - 1) {
            //        return false;
            //    }
            //}

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