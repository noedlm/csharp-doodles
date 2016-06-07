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
            BubbleSort bubble = new BubbleSort();

            //Console.WriteLine(bubble.randomsArray[0]);

            foreach (int bubba in bubble.randomsArray)
            {
                Console.WriteLine(bubba.ToString());
            }
        }
    }
}