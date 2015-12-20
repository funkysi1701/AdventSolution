using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    public class day15
    {
        public static void day_15()
        {
            //Day 15 Challenge
            day15 d15 = new day15();
            Console.WriteLine("Day 15");
            Console.ReadLine();
            Console.WriteLine(d15.buildCookie());
            Console.ReadLine();
            Console.WriteLine(d15.buildHealthyCookie());
            Console.ReadLine();
        }
        public enum properties
        {
            capacity = 0,
            durability = 1,
            flavor = 2,
            texture = 3,
            calories = 4
        }

        public int[] sprinkles = new int[5] { 2, 0, -2, 0, 3 };
        public int[] butterscotch = new int[5] { 0, 5, -3, 0, 3 };
        public int[] chocolate = new int[5] { 0, 0, 5, -1, 8 };
        public int[] candy = new int[5] { 0, -1, 0, 5, 8 };

        public int buildCookie()
        {
            int[,,,] total = new int[101,101,101,101];
            int capacity = 0;
            int durability = 0;
            int flavor = 0;
            int texture = 0;
            int maxTotal = 0;
            for (int i = 0; i < 101; i++)
            {
                for (int j = 0; j < 101; j++)
                {
                    for (int k = 0; k < 101; k++)
                    {
                        for (int l = 0; l < 101; l++)
                        {
                            if (i + j + k + l != 100) continue;
                            capacity = (i * sprinkles[(int)properties.capacity]) + (j * butterscotch[(int)properties.capacity]) + (k * chocolate[(int)properties.capacity]) + (l * candy[(int)properties.capacity]);
                            durability = (i * sprinkles[(int)properties.durability]) + (j * butterscotch[(int)properties.durability]) + (k * chocolate[(int)properties.durability]) + (l * candy[(int)properties.durability]);
                            flavor = (i * sprinkles[(int)properties.flavor]) + (j * butterscotch[(int)properties.flavor]) + (k * chocolate[(int)properties.flavor]) + (l * candy[(int)properties.flavor]);
                            texture = (i * sprinkles[(int)properties.texture]) + (j * butterscotch[(int)properties.texture]) + (k * chocolate[(int)properties.texture]) + (l * candy[(int)properties.texture]);
                            if (capacity < 0) total[i, j, k, l] = 0;
                            else if (durability < 0) total[i, j, k, l] = 0;
                            else if (flavor < 0) total[i, j, k, l] = 0;
                            else if (texture < 0) total[i, j, k, l] = 0;
                            else total[i, j, k, l] = capacity * durability * flavor * texture;
                            if (total[i, j, k, l] > maxTotal) maxTotal = total[i, j, k, l];
                        }
                    }
                }
            }
            return maxTotal;
        }

        public int buildHealthyCookie()
        {
            int[,,,] total = new int[101, 101, 101, 101];
            int capacity = 0;
            int calorie = 0;
            int durability = 0;
            int flavor = 0;
            int texture = 0;
            int maxTotal = 0;
            for (int i = 0; i < 101; i++)
            {
                for (int j = 0; j < 101; j++)
                {
                    for (int k = 0; k < 101; k++)
                    {
                        for (int l = 0; l < 101; l++)
                        {
                            if (i + j + k + l != 100) continue;
                            calorie = (i * sprinkles[(int)properties.calories]) + (j * butterscotch[(int)properties.calories]) + (k * chocolate[(int)properties.calories]) + (l * candy[(int)properties.calories]);
                            if (calorie != 500) continue;
                            capacity = (i * sprinkles[(int)properties.capacity]) + (j * butterscotch[(int)properties.capacity]) + (k * chocolate[(int)properties.capacity]) + (l * candy[(int)properties.capacity]);
                            durability = (i * sprinkles[(int)properties.durability]) + (j * butterscotch[(int)properties.durability]) + (k * chocolate[(int)properties.durability]) + (l * candy[(int)properties.durability]);
                            flavor = (i * sprinkles[(int)properties.flavor]) + (j * butterscotch[(int)properties.flavor]) + (k * chocolate[(int)properties.flavor]) + (l * candy[(int)properties.flavor]);
                            texture = (i * sprinkles[(int)properties.texture]) + (j * butterscotch[(int)properties.texture]) + (k * chocolate[(int)properties.texture]) + (l * candy[(int)properties.texture]);
                            if (capacity < 0) total[i, j, k, l] = 0;
                            else if (durability < 0) total[i, j, k, l] = 0;
                            else if (flavor < 0) total[i, j, k, l] = 0;
                            else if (texture < 0) total[i, j, k, l] = 0;
                            else total[i, j, k, l] = capacity * durability * flavor * texture;
                            if (total[i, j, k, l] > maxTotal) maxTotal = total[i, j, k, l];
                        }
                    }
                }
            }
            return maxTotal;
        }
    }
}
