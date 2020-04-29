using System;
using Humanizer;

namespace lib
{
    public class HumanizerWrapper
    {
        public static string Humanize(TimeSpan input)
        {
            return input.Humanize();
        }
    }
}
