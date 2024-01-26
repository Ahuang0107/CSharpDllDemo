using System.Runtime.InteropServices;

namespace CSharpDllDemo;

internal class Program
{
    private const string NativeLibraryWindows = "../rust_dll_demo/target/release/DllDemo.dll";
    private const string NativeLibraryMacos = "../rust_dll_demo/target/release/libDllDemo.dylib";

    private const string NativeLibrary = NativeLibraryMacos;

    [DllImport(NativeLibrary)]
    private static extern int fireman_add(int a, int b);

    [DllImport(NativeLibrary)]
    private static extern IntPtr new_scene(ulong id);

    [DllImport(NativeLibrary)]
    private static extern ulong get_id(IntPtr scene);

    private static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");

        var addResult = fireman_add(10, 15);
        Console.WriteLine($"Add Result: {addResult}");

        var scene = new_scene(42);

        var id = get_id(scene);
        Console.WriteLine($"Scene ID: {id}");
    }
}