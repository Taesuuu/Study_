using System;
using System.Collections;

namespace Taesuuu
{
    class Program
    {
        static void Main(string[] args)
        {
            string skill = "CBD";	
            string[] skill_tree = new string[] {"BACDE", "CBADF", "AECB", "BDA"};
            int temp = Solution(skill, skill_tree);
            Console.WriteLine(temp);
        }

        public static int Solution(string skill, string[] skill_trees) {
            int answer = 0;
            try {
                for(int i = 0; i < skill_trees.Length; i++) {
                    bool isCheck = false;
                    int count = 0;
                    char[] temp = skill_trees[i].ToCharArray();
                    for(int j = 0; j < temp.Length; j++) {
                        if(count < skill.IndexOf(temp[j])) {
                            isCheck = true;
                            break;
                        }
                        if(count == skill.IndexOf(temp[j])) {
                            count++;
                        }
                    }
                    if(!isCheck) {
                        answer++;
                    }
                }
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }
            return answer;
        }
    }
}