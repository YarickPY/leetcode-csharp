# LeetCode.Benchmarks

Micro-benchmarks for the solutions in `src/LeetCode`, powered by
[BenchmarkDotNet](https://benchmarkdotnet.org/).

This is a separate console project on purpose: BenchmarkDotNet needs a Release
build and its own host process, neither of which it gets when it lives inside a
unit-test project.

## Running

```bash
# interactive menu
dotnet run -c Release --project benchmarks/LeetCode.Benchmarks

# everything, non-interactive
dotnet run -c Release --project benchmarks/LeetCode.Benchmarks -- --filter *

# one benchmark class
dotnet run -c Release --project benchmarks/LeetCode.Benchmarks -- --filter *NumberOfIslands*
```

`-c Release` is not optional. On a Debug build BenchmarkDotNet's
`OptimizationsValidator` aborts the run before measuring anything:

```
* Assembly LeetCode.Benchmarks which defines benchmarks references non-optimized LeetCode
  If you own this dependency, please, build it in RELEASE.
```

That is the expected behaviour, not a bug - a Debug JIT skips inlining, loop
unrolling and dead-code elimination, so the numbers would describe the JIT rather
than the algorithm. Add `-c Release` and it goes away. (There is a
`ConfigOptions.DisableOptimizationsValidator` escape hatch; do not use it - it
silences the warning without making the measurements meaningful.)

Reports (markdown, csv, html) are written to `BenchmarkDotNet.Artifacts/` in the
working directory; that folder is gitignored.

## Conventions

- One benchmark class per problem, named `LC####_<Problem>Benchmark`, mirroring
  `src/LeetCode/LC####_<Problem>.cs`.
- Alternative implementations that exist only for comparison go in `Baselines/`.
  They are not LeetCode submissions and must not leak into `src/`.
- Inputs are generated from a **fixed seed** so that two runs compare the same
  data. Never use an unseeded `Random` here.
- Solutions that mutate their input (LC0200 does) get a fresh copy per
  invocation, and the copy cost is reported as its own benchmark so it can be
  subtracted.
