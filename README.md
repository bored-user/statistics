# statistics

CLI tool to perform common mathematical statistics calculations (mean, median, mode, standard deviation, order numbers, etc). Implemented in C#.<br>
I've included a `releases` folder, where the program is already compiled. One can run it natively on Windows or using [`mono`](https://www.mono-project.com/) tool on Linux/ Mac.

### Usage

Right after running the program, a terminal window will pop-up, asking for input. One can, then, select one of the given options and input the numbers (comma separated).<br>
If an unexistent option is given, an [`IndexOutOfRangeException`](https://docs.microsoft.com/en-us/dotnet/api/system.indexoutofrangeexception?view=netcore-3.1) will be thrown (but don't worry: it knows how to handle it).<br>
After selecting an option, the user will be prompted to insert comma separated values to perform the calculation uppon (if the format is incorrect, a [`FormatException`](https://docs.microsoft.com/en-us/dotnet/api/system.formatexception?view=netcore-3.1) will be thrown. Again, the program knows how to handle it).<br>
When the user finishes those two prior steps, the program will then compute the result, display it and run the exit routine.

### Building

The project can be built using a tool like [`csc`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-options/command-line-building-with-csc-exe) or [`mcs`](https://www.mono-project.com/docs/about-mono/languages/csharp/) (C# compilers). However, I've already added a [`releases`](https://github.com/bored-user/statistics/tree/master/releases) folder which contains all releases in `statistics_v[version_here].exe` naming format.


[Issues](//github.com/bored-user/statistics/issues) and [pull requests](//github.com/bored-user/statistics/pull) are welcome! Hope you find it useful (I surely will, because I do those calculations with certain frequency). Happy coding!
