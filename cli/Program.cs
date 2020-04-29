using System;

namespace cli
{
    // https://stackoverflow.com/a/43035/665507
    // extension to array, like Python's `enumerate()`
    public static class ForEachExtensions
    {
        public static void ForEachWithIndex<T>(this System.Collections.Generic.IEnumerable<T> enumerable, Action<T, int> handler)
        {
            int idx = 0;
            foreach (T item in enumerable)
                handler(item, idx++);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            DateTime input = args.Length != 0 ? DateTime.Parse(args[0]) : now;
            Console.WriteLine("args:");
            args.ForEachWithIndex((item, idx) => Console.WriteLine($"[{idx}]: {item}"));

            Console.WriteLine();
            Console.WriteLine(String.Format($"now: {now:u}", now));
            Console.WriteLine(String.Format($"input: {input:u}", input));
            Console.WriteLine(lib.HumanizerWrapper.Humanize(now - input));
        }
    }
}
