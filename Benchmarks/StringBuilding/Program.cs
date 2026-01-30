using BenchmarkDotNet.Running;

//StringBuilding.Generator.Generate();

BenchmarkSwitcher
  .FromAssembly(typeof(Program).Assembly)
  .Run(args);