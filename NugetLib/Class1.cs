using System.Runtime.InteropServices;

namespace NugetLib
{
    public class Class1
    {
        [DllImport("DemoLib",EntryPoint = "add")]
        public static extern int Add(int a, int b);
    }
}

