﻿using System;

namespace Project_Euler_Problems.Problems
{
    public class P002
    {
        /* Problem 2
         * Even Fibonacci numbers
         * Each new term in the Fibonacci sequence is generated by adding the previous two terms.
         * By starting with 1 and 2, the first 10 terms will be: 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
         * By considering the terms in the Fibonacci sequence whose values do not exceed four million,
         * find the sum of the even-valued terms.
         */

        public static void Start()
        {
            P002 p2 = new P002();
            p2.FindSumOfEvenFibNumbers();
        }

        private void FindSumOfEvenFibNumbers()
        {
            int sequenceMax = 4000000;
            int sumOfEvenNums = 0;
            int previousFibNum = 1;
            int currentFibNum = 2;

            while (currentFibNum < sequenceMax)
            {
                if (currentFibNum % 2 == 0)
                {
                    sumOfEvenNums += currentFibNum;
                }

                int nextFibNum = currentFibNum + previousFibNum;
                previousFibNum = currentFibNum;
                currentFibNum = nextFibNum;
            }
            
            Console.WriteLine(sumOfEvenNums);
        }
    }
}