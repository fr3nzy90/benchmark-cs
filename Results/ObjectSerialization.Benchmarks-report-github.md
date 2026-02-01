```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7623/25H2/2025Update/HudsonValley2)
Intel Core i9-14900K 3.20GHz, 1 CPU, 32 logical and 24 physical cores
.NET SDK 10.0.102
  [Host]    : .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3
  .NET 10.0 : .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3
  .NET 8.0  : .NET 8.0.23 (8.0.23, 8.0.2325.60607), X64 RyuJIT x86-64-v3


```
| Method                                                              | Job       | Runtime   | Model         | Mean        | Error     | StdDev    | Skewness | Kurtosis | Gen0    | Gen1   | Allocated |
|-------------------------------------------------------------------- |---------- |---------- |-------------- |------------:|----------:|----------:|---------:|---------:|--------:|-------:|----------:|
| **JsonSerialization**                                                   | **.NET 10.0** | **.NET 10.0** | **EnormousModel** |  **1,832.9 ns** |  **14.65 ns** |  **12.98 ns** |   **0.0438** |    **1.808** |  **0.3529** |      **-** |    **6648 B** |
| InterpolatedSerialization                                           | .NET 10.0 | .NET 10.0 | EnormousModel |  2,563.8 ns |  16.73 ns |  15.65 ns |  -0.2556 |    2.515 |  0.2899 |      - |    5488 B |
| SplitInterpolatedSerialization                                      | .NET 10.0 | .NET 10.0 | EnormousModel |  2,573.1 ns |  13.24 ns |  12.38 ns |   0.0282 |    1.944 |  0.2899 |      - |    5472 B |
| DynamicInterpolatedSerialization                                    | .NET 10.0 | .NET 10.0 | EnormousModel |  9,486.7 ns |  54.83 ns |  42.81 ns |   0.4999 |    2.906 | 11.5204 | 0.1678 |  216803 B |
| DynamicStringJoinSerialization                                      | .NET 10.0 | .NET 10.0 | EnormousModel |  3,923.6 ns |  23.59 ns |  22.06 ns |   0.3105 |    1.932 |  1.2512 | 0.0076 |   23672 B |
| StringBuilderWithAppendsSerialization                               | .NET 10.0 | .NET 10.0 | EnormousModel |  3,510.1 ns |  14.10 ns |  13.19 ns |  -0.2909 |    1.966 |  0.9155 | 0.0267 |   17280 B |
| StringBuilderWithInterpolatedAppendsSerialization                   | .NET 10.0 | .NET 10.0 | EnormousModel |  3,629.5 ns |  10.99 ns |   9.18 ns |   0.6402 |    1.839 |  0.7668 | 0.0229 |   14480 B |
| StringBuilderWithAppendsWithPresetCapacitySerialization             | .NET 10.0 | .NET 10.0 | EnormousModel |  3,569.1 ns |  16.03 ns |  13.39 ns |  -0.0767 |    1.796 |  0.9384 | 0.0305 |   17704 B |
| StringBuilderWithInterpolatedAppendsWithPresetCapacitySerialization | .NET 10.0 | .NET 10.0 | EnormousModel |  3,319.9 ns |  16.48 ns |  14.61 ns |  -1.2328 |    4.196 |  0.7896 | 0.0267 |   14912 B |
| JsonSerialization                                                   | .NET 8.0  | .NET 8.0  | EnormousModel |  2,315.8 ns |  14.22 ns |  13.30 ns |   0.2867 |    1.419 |  0.3548 |      - |    6672 B |
| InterpolatedSerialization                                           | .NET 8.0  | .NET 8.0  | EnormousModel |  2,826.5 ns |  17.46 ns |  16.34 ns |  -0.0575 |    1.705 |  0.2899 |      - |    5496 B |
| SplitInterpolatedSerialization                                      | .NET 8.0  | .NET 8.0  | EnormousModel |  2,754.8 ns |  14.32 ns |  12.69 ns |   0.2721 |    1.888 |  0.2899 |      - |    5488 B |
| DynamicInterpolatedSerialization                                    | .NET 8.0  | .NET 8.0  | EnormousModel | 12,751.2 ns | 127.08 ns | 112.65 ns |  -0.2605 |    1.616 | 11.5204 | 0.1526 |  216947 B |
| DynamicStringJoinSerialization                                      | .NET 8.0  | .NET 8.0  | EnormousModel |  4,867.0 ns |  25.81 ns |  24.14 ns |   0.1538 |    1.316 |  1.2589 | 0.0229 |   23696 B |
| StringBuilderWithAppendsSerialization                               | .NET 8.0  | .NET 8.0  | EnormousModel |  4,318.7 ns |  29.69 ns |  24.79 ns |  -0.0096 |    2.157 |  0.9155 | 0.0229 |   17280 B |
| StringBuilderWithInterpolatedAppendsSerialization                   | .NET 8.0  | .NET 8.0  | EnormousModel |  4,579.0 ns |  20.69 ns |  19.35 ns |  -0.1506 |    1.855 |  0.7629 | 0.0229 |   14480 B |
| StringBuilderWithAppendsWithPresetCapacitySerialization             | .NET 8.0  | .NET 8.0  | EnormousModel |  4,454.4 ns |  23.69 ns |  21.00 ns |  -0.0512 |    1.457 |  0.9384 | 0.0305 |   17704 B |
| StringBuilderWithInterpolatedAppendsWithPresetCapacitySerialization | .NET 8.0  | .NET 8.0  | EnormousModel |  4,600.9 ns |  23.37 ns |  21.86 ns |   0.4484 |    1.734 |  0.7858 | 0.0229 |   14904 B |
| **JsonSerialization**                                                   | **.NET 10.0** | **.NET 10.0** | **LargeModel**    |    **976.1 ns** |   **6.96 ns** |   **6.51 ns** |   **0.0153** |    **1.675** |  **0.1888** |      **-** |    **3560 B** |
| InterpolatedSerialization                                           | .NET 10.0 | .NET 10.0 | LargeModel    |  1,321.6 ns |   7.00 ns |   6.55 ns |  -0.2371 |    1.955 |  0.1488 |      - |    2824 B |
| SplitInterpolatedSerialization                                      | .NET 10.0 | .NET 10.0 | LargeModel    |  1,281.5 ns |   8.68 ns |   8.12 ns |   0.3003 |    1.692 |  0.1488 |      - |    2816 B |
| DynamicInterpolatedSerialization                                    | .NET 10.0 | .NET 10.0 | LargeModel    |  3,537.1 ns |  23.75 ns |  19.83 ns |  -0.1697 |    1.663 |  3.2387 | 0.0191 |   60993 B |
| DynamicStringJoinSerialization                                      | .NET 10.0 | .NET 10.0 | LargeModel    |  1,980.9 ns |  11.35 ns |  10.06 ns |   1.1348 |    3.017 |  0.6447 |      - |   12136 B |
| StringBuilderWithAppendsSerialization                               | .NET 10.0 | .NET 10.0 | LargeModel    |  1,772.0 ns |   5.72 ns |   5.35 ns |   0.1410 |    1.424 |  0.4387 | 0.0057 |    8288 B |
| StringBuilderWithInterpolatedAppendsSerialization                   | .NET 10.0 | .NET 10.0 | LargeModel    |  1,800.5 ns |   5.13 ns |   4.55 ns |   0.8086 |    2.651 |  0.3605 | 0.0038 |    6816 B |
| StringBuilderWithAppendsWithPresetCapacitySerialization             | .NET 10.0 | .NET 10.0 | LargeModel    |  1,837.5 ns |   6.89 ns |   6.11 ns |  -0.5045 |    2.208 |  0.4883 | 0.0076 |    9216 B |
| StringBuilderWithInterpolatedAppendsWithPresetCapacitySerialization | .NET 10.0 | .NET 10.0 | LargeModel    |  1,746.9 ns |   5.96 ns |   4.65 ns |   0.4397 |    3.080 |  0.4101 | 0.0057 |    7736 B |
| JsonSerialization                                                   | .NET 8.0  | .NET 8.0  | LargeModel    |  1,230.7 ns |   5.15 ns |   4.82 ns |  -0.3633 |    1.808 |  0.1888 |      - |    3568 B |
| InterpolatedSerialization                                           | .NET 8.0  | .NET 8.0  | LargeModel    |  1,509.4 ns |   7.49 ns |   6.64 ns |  -0.1331 |    2.155 |  0.1488 |      - |    2816 B |
| SplitInterpolatedSerialization                                      | .NET 8.0  | .NET 8.0  | LargeModel    |  1,499.8 ns |   9.05 ns |   7.56 ns |  -0.1922 |    1.554 |  0.1488 |      - |    2824 B |
| DynamicInterpolatedSerialization                                    | .NET 8.0  | .NET 8.0  | LargeModel    |  4,794.0 ns |  42.96 ns |  40.18 ns |  -0.5471 |    2.047 |  3.2349 | 0.0305 |   60897 B |
| DynamicStringJoinSerialization                                      | .NET 8.0  | .NET 8.0  | LargeModel    |  2,563.2 ns |  21.11 ns |  18.71 ns |   0.3909 |    1.771 |  0.6447 |      - |   12176 B |
| StringBuilderWithAppendsSerialization                               | .NET 8.0  | .NET 8.0  | LargeModel    |  2,253.9 ns |  12.44 ns |  11.64 ns |  -0.2109 |    1.683 |  0.4387 | 0.0038 |    8288 B |
| StringBuilderWithInterpolatedAppendsSerialization                   | .NET 8.0  | .NET 8.0  | LargeModel    |  2,321.2 ns |  11.83 ns |  11.07 ns |   0.1651 |    1.498 |  0.3586 | 0.0038 |    6800 B |
| StringBuilderWithAppendsWithPresetCapacitySerialization             | .NET 8.0  | .NET 8.0  | LargeModel    |  2,337.4 ns |   7.28 ns |   6.81 ns |  -0.1670 |    1.325 |  0.4883 | 0.0076 |    9224 B |
| StringBuilderWithInterpolatedAppendsWithPresetCapacitySerialization | .NET 8.0  | .NET 8.0  | LargeModel    |  2,313.5 ns |  11.98 ns |  11.20 ns |   0.6510 |    2.440 |  0.4082 | 0.0038 |    7736 B |
| **JsonSerialization**                                                   | **.NET 10.0** | **.NET 10.0** | **MediumModel**   |    **392.7 ns** |   **1.96 ns** |   **1.64 ns** |   **0.5347** |    **2.401** |  **0.0806** |      **-** |    **1520 B** |
| InterpolatedSerialization                                           | .NET 10.0 | .NET 10.0 | MediumModel   |    451.3 ns |   2.01 ns |   1.78 ns |   0.4012 |    2.420 |  0.0558 |      - |    1056 B |
| SplitInterpolatedSerialization                                      | .NET 10.0 | .NET 10.0 | MediumModel   |    442.6 ns |   1.77 ns |   1.65 ns |   0.0833 |    1.880 |  0.0558 |      - |    1056 B |
| DynamicInterpolatedSerialization                                    | .NET 10.0 | .NET 10.0 | MediumModel   |    997.4 ns |   6.48 ns |   6.06 ns |  -0.1457 |    1.834 |  0.5531 | 0.0019 |   10416 B |
| DynamicStringJoinSerialization                                      | .NET 10.0 | .NET 10.0 | MediumModel   |    698.1 ns |   4.85 ns |   4.30 ns |  -0.2824 |    2.457 |  0.2432 | 0.0010 |    4592 B |
| StringBuilderWithAppendsSerialization                               | .NET 10.0 | .NET 10.0 | MediumModel   |    731.1 ns |   1.89 ns |   1.58 ns |  -1.0274 |    2.772 |  0.2317 | 0.0019 |    4368 B |
| StringBuilderWithInterpolatedAppendsSerialization                   | .NET 10.0 | .NET 10.0 | MediumModel   |    818.8 ns |   3.83 ns |   3.58 ns |   0.2879 |    1.751 |  0.1993 | 0.0019 |    3760 B |
| StringBuilderWithAppendsWithPresetCapacitySerialization             | .NET 10.0 | .NET 10.0 | MediumModel   |    668.0 ns |   6.86 ns |   6.08 ns |  -0.6861 |    2.514 |  0.1936 | 0.0010 |    3656 B |
| StringBuilderWithInterpolatedAppendsWithPresetCapacitySerialization | .NET 10.0 | .NET 10.0 | MediumModel   |    655.3 ns |   2.46 ns |   2.18 ns |   0.5951 |    2.636 |  0.1621 | 0.0010 |    3064 B |
| JsonSerialization                                                   | .NET 8.0  | .NET 8.0  | MediumModel   |    466.7 ns |   1.83 ns |   1.71 ns |  -0.0682 |    1.644 |  0.0806 |      - |    1520 B |
| InterpolatedSerialization                                           | .NET 8.0  | .NET 8.0  | MediumModel   |    575.3 ns |   2.97 ns |   2.64 ns |   0.1752 |    2.100 |  0.0563 |      - |    1064 B |
| SplitInterpolatedSerialization                                      | .NET 8.0  | .NET 8.0  | MediumModel   |    569.3 ns |   2.47 ns |   2.19 ns |  -0.1145 |    1.519 |  0.0563 |      - |    1064 B |
| DynamicInterpolatedSerialization                                    | .NET 8.0  | .NET 8.0  | MediumModel   |  1,361.0 ns |   9.31 ns |   7.78 ns |  -1.8484 |    6.053 |  0.5550 |      - |   10472 B |
| DynamicStringJoinSerialization                                      | .NET 8.0  | .NET 8.0  | MediumModel   |    909.1 ns |   4.71 ns |   4.17 ns |  -0.5512 |    2.239 |  0.2422 |      - |    4568 B |
| StringBuilderWithAppendsSerialization                               | .NET 8.0  | .NET 8.0  | MediumModel   |    903.7 ns |   4.89 ns |   4.08 ns |   0.1832 |    1.427 |  0.2317 | 0.0019 |    4368 B |
| StringBuilderWithInterpolatedAppendsSerialization                   | .NET 8.0  | .NET 8.0  | MediumModel   |  1,064.6 ns |   3.92 ns |   3.67 ns |  -0.0838 |    1.696 |  0.1984 | 0.0019 |    3760 B |
| StringBuilderWithAppendsWithPresetCapacitySerialization             | .NET 8.0  | .NET 8.0  | MediumModel   |    831.4 ns |   3.09 ns |   2.58 ns |  -0.1867 |    1.873 |  0.1945 | 0.0010 |    3664 B |
| StringBuilderWithInterpolatedAppendsWithPresetCapacitySerialization | .NET 8.0  | .NET 8.0  | MediumModel   |    855.3 ns |   4.75 ns |   4.21 ns |   0.6311 |    2.661 |  0.1621 | 0.0010 |    3056 B |
| **JsonSerialization**                                                   | **.NET 10.0** | **.NET 10.0** | **SmallModel**    |    **150.1 ns** |   **0.53 ns** |   **0.47 ns** |  **-0.3369** |    **2.072** |  **0.0279** |      **-** |     **528 B** |
| InterpolatedSerialization                                           | .NET 10.0 | .NET 10.0 | SmallModel    |    159.7 ns |   0.91 ns |   0.81 ns |   0.3011 |    2.508 |  0.0246 |      - |     464 B |
| SplitInterpolatedSerialization                                      | .NET 10.0 | .NET 10.0 | SmallModel    |    171.5 ns |   0.84 ns |   0.74 ns |   0.7408 |    2.424 |  0.0246 |      - |     464 B |
| DynamicInterpolatedSerialization                                    | .NET 10.0 | .NET 10.0 | SmallModel    |    378.5 ns |   1.70 ns |   1.59 ns |  -0.5286 |    2.087 |  0.1597 |      - |    3008 B |
| DynamicStringJoinSerialization                                      | .NET 10.0 | .NET 10.0 | SmallModel    |    304.7 ns |   1.35 ns |   1.26 ns |  -0.0063 |    1.750 |  0.1063 |      - |    2008 B |
| StringBuilderWithAppendsSerialization                               | .NET 10.0 | .NET 10.0 | SmallModel    |    328.1 ns |   1.25 ns |   1.04 ns |  -0.6968 |    2.846 |  0.1111 | 0.0005 |    2096 B |
| StringBuilderWithInterpolatedAppendsSerialization                   | .NET 10.0 | .NET 10.0 | SmallModel    |    459.1 ns |   2.55 ns |   2.26 ns |   0.0740 |    1.916 |  0.0958 |      - |    1808 B |
| StringBuilderWithAppendsWithPresetCapacitySerialization             | .NET 10.0 | .NET 10.0 | SmallModel    |    310.5 ns |   1.60 ns |   1.50 ns |  -0.7937 |    2.453 |  0.0963 |      - |    1816 B |
| StringBuilderWithInterpolatedAppendsWithPresetCapacitySerialization | .NET 10.0 | .NET 10.0 | SmallModel    |    423.4 ns |   1.84 ns |   1.54 ns |   0.3599 |    2.095 |  0.0811 |      - |    1528 B |
| JsonSerialization                                                   | .NET 8.0  | .NET 8.0  | SmallModel    |          NA |        NA |        NA |       NA |       NA |      NA |     NA |        NA |
| InterpolatedSerialization                                           | .NET 8.0  | .NET 8.0  | SmallModel    |    180.2 ns |   1.17 ns |   1.10 ns |   0.3432 |    1.813 |  0.0250 |      - |     472 B |
| SplitInterpolatedSerialization                                      | .NET 8.0  | .NET 8.0  | SmallModel    |    176.4 ns |   1.38 ns |   1.22 ns |   0.7816 |    3.245 |  0.0246 |      - |     464 B |
| DynamicInterpolatedSerialization                                    | .NET 8.0  | .NET 8.0  | SmallModel    |    525.3 ns |   2.54 ns |   2.38 ns |   0.1682 |    2.186 |  0.1583 |      - |    2992 B |
| DynamicStringJoinSerialization                                      | .NET 8.0  | .NET 8.0  | SmallModel    |    379.2 ns |   1.37 ns |   1.28 ns |   0.6780 |    2.622 |  0.1078 |      - |    2032 B |
| StringBuilderWithAppendsSerialization                               | .NET 8.0  | .NET 8.0  | SmallModel    |    392.9 ns |   2.22 ns |   1.97 ns |   0.2067 |    2.159 |  0.1111 | 0.0005 |    2096 B |
| StringBuilderWithInterpolatedAppendsSerialization                   | .NET 8.0  | .NET 8.0  | SmallModel    |    568.0 ns |   1.79 ns |   1.58 ns |  -0.6995 |    2.753 |  0.0954 |      - |    1808 B |
| StringBuilderWithAppendsWithPresetCapacitySerialization             | .NET 8.0  | .NET 8.0  | SmallModel    |    368.2 ns |   1.97 ns |   1.64 ns |   0.3073 |    2.045 |  0.0968 |      - |    1824 B |
| StringBuilderWithInterpolatedAppendsWithPresetCapacitySerialization | .NET 8.0  | .NET 8.0  | SmallModel    |    533.9 ns |   2.02 ns |   1.89 ns |  -0.2378 |    1.703 |  0.0811 |      - |    1528 B |

Benchmarks with issues:
  Benchmarks.JsonSerialization: .NET 8.0(Runtime=.NET 8.0) [Model=SmallModel]
