using System.Runtime.InteropServices;

namespace CSharpDllDemo;

internal class Program
{
    [DllImport("Library/DllDemo.dll")]
    private static extern int fireman_add(int a, int b);

    private static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");

        var result = fireman_add(10, 15);
        Console.WriteLine(result);
    }
}