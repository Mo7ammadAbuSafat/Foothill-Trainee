using System.Collections.Generic;

namespace Generators1
{
    public static class GeneratorsExercise1
    {
        // Write a method that implements a generator
        // for the sequence of integers that follows
        // the pattern prev + 2, prev x 2, prev + 2, etc.
        //
        // The method should be called AddTwoThenDouble()
        // and should take no parameters.

        // public static ... AddTwoThenDouble()
        // {
        // }
        public static IEnumerable<int> AddTwoThenDouble()
        {
            int evenOrOdd = 0;
            int nextVal = 0;

            while (true)
            {
                nextVal = evenOrOdd % 2 == 0 ? nextVal + 2 : nextVal * 2;
                evenOrOdd++;
                yield return nextVal;
            }
        }
    }
}