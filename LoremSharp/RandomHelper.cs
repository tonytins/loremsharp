using System;
using System.Threading;

namespace LoremSharp
{
    /*
     * http://stackoverflow.com/a/1785821/234132
     */
    internal static class RandomHelper
    {
        static int seedCounter = new Random().Next();

        [ThreadStatic] static Random rng;

        internal static Random Instance
        {
            get
            {
                if (rng == null)
                {
                    var seed = Interlocked.Increment(ref seedCounter);
                    rng = new Random(seed);
                }
                return rng;
            }
        }
    }
}