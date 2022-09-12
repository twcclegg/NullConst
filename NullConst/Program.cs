using System;
using System.IO;
using System.Runtime;

namespace NullConst
{
    public class Program
    {
        public static void Main()
        {
            new Program().MakeConst();
        }

        public void MakeConst()
        {
            const IList<string> thing = null;
        }
    }
}
