namespace ExtensionMethods1
{
    // Write the extension method (and containing class) here,
    // following the example in the lesson. The method should
    // be called SayHello(), extends string, and returns a string.

    // public ... class ...
    // { }
    public static class Extention
    {
        public static string SayHello(this string s)
        {
            return $"Hello, {s}!";
        }
    }
}