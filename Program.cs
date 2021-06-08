using System;
using System.Collections.Generic;


namespace unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> unbox = new List<object>();
            unbox.Add(7);
            unbox.Add(28);
            unbox.Add(-1);
            unbox.Add(true);
            unbox.Add("chair");
            int count=0;
            for (var idx = 0; idx < unbox.Count; idx++)
            {
                if (unbox[idx] is int)
                {
                    count+=(int)unbox[idx];
                }
            }
            Console.WriteLine(count);
        }
    }
}
