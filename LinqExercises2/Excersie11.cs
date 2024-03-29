﻿using System.Collections.Generic;

namespace Generators2
{
    public static class GeneratorsExercise2
    {
        // Write a method that implements a bounded 
        // generator, providing the first n values
        // for the sequence of integers that follows
        // the pattern prev + 2, prev x 2, prev + 2, etc.
        // where n is passed in to the method.
        //
        // The method should be called AddTwoThenDouble()
        // and should take a single integer parameter.

        // public static ... AddTwoThenDouble(int n)
        // {
        // }
        public static IEnumerable<int> AddTwoThenDouble(int n)
        {
            int nextVal = 0;

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    nextVal = nextVal + 2;
                }
                else
                {
                    nextVal = nextVal * 2;
                }  
                yield return nextVal;
            }
        }
    }
}