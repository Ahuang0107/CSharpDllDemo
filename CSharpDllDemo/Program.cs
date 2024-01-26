using System.Runtime.InteropServices;

namespace CSharpDllDemo;

internal class Program
{
    private const string NativeLibraryWindows = "Library/DllDemo.dll";
    private const string NativeLibraryMacos = "Library/libDllDemo.dylib";

    [DllImport(NativeLibraryMacos)]
    private static extern int fireman_add(int a, int b);

    private static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");

        var result = fireman_add(10, 15);
        Console.WriteLine(result);
    }
}