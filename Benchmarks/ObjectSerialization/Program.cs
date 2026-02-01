using BenchmarkDotNet.Running;

//ObjectSerialization.CodeGenerator.Generate();

BenchmarkSwitcher
  .FromAssembly(typeof(Program).Assembly)
  .Run(args);