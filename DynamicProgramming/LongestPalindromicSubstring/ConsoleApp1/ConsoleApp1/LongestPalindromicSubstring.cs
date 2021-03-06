﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LongestPalindromicSubstring
    {
        public string LPS(string str)
        {
            if (string.IsNullOrEmpty(str))
                return string.Empty;

            int n = str.Length;

            //T[i,j] denotes the longest palindromic substring from str[i].....str[j]
            bool[,] T = new bool[n, n];

            int maxLength = 1;
            int startIndex = 0;

            for (int i = 0; i < n; ++i)
                T[i, i] = true;

            for(int i = 0; i < n-1; ++i)
            {
                if(str[i] == str[i+1])
                {
                    T[i, i + 1] = true;
                    maxLength = 2;
                    startIndex = i;
                }
            }

            for(int k = 3; k <= n; ++k)
            {
                for(int i = 0; i <= n-k; ++i)
                {
                    int j = i + k - 1;
                    if(str[i] == str[j] && T[i+1, j-1] == true)
                    {
                        T[i, j] = true;
                        if (k > maxLength)
                        {
                            maxLength = k;
                            startIndex = i;
                        }
                    }
                }
            }

            char[] res = new char[maxLength];
            Array.Copy(str.ToCharArray(), startIndex, res, 0, maxLength);

            return new string(res);
        }
    }
}
