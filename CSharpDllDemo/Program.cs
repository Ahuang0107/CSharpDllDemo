using System.Runtime.InteropServices;

namespace CSharpDllDemo;

internal class Program
{
    private const string NativeLibraryWindows = "Library/DllDemo.dll";
    private const string NativeLibraryMacos = "Library/libDllDemo.dylib";

#if WINDOWS
            const string NativeLibrary = NativeLibraryWindows;
#elif MACOS
    private const string NativeLibrary = NativeLibraryMacos;
#else
            const string NativeLibrary = NativeLibraryWindows;
#endif

    [DllImport(NativeLibrary)]
    private static extern int fireman_add(int a, int b);

    private static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");

        var result = fireman_add(10, 15);
        Console.WriteLine(result);
    }
}