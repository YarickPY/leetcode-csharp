using System.Reflection;
using BenchmarkDotNet.Running;

// Runs every [MemoryDiagnoser]/[Benchmark] class found in this assembly.
//
//   dotnet run -c Release --project benchmarks/LeetCode.Benchmarks            -> interactive menu
//   dotnet run -c Release --project benchmarks/LeetCode.Benchmarks -- --filter *
//   dotnet run -c Release --project benchmarks/LeetCode.Benchmarks -- --filter *NumberOfIslands*
//
// Results land in BenchmarkDotNet.Artifacts/ next to the working directory.
BenchmarkSwitcher.FromAssembly(Assembly.GetExecutingAssembly()).Run(args);
