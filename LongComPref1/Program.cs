using System;
/*
 * Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".

Example 1:

Input: ["flower","flow","flight"]
Output: "fl"
Example 2:

Input: ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.
Note:

All given inputs are in lowercase letters a-z.
 * */
namespace LongComPref1
{
    class Program
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
                return "";

            string s0 = strs[0];
            if (strs.Length == 1)
                return s0;

            string pref = "";
            for (int i = 0; i < s0.Length; i++)
            {
                //find each symbol from zero element of array
                //start from zero position

                //strart to find from 2nd element in array
                for (int y = 1; y < strs.Length; y++)
                {
                    string s1 = strs[y];
                    int len1 = s1.Length;
                    if (len1 - 1 >= i)
                    {
                        if (s0[i] != s1[i])
                            return pref;
                    }
                    else
                        return pref;
                }
                pref = pref + s0[i];
            }
            return pref;
        }

        public static void Main(string[] args)
        {
            string[] str = new string[] { "aa", "a"};
            string s = LongestCommonPrefix(str);
            Console.WriteLine(s);
        }
    }
}
