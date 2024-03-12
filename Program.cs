using System;
using System.Collections;

namespace Taesuuu
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = new long[] {2,7};
            long[] temp = solution(numbers);
            foreach(long i in temp) {
                Console.WriteLine(i);
            }
        }

        public static long[] solution(long[] numbers) {
            List<long> answer = new List<long>();
            foreach (long number in numbers) {
                answer.Add(FindNextNumber(number));
            }
            return answer.ToArray();
        }

        static long FindNextNumber(long number) {
            long temp = 0;
            // 입력 받은 수가 짝수면 + 1 하면 2개 비트 이하로 차이
            if (number % 2 == 0)
                temp = number + 1;
            else {
                // 홀수 일 경우는 마지막 수를 0으로 변경하고 
                // 7이기에 111
                string s = Convert.ToString(number, 2);
                int idx = s.LastIndexOf("0");
                // 0에 대한 인덱스 체크
                if (idx == -1){
                    s = "10" + s.Substring(1);
                }
                else {
                    // 구한 인덱스에 0을 추가하고 나머지 2개 제외한 비트 0으로 변환
                    s = s.Substring(0, idx) + "10" + s.Substring(idx + 2);
                }
                temp =   Convert.ToInt64(s,2);
                
            }
            return temp;
        }

    }
}

// using System;
// using System.Collections;
// using System.Collections.Generic;

// public class Solution {
//       public long[] solution(long[] numbers) {
//         List<long> answer = new List<long>();
//         foreach (long number in numbers) {
//             answer.Add(FindNextNumber(number));
//         }
//         return answer.ToArray();
//     }

//     static long FindNextNumber(long number) {
//         long temp = number;
//         while (true) {
//             long nextNumber = ++temp;
//             int bitDifference = BitDifference(number, nextNumber);
//             if (2 >= bitDifference) {
//                 return nextNumber;
//             }
//         }
//     }
//     모든 비트를 비교했기 떄문에 로직은 맞지만 long에 큰 수가 오게 되면 시간 초과 발생
//     static int BitDifference(long a, long b) {
//         long xor = a ^ b;
//         int count = 0;
//         while (xor != 0) {
//             count += (int)(xor & 1);
//             xor >>= 1;
//         }
//         return count;
//     }

// }