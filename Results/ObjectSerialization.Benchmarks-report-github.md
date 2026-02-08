```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7623/25H2/2025Update/HudsonValley2)
Intel Core i9-14900K 3.20GHz, 1 CPU, 32 logical and 24 physical cores
.NET SDK 10.0.102
  [Host]    : .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3
  .NET 10.0 : .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3
  .NET 8.0  : .NET 8.0.23 (8.0.23, 8.0.2325.60607), X64 RyuJIT x86-64-v3


```
| Method                                                | Job       | Runtime   | Model         | Mean       | Error    | StdDev   | Skewness | Kurtosis | Gen0   | Gen1   | Allocated |
|------------------------------------------------------ |---------- |---------- |-------------- |-----------:|---------:|---------:|---------:|---------:|-------:|-------:|----------:|
| **Json**                                                  | **.NET 10.0** | **.NET 10.0** | **EnormousModel** | **1,958.1 ns** | **15.92 ns** | **14.89 ns** |  **-0.3071** |    **2.090** | **0.3510** |      **-** |    **6664 B** |
| SplitStringInterpolation                              | .NET 10.0 | .NET 10.0 | EnormousModel | 2,496.2 ns | 15.26 ns | 12.74 ns |   0.0126 |    2.276 | 0.2861 |      - |    5432 B |
| StringJoinDynamic                                     | .NET 10.0 | .NET 10.0 | EnormousModel | 3,663.7 ns | 23.03 ns | 21.54 ns |   0.4902 |    1.534 | 1.2512 | 0.0229 |   23536 B |
| StringBuilderWithAppends                              | .NET 10.0 | .NET 10.0 | EnormousModel | 3,279.7 ns | 16.59 ns | 15.52 ns |  -0.2638 |    2.271 | 0.9155 | 0.0267 |   17232 B |
| StringBuilderWithInterpolatedAppends                  | .NET 10.0 | .NET 10.0 | EnormousModel | 3,349.5 ns | 18.29 ns | 17.11 ns |   0.6265 |    2.158 | 0.7629 | 0.0229 |   14424 B |
| StringBuilderWithAppendsAndPresetCapacity             | .NET 10.0 | .NET 10.0 | EnormousModel | 3,280.6 ns | 12.14 ns | 10.14 ns |  -0.2385 |    2.269 | 0.9384 | 0.0305 |   17656 B |
| StringBuilderWithInterpolatedAppendsAndPresetCapacity | .NET 10.0 | .NET 10.0 | EnormousModel | 3,240.2 ns | 12.23 ns | 11.44 ns |   0.0714 |    2.543 | 0.7858 | 0.0229 |   14856 B |
| Json                                                  | .NET 8.0  | .NET 8.0  | EnormousModel | 2,332.4 ns | 20.62 ns | 19.29 ns |   0.4852 |    2.065 | 0.3510 |      - |    6664 B |
| SplitStringInterpolation                              | .NET 8.0  | .NET 8.0  | EnormousModel | 2,787.6 ns | 22.96 ns | 20.35 ns |   0.2300 |    2.276 | 0.2861 |      - |    5440 B |
| StringJoinDynamic                                     | .NET 8.0  | .NET 8.0  | EnormousModel | 4,690.6 ns | 20.40 ns | 19.08 ns |   0.2472 |    1.459 | 1.2512 | 0.0076 |   23560 B |
| StringBuilderWithAppends                              | .NET 8.0  | .NET 8.0  | EnormousModel | 4,324.5 ns | 26.69 ns | 23.66 ns |  -0.2682 |    2.028 | 0.9079 | 0.0229 |   17224 B |
| StringBuilderWithInterpolatedAppends                  | .NET 8.0  | .NET 8.0  | EnormousModel | 4,413.3 ns | 17.89 ns | 16.74 ns |  -0.4883 |    2.671 | 0.7629 | 0.0229 |   14424 B |
| StringBuilderWithAppendsAndPresetCapacity             | .NET 8.0  | .NET 8.0  | EnormousModel | 4,369.0 ns | 20.70 ns | 17.28 ns |  -0.0159 |    1.754 | 0.9384 | 0.0305 |   17656 B |
| StringBuilderWithInterpolatedAppendsAndPresetCapacity | .NET 8.0  | .NET 8.0  | EnormousModel | 4,291.5 ns | 36.34 ns | 33.99 ns |  -0.4594 |    1.986 | 0.7858 | 0.0229 |   14848 B |
| **Json**                                                  | **.NET 10.0** | **.NET 10.0** | **LargeModel**    |   **999.6 ns** |  **6.94 ns** |  **5.80 ns** |   **1.1000** |    **3.217** | **0.1888** |      **-** |    **3576 B** |
| SplitStringInterpolation                              | .NET 10.0 | .NET 10.0 | LargeModel    | 1,155.6 ns |  4.85 ns |  4.54 ns |  -0.4447 |    1.956 | 0.1469 |      - |    2792 B |
| StringJoinDynamic                                     | .NET 10.0 | .NET 10.0 | LargeModel    | 1,890.4 ns |  6.64 ns |  5.88 ns |  -1.8925 |    6.463 | 0.6428 | 0.0019 |   12104 B |
| StringBuilderWithAppends                              | .NET 10.0 | .NET 10.0 | LargeModel    | 1,721.3 ns |  6.35 ns |  5.94 ns |  -0.0656 |    1.604 | 0.4387 | 0.0057 |    8256 B |
| StringBuilderWithInterpolatedAppends                  | .NET 10.0 | .NET 10.0 | LargeModel    | 1,733.5 ns |  6.15 ns |  5.46 ns |  -0.8391 |    2.866 | 0.3586 | 0.0038 |    6776 B |
| StringBuilderWithAppendsAndPresetCapacity             | .NET 10.0 | .NET 10.0 | LargeModel    | 1,737.8 ns |  3.99 ns |  3.33 ns |  -0.6991 |    2.837 | 0.4883 | 0.0076 |    9192 B |
| StringBuilderWithInterpolatedAppendsAndPresetCapacity | .NET 10.0 | .NET 10.0 | LargeModel    | 1,673.7 ns |  7.27 ns |  6.07 ns |   0.8717 |    2.337 | 0.4082 | 0.0057 |    7704 B |
| Json                                                  | .NET 8.0  | .NET 8.0  | LargeModel    | 1,198.0 ns |  5.81 ns |  5.43 ns |   0.0170 |    2.191 | 0.1888 |      - |    3560 B |
| SplitStringInterpolation                              | .NET 8.0  | .NET 8.0  | LargeModel    | 1,345.0 ns |  8.10 ns |  6.76 ns |   0.3688 |    1.770 | 0.1469 |      - |    2792 B |
| StringJoinDynamic                                     | .NET 8.0  | .NET 8.0  | LargeModel    | 2,453.9 ns | 11.45 ns | 10.71 ns |   0.0712 |    2.064 | 0.6409 |      - |   12096 B |
| StringBuilderWithAppends                              | .NET 8.0  | .NET 8.0  | LargeModel    | 2,208.7 ns | 16.28 ns | 13.59 ns |   0.8054 |    3.005 | 0.4387 | 0.0038 |    8256 B |
| StringBuilderWithInterpolatedAppends                  | .NET 8.0  | .NET 8.0  | LargeModel    | 2,289.8 ns | 12.87 ns | 12.03 ns |   0.4875 |    1.650 | 0.3586 | 0.0038 |    6776 B |
| StringBuilderWithAppendsAndPresetCapacity             | .NET 8.0  | .NET 8.0  | LargeModel    | 2,249.4 ns | 14.43 ns | 13.50 ns |  -0.0706 |    1.494 | 0.4845 | 0.0076 |    9184 B |
| StringBuilderWithInterpolatedAppendsAndPresetCapacity | .NET 8.0  | .NET 8.0  | LargeModel    | 2,323.5 ns | 14.66 ns | 13.71 ns |   0.2750 |    1.738 | 0.4082 | 0.0038 |    7704 B |
| **Json**                                                  | **.NET 10.0** | **.NET 10.0** | **MediumModel**   |   **388.3 ns** |  **1.18 ns** |  **1.11 ns** |   **0.5577** |    **2.168** | **0.0806** |      **-** |    **1520 B** |
| SplitStringInterpolation                              | .NET 10.0 | .NET 10.0 | MediumModel   |   391.0 ns |  2.15 ns |  1.90 ns |  -0.2604 |    2.771 | 0.0553 |      - |    1048 B |
| StringJoinDynamic                                     | .NET 10.0 | .NET 10.0 | MediumModel   |   693.9 ns |  3.23 ns |  2.86 ns |  -0.1081 |    1.622 | 0.2403 |      - |    4536 B |
| StringBuilderWithAppends                              | .NET 10.0 | .NET 10.0 | MediumModel   |   737.5 ns |  7.08 ns |  6.62 ns |   0.5115 |    2.016 | 0.2308 | 0.0019 |    4352 B |
| StringBuilderWithInterpolatedAppends                  | .NET 10.0 | .NET 10.0 | MediumModel   |   732.9 ns |  5.84 ns |  5.18 ns |  -0.2104 |    2.537 | 0.1402 |      - |    2656 B |
| StringBuilderWithAppendsAndPresetCapacity             | .NET 10.0 | .NET 10.0 | MediumModel   |   665.0 ns |  7.28 ns |  6.81 ns |   0.8070 |    2.500 | 0.1936 | 0.0010 |    3648 B |
| StringBuilderWithInterpolatedAppendsAndPresetCapacity | .NET 10.0 | .NET 10.0 | MediumModel   |   611.7 ns |  2.66 ns |  2.49 ns |  -0.6138 |    2.364 | 0.1612 | 0.0010 |    3048 B |
| Json                                                  | .NET 8.0  | .NET 8.0  | MediumModel   |   469.5 ns |  1.98 ns |  1.66 ns |  -0.4332 |    2.389 | 0.0806 |      - |    1520 B |
| SplitStringInterpolation                              | .NET 8.0  | .NET 8.0  | MediumModel   |   450.8 ns |  1.04 ns |  0.92 ns |   0.1183 |    1.432 | 0.0553 |      - |    1048 B |
| StringJoinDynamic                                     | .NET 8.0  | .NET 8.0  | MediumModel   |   918.1 ns |  3.71 ns |  3.29 ns |   0.2183 |    1.696 | 0.2403 |      - |    4536 B |
| StringBuilderWithAppends                              | .NET 8.0  | .NET 8.0  | MediumModel   |   899.5 ns |  6.95 ns |  5.81 ns |  -0.2181 |    1.555 | 0.2308 | 0.0019 |    4352 B |
| StringBuilderWithInterpolatedAppends                  | .NET 8.0  | .NET 8.0  | MediumModel   |   879.3 ns |  2.93 ns |  2.74 ns |  -0.0676 |    2.334 | 0.1402 |      - |    2656 B |
| StringBuilderWithAppendsAndPresetCapacity             | .NET 8.0  | .NET 8.0  | MediumModel   |   833.0 ns |  2.23 ns |  2.09 ns |  -0.1851 |    1.967 | 0.1936 | 0.0010 |    3648 B |
| StringBuilderWithInterpolatedAppendsAndPresetCapacity | .NET 8.0  | .NET 8.0  | MediumModel   |   814.9 ns |  2.95 ns |  2.61 ns |  -0.6654 |    2.285 | 0.1612 | 0.0010 |    3048 B |
| **Json**                                                  | **.NET 10.0** | **.NET 10.0** | **SmallModel**    |   **143.9 ns** |  **0.70 ns** |  **0.62 ns** |   **0.0267** |    **2.322** | **0.0279** |      **-** |     **528 B** |
| SplitStringInterpolation                              | .NET 10.0 | .NET 10.0 | SmallModel    |   157.6 ns |  0.78 ns |  0.73 ns |  -0.4718 |    1.683 | 0.0246 |      - |     464 B |
| StringJoinDynamic                                     | .NET 10.0 | .NET 10.0 | SmallModel    |   302.1 ns |  2.29 ns |  2.14 ns |   0.9480 |    2.471 | 0.1059 |      - |    2000 B |
| StringBuilderWithAppends                              | .NET 10.0 | .NET 10.0 | SmallModel    |   345.7 ns |  3.06 ns |  2.72 ns |  -0.5114 |    2.883 | 0.1111 | 0.0005 |    2096 B |
| StringBuilderWithInterpolatedAppends                  | .NET 10.0 | .NET 10.0 | SmallModel    |   445.1 ns |  0.99 ns |  0.88 ns |   0.3880 |    2.172 | 0.0958 |      - |    1808 B |
| StringBuilderWithAppendsAndPresetCapacity             | .NET 10.0 | .NET 10.0 | SmallModel    |   301.7 ns |  1.80 ns |  1.69 ns |  -0.4525 |    1.871 | 0.0963 |      - |    1816 B |
| StringBuilderWithInterpolatedAppendsAndPresetCapacity | .NET 10.0 | .NET 10.0 | SmallModel    |   430.4 ns |  1.32 ns |  1.17 ns |   0.6208 |    1.793 | 0.0811 |      - |    1528 B |
| Json                                                  | .NET 8.0  | .NET 8.0  | SmallModel    |   172.4 ns |  1.18 ns |  1.10 ns |   0.4226 |    2.476 | 0.0279 |      - |     528 B |
| SplitStringInterpolation                              | .NET 8.0  | .NET 8.0  | SmallModel    |   174.8 ns |  1.17 ns |  1.09 ns |   0.4605 |    2.269 | 0.0246 |      - |     464 B |
| StringJoinDynamic                                     | .NET 8.0  | .NET 8.0  | SmallModel    |         NA |       NA |       NA |       NA |       NA |     NA |     NA |        NA |
| StringBuilderWithAppends                              | .NET 8.0  | .NET 8.0  | SmallModel    |   393.3 ns |  1.77 ns |  1.38 ns |  -0.3532 |    1.387 | 0.1111 | 0.0005 |    2096 B |
| StringBuilderWithInterpolatedAppends                  | .NET 8.0  | .NET 8.0  | SmallModel    |   546.6 ns |  3.49 ns |  3.09 ns |  -0.0622 |    2.521 | 0.0954 |      - |    1808 B |
| StringBuilderWithAppendsAndPresetCapacity             | .NET 8.0  | .NET 8.0  | SmallModel    |   358.2 ns |  1.22 ns |  1.02 ns |   0.2922 |    2.405 | 0.0963 |      - |    1816 B |
| StringBuilderWithInterpolatedAppendsAndPresetCapacity | .NET 8.0  | .NET 8.0  | SmallModel    |   555.8 ns |  4.35 ns |  3.86 ns |  -0.1525 |    1.542 | 0.0811 |      - |    1528 B |

Benchmarks with issues:
  Benchmarks.StringJoinDynamic: .NET 8.0(Runtime=.NET 8.0) [Model=SmallModel]
