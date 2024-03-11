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
            // 가로 세로 11 씩 가지는 좌표 평면 배열 생성
            int[,,,] check = new int[11, 11, 11, 11];
            // 0.0 부터 5.5 까지 기떄문에 x,y 를 5로 초기화
            int x = 5, y = 5;

            for (int i = -1; ++i < dirs.Length;)
            {
                // 이전의 값과 비교해서 지나온 길인지 아닌지 체크하기 위해 데이터 저장
                int oldX = x, oldY = y;
                // 1개씩 빼와서 체크
                char direction = dirs[i];
                // 문제에 조건대로 움직이도록 세팅
                if (direction == 'U') ++y;
                if (direction == 'D') --y;
                if (direction == 'R') ++x;
                if (direction == 'L') --x;
                // 10보다 크다면 0으로 초기화
                x = MaxOrMin(x);
                y = MaxOrMin(y);
                // 이전 값과 다른지 체크
                if (oldX != x || oldY != y)
                // 이전값과 다르고 좌표의 값이 0인지 체크 후 
                    if (check[oldX, oldY, x, y] == 0)
                    {
                        // 해당 배열에 위치 만큼 이동하도록 설정
                        check[oldX, oldY, x, y] = 1;
                        check[x, y, oldX, oldY] = 1;
                        // 움직임 횟수 증가
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