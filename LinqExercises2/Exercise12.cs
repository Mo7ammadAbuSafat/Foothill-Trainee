using System.Collections.Generic;

namespace Background1
{
    // Uncomment the TransformationFunction delegate declaration
    //
    // following the examples in the lessons, declare the type
    // TransformationFunction as a delegate that takes a single
    // int parameter and returns an int result.

    // public ... TransformationFunction ...
    public delegate int TransformationFunction(int x);

    // Write the extension method (and containing class) here,
    // following the examples in the lessons. The method should
    // be called Transform(), extend IEnumerable<int>, take an
    // extra parameter of type TransformationFunction, and
    // return an IEnumerable<int>.

    // public ... class ...
    // { }
    public static class TransformClass
    {
        public static IEnumerable<int> Transform(this IEnumerable<int> set, TransformationFunction fun)
        {
            foreach (int x in set)
            {
                yield return fun(x);
            }
        }
    }
} 