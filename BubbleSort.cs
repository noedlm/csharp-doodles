using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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
            //int[] nums = randomGenerator();
            //foreach (int num in nums) {
            //    Console.WriteLine("Before sort: " + num);
            //}
            //bubbleSort(nums);
            //foreach (int num in nums) {
            //    Console.WriteLine("After sort: " + num);
            //}
            ///****************************/

            ///*********vampire numbers*********/
            //bool fang = vampireNumber(6, 21);
            //Console.WriteLine(fang);

            //fang = vampireNumber(8, 21);
            //Console.WriteLine(fang);

            /*********************************/

            Console.WriteLine(Shortcut("hello"));
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

        public static string Shortcut (string input) {
            List<char> vowels = new List<char> { 'a', 'e', 'i', 'o', 'u', 'y' };
            Console.WriteLine(input[(input.Length + 1) / 2].ToString());
            foreach (char s in input) {
                Console.WriteLine(vowels.Contains(s));
                if(vowels.Contains(s)) {
                    input = input.Remove(input.IndexOf(s), 1);
                }
            }
            return input;
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