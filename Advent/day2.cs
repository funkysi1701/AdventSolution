using System;
using System.IO;
using System.Linq;

namespace Advent
{
    public class day2
    {
        public int result = 0;
        public int result2 = 0;
        public static void day_2()
        {
            //Day 2 Challenge
            day2 d2 = new day2();
            Console.WriteLine("Day 2");
            Console.WriteLine("The elves are running low on wrapping paper, and so they need to submit an order for more.They have a list of the dimensions(length l, width w, and height h) of each present, and only want to order exactly as much as they need.");
            Console.WriteLine("Fortunately, every present is a box(a perfect right rectangular prism), which makes calculating the required wrapping paper for each gift a little easier: find the surface area of the box, which is 2 * l * w + 2 * w * h + 2 * h * l.The elves also need a little extra paper for each present: the area of the smallest side.");
            Console.WriteLine("All numbers in the elves' list are in feet. How many total square feet of wrapping paper should they order?");
            Console.ReadLine();
            for (int i = 0; i < 1000; i++)
            {
                d2.result = d2.result + d2.area(d2.input[i]);
                d2.result2 = d2.result2 + d2.ribbon(d2.input[i]);
            }
            Console.WriteLine(d2.result);
            Console.ReadLine();
            Console.WriteLine("The elves are also running low on ribbon. Ribbon is all the same width, so they only have to worry about the length they need to order, which they would again like to be exact.");
            Console.WriteLine("The ribbon required to wrap a present is the shortest distance around its sides, or the smallest perimeter of any one face. Each present also requires a bow made out of ribbon as well; the feet of ribbon required for the perfect bow is equal to the cubic feet of volume of the present. Don't ask how they tie the bow, though; they'll never tell.");
            Console.WriteLine(d2.result2);
            Console.ReadLine();
        }
        public int ribbon(string input)
        {
            int w = input.IndexOf("x");
            int width = Convert.ToInt32(input.Substring(0, w));

            int l = input.LastIndexOf("x");
            int length = Convert.ToInt32(input.Substring(w + 1, l - (w + 1)));

            int h = input.Length;
            int height = Convert.ToInt32(input.Substring(l + 1, h - (l + 1)));

            int[] smallest = new int[3] { width + width + height + height, length + length + height + height, length + length + width + width };
            int extra = smallest.Min();

            return extra + (height * width * length);

        }
        public int area(string input)
        {
            int w = input.IndexOf("x");
            int width = Convert.ToInt32(input.Substring(0, w));

            int l = input.LastIndexOf("x");
            int length = Convert.ToInt32(input.Substring(w + 1, l - (w + 1)));

            int h = input.Length;
            int height = Convert.ToInt32(input.Substring(l + 1, h - (l + 1)));

            int[] smallest = new int[3] { width * height, width * length, length * height };
            int extra = smallest.Min();

            return 2 * height * length + 2 * width * height + 2 * length * width + extra;
        }

        public string[] input = File.ReadAllLines("../../day2.txt");
    }
}
