using System;
using System.Collections;

namespace Taesuuu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution("ULURRDLLU"));
        }
        public static int Solution(string dirs) {
            
            int answer = 0;
            int[,,,] check = new int[11, 11, 11, 11];
            int x = 5, y = 5;

            for (int i = -1; ++i < dirs.Length;)
            {
                int oldX = x, oldY = y;
                char direction = dirs[i];

                if (direction == 'U') ++y;
                if (direction == 'D') --y;
                if (direction == 'R') ++x;
                if (direction == 'L') --x;

                x = MaxOrMin(x);
                y = MaxOrMin(y);

                if (oldX != x || oldY != y)
                    if (check[oldX, oldY, x, y] == 0)
                    {
                        check[oldX, oldY, x, y] = 1;
                        check[x, y, oldX, oldY] = 1;
                        ++answer;
                    }
            }

            return answer;
        }

        static int MaxOrMin(int num) {
            if (num >= 10) {
                return 10;
            }
            if(num <= 0) {
                return 0;
            }
            return num;
        }

    }
}