using System;
using System.Collections;

namespace Taesuuu
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = Solution(new int[] {5,1,3,7}, new int[]{2,2,6,8});
            Console.WriteLine(temp);
        }

        public static int Solution(int[] A, int[] B) {
            int answer = 0;
            Array.Sort(A);
            Array.Sort(B);
            int index = -1;
            for(int i = 0; i < A.Length; i++) {
                for(int j = index + 1; j < A.Length; j++) {
                    if(A[i] < B[j]) {
                        answer++;
                        index = j;
                        break;
                    }
                }
            }
            return answer;
        }
    }
}