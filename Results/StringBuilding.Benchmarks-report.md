```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7623/25H2/2025Update/HudsonValley2)
Intel Core i9-14900K 3.20GHz, 1 CPU, 32 logical and 24 physical cores
.NET SDK 10.0.102
  [Host]    : .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3
  .NET 10.0 : .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3
  .NET 8.0  : .NET 8.0.23 (8.0.23, 8.0.2325.60607), X64 RyuJIT x86-64-v3


```
| Method                                                | Job       | Runtime   | Count | Mean           | Error         | StdDev        | Skewness | Kurtosis | Gen0     | Gen1   | Allocated |
|------------------------------------------------------ |---------- |---------- |------ |---------------:|--------------:|--------------:|---------:|---------:|---------:|-------:|----------:|
| **StringConcatenationIdeal**                              | **.NET 10.0** | **.NET 10.0** | **1**     |       **2.173 ns** |     **0.0395 ns** |     **0.0370 ns** |  **-0.0548** |    **2.144** |   **0.0017** |      **-** |      **32 B** |
| StringConcatenation                                   | .NET 10.0 | .NET 10.0 | 1     |       2.378 ns |     0.0283 ns |     0.0265 ns |   0.0672 |    1.901 |   0.0017 |      - |      32 B |
| StringInterpolationIdeal                              | .NET 10.0 | .NET 10.0 | 1     |       2.307 ns |     0.0345 ns |     0.0323 ns |  -0.1966 |    2.141 |   0.0017 |      - |      32 B |
| StringInterpolation                                   | .NET 10.0 | .NET 10.0 | 1     |       2.354 ns |     0.0187 ns |     0.0175 ns |  -0.3292 |    1.859 |   0.0017 |      - |      32 B |
| StringFormatIdeal                                     | .NET 10.0 | .NET 10.0 | 1     |      70.687 ns |     0.5206 ns |     0.4869 ns |  -0.2599 |    2.883 |   0.0017 |      - |      32 B |
| StringFormat                                          | .NET 10.0 | .NET 10.0 | 1     |      27.145 ns |     0.0975 ns |     0.0864 ns |   0.4374 |    2.191 |   0.0017 |      - |      32 B |
| StringBuilderWithAppends                              | .NET 10.0 | .NET 10.0 | 1     |       8.857 ns |     0.1407 ns |     0.1175 ns |  -1.3771 |    4.061 |   0.0072 |      - |     136 B |
| StringBuilderWithAppendsWithPresetCapacity            | .NET 10.0 | .NET 10.0 | 1     |       9.517 ns |     0.1060 ns |     0.0939 ns |   0.0742 |    2.052 |   0.0064 |      - |     120 B |
| StringBuilderWithAppendFormat                         | .NET 10.0 | .NET 10.0 | 1     |      18.788 ns |     0.1417 ns |     0.1326 ns |  -0.2088 |    2.290 |   0.0072 |      - |     136 B |
| StringBuilderWithAppendFormatWithPresetCapacity       | .NET 10.0 | .NET 10.0 | 1     |      18.073 ns |     0.1804 ns |     0.1688 ns |  -0.5673 |    2.881 |   0.0063 |      - |     120 B |
| StringBuilderWithAppendJoin                           | .NET 10.0 | .NET 10.0 | 1     |      11.159 ns |     0.1004 ns |     0.0838 ns |  -1.5112 |    5.146 |   0.0072 |      - |     136 B |
| StringBuilderWithAppendJoinWithPresetCapacity         | .NET 10.0 | .NET 10.0 | 1     |      10.773 ns |     0.0869 ns |     0.0726 ns |   0.1758 |    2.655 |   0.0064 |      - |     120 B |
| StringBuilderWithInterpolatedAppend                   | .NET 10.0 | .NET 10.0 | 1     |       9.209 ns |     0.1133 ns |     0.1060 ns |  -1.3642 |    4.668 |   0.0072 |      - |     136 B |
| StringBuilderWithInterpolatedAppendWithPresetCapacity | .NET 10.0 | .NET 10.0 | 1     |       8.013 ns |     0.0439 ns |     0.0411 ns |   0.1461 |    1.574 |   0.0064 |      - |     120 B |
| StringConcatenationIdeal                              | .NET 8.0  | .NET 8.0  | 1     |       2.325 ns |     0.0240 ns |     0.0224 ns |   0.4467 |    1.910 |   0.0017 |      - |      32 B |
| StringConcatenation                                   | .NET 8.0  | .NET 8.0  | 1     |       2.510 ns |     0.0282 ns |     0.0264 ns |  -0.0063 |    2.139 |   0.0017 |      - |      32 B |
| StringInterpolationIdeal                              | .NET 8.0  | .NET 8.0  | 1     |       3.079 ns |     0.0381 ns |     0.0357 ns |   0.5511 |    2.158 |   0.0017 |      - |      32 B |
| StringInterpolation                                   | .NET 8.0  | .NET 8.0  | 1     |       2.505 ns |     0.0343 ns |     0.0304 ns |  -0.5538 |    2.383 |   0.0017 |      - |      32 B |
| StringFormatIdeal                                     | .NET 8.0  | .NET 8.0  | 1     |      16.015 ns |     0.0783 ns |     0.0654 ns |  -0.5378 |    1.837 |   0.0017 |      - |      32 B |
| StringFormat                                          | .NET 8.0  | .NET 8.0  | 1     |      25.556 ns |     0.0827 ns |     0.0773 ns |   0.4682 |    2.390 |   0.0017 |      - |      32 B |
| StringBuilderWithAppends                              | .NET 8.0  | .NET 8.0  | 1     |       8.190 ns |     0.0760 ns |     0.0711 ns |   0.4380 |    2.475 |   0.0072 |      - |     136 B |
| StringBuilderWithAppendsWithPresetCapacity            | .NET 8.0  | .NET 8.0  | 1     |       8.467 ns |     0.0519 ns |     0.0405 ns |  -0.7265 |    2.878 |   0.0064 |      - |     120 B |
| StringBuilderWithAppendFormat                         | .NET 8.0  | .NET 8.0  | 1     |      18.139 ns |     0.1500 ns |     0.1403 ns |   0.1646 |    1.569 |   0.0072 |      - |     136 B |
| StringBuilderWithAppendFormatWithPresetCapacity       | .NET 8.0  | .NET 8.0  | 1     |      18.567 ns |     0.2045 ns |     0.1913 ns |   0.2366 |    1.605 |   0.0063 |      - |     120 B |
| StringBuilderWithAppendJoin                           | .NET 8.0  | .NET 8.0  | 1     |      12.326 ns |     0.1736 ns |     0.1624 ns |   0.8351 |    2.106 |   0.0093 |      - |     176 B |
| StringBuilderWithAppendJoinWithPresetCapacity         | .NET 8.0  | .NET 8.0  | 1     |      13.438 ns |     0.1241 ns |     0.1100 ns |  -0.7419 |    3.088 |   0.0085 |      - |     160 B |
| StringBuilderWithInterpolatedAppend                   | .NET 8.0  | .NET 8.0  | 1     |       8.405 ns |     0.0648 ns |     0.0574 ns |   0.3318 |    1.850 |   0.0072 |      - |     136 B |
| StringBuilderWithInterpolatedAppendWithPresetCapacity | .NET 8.0  | .NET 8.0  | 1     |       8.713 ns |     0.0994 ns |     0.0930 ns |  -0.2456 |    1.732 |   0.0064 |      - |     120 B |
| **StringConcatenationIdeal**                              | **.NET 10.0** | **.NET 10.0** | **10**    |      **44.651 ns** |     **0.2826 ns** |     **0.2644 ns** |   **0.1866** |    **1.373** |   **0.0166** |      **-** |     **312 B** |
| StringConcatenation                                   | .NET 10.0 | .NET 10.0 | 10    |      56.903 ns |     0.4797 ns |     0.4006 ns |  -2.0929 |    6.897 |   0.0425 |      - |     800 B |
| StringInterpolationIdeal                              | .NET 10.0 | .NET 10.0 | 10    |      20.002 ns |     0.1489 ns |     0.1393 ns |   0.6246 |    2.231 |   0.0068 |      - |     128 B |
| StringInterpolation                                   | .NET 10.0 | .NET 10.0 | 10    |      50.187 ns |     0.2982 ns |     0.2643 ns |  -1.4725 |    5.185 |   0.0425 |      - |     800 B |
| StringFormatIdeal                                     | .NET 10.0 | .NET 10.0 | 10    |     151.212 ns |     0.6367 ns |     0.5956 ns |   0.2806 |    1.922 |   0.0067 |      - |     128 B |
| StringFormat                                          | .NET 10.0 | .NET 10.0 | 10    |     278.800 ns |     1.1831 ns |     1.1067 ns |  -0.2874 |    1.989 |   0.0424 |      - |     800 B |
| StringBuilderWithAppends                              | .NET 10.0 | .NET 10.0 | 10    |      52.238 ns |     0.2937 ns |     0.2747 ns |   0.1005 |    1.678 |   0.0250 |      - |     472 B |
| StringBuilderWithAppendsWithPresetCapacity            | .NET 10.0 | .NET 10.0 | 10    |      30.051 ns |     0.4385 ns |     0.4102 ns |  -0.7853 |    3.548 |   0.0162 |      - |     304 B |
| StringBuilderWithAppendFormat                         | .NET 10.0 | .NET 10.0 | 10    |     134.148 ns |     0.9440 ns |     0.8830 ns |  -0.5450 |    2.217 |   0.0250 |      - |     472 B |
| StringBuilderWithAppendFormatWithPresetCapacity       | .NET 10.0 | .NET 10.0 | 10    |     110.151 ns |     0.3006 ns |     0.2510 ns |  -0.1335 |    2.064 |   0.0161 |      - |     304 B |
| StringBuilderWithAppendJoin                           | .NET 10.0 | .NET 10.0 | 10    |      62.911 ns |     0.9359 ns |     0.8297 ns |  -0.5016 |    3.572 |   0.0250 |      - |     472 B |
| StringBuilderWithAppendJoinWithPresetCapacity         | .NET 10.0 | .NET 10.0 | 10    |      39.538 ns |     0.3082 ns |     0.2732 ns |   0.1652 |    1.855 |   0.0162 |      - |     304 B |
| StringBuilderWithInterpolatedAppend                   | .NET 10.0 | .NET 10.0 | 10    |      53.324 ns |     0.4983 ns |     0.4417 ns |  -0.1531 |    1.724 |   0.0250 |      - |     472 B |
| StringBuilderWithInterpolatedAppendWithPresetCapacity | .NET 10.0 | .NET 10.0 | 10    |      28.344 ns |     0.3210 ns |     0.3002 ns |  -0.1363 |    1.761 |   0.0162 |      - |     304 B |
| StringConcatenationIdeal                              | .NET 8.0  | .NET 8.0  | 10    |      70.150 ns |     0.3849 ns |     0.3412 ns |   0.0889 |    2.271 |   0.0166 |      - |     312 B |
| StringConcatenation                                   | .NET 8.0  | .NET 8.0  | 10    |      60.894 ns |     0.5959 ns |     0.5282 ns |  -1.4348 |    4.863 |   0.0424 |      - |     800 B |
| StringInterpolationIdeal                              | .NET 8.0  | .NET 8.0  | 10    |      30.413 ns |     0.1136 ns |     0.1007 ns |   0.1724 |    1.800 |   0.0068 |      - |     128 B |
| StringInterpolation                                   | .NET 8.0  | .NET 8.0  | 10    |      54.181 ns |     0.3653 ns |     0.3417 ns |   0.2006 |    2.352 |   0.0425 |      - |     800 B |
| StringFormatIdeal                                     | .NET 8.0  | .NET 8.0  | 10    |     106.504 ns |     0.4670 ns |     0.3900 ns |  -0.5877 |    1.949 |   0.0123 |      - |     232 B |
| StringFormat                                          | .NET 8.0  | .NET 8.0  | 10    |             NA |            NA |            NA |       NA |       NA |       NA |     NA |        NA |
| StringBuilderWithAppends                              | .NET 8.0  | .NET 8.0  | 10    |      50.116 ns |     0.3324 ns |     0.3109 ns |   0.3453 |    1.489 |   0.0250 |      - |     472 B |
| StringBuilderWithAppendsWithPresetCapacity            | .NET 8.0  | .NET 8.0  | 10    |      30.167 ns |     0.2840 ns |     0.2517 ns |  -1.3211 |    4.223 |   0.0162 |      - |     304 B |
| StringBuilderWithAppendFormat                         | .NET 8.0  | .NET 8.0  | 10    |     135.654 ns |     0.7731 ns |     0.6456 ns |   0.6056 |    1.686 |   0.0250 |      - |     472 B |
| StringBuilderWithAppendFormatWithPresetCapacity       | .NET 8.0  | .NET 8.0  | 10    |     115.658 ns |     0.3638 ns |     0.3403 ns |   0.5612 |    2.471 |   0.0161 |      - |     304 B |
| StringBuilderWithAppendJoin                           | .NET 8.0  | .NET 8.0  | 10    |      76.415 ns |     0.4615 ns |     0.4317 ns |  -0.2924 |    1.818 |   0.0463 |      - |     872 B |
| StringBuilderWithAppendJoinWithPresetCapacity         | .NET 8.0  | .NET 8.0  | 10    |      59.460 ns |     0.5971 ns |     0.4986 ns |  -1.0673 |    4.658 |   0.0374 |      - |     704 B |
| StringBuilderWithInterpolatedAppend                   | .NET 8.0  | .NET 8.0  | 10    |      56.742 ns |     0.5078 ns |     0.4501 ns |   0.6582 |    2.640 |   0.0250 |      - |     472 B |
| StringBuilderWithInterpolatedAppendWithPresetCapacity | .NET 8.0  | .NET 8.0  | 10    |      31.259 ns |     0.2749 ns |     0.2571 ns |  -0.3729 |    2.183 |   0.0162 |      - |     304 B |
| **StringConcatenationIdeal**                              | **.NET 10.0** | **.NET 10.0** | **100**   |     **467.651 ns** |     **2.3537 ns** |     **1.9655 ns** |  **-0.5311** |    **2.287** |   **0.1407** |      **-** |    **2648 B** |
| StringConcatenation                                   | .NET 10.0 | .NET 10.0 | 100   |   2,075.399 ns |    21.6368 ns |    19.1805 ns |  -0.8786 |    2.254 |   2.8152 | 0.0038 |   53000 B |
| StringInterpolationIdeal                              | .NET 10.0 | .NET 10.0 | 100   |     322.415 ns |     2.3034 ns |     2.1546 ns |   0.6234 |    2.123 |   0.0544 |      - |    1024 B |
| StringInterpolation                                   | .NET 10.0 | .NET 10.0 | 100   |   1,729.090 ns |    34.5834 ns |    38.4393 ns |   0.5857 |    2.867 |   2.8152 | 0.0057 |   53000 B |
| StringFormatIdeal                                     | .NET 10.0 | .NET 10.0 | 100   |   1,095.275 ns |     5.0739 ns |     4.7462 ns |   0.2949 |    1.962 |   0.0534 |      - |    1024 B |
| StringFormat                                          | .NET 10.0 | .NET 10.0 | 100   |   4,845.209 ns |    22.6954 ns |    20.1188 ns |  -0.1731 |    2.025 |   2.8152 |      - |   53000 B |
| StringBuilderWithAppends                              | .NET 10.0 | .NET 10.0 | 100   |     221.483 ns |     1.6340 ns |     1.3645 ns |   1.0760 |    3.709 |   0.1316 | 0.0007 |    2480 B |
| StringBuilderWithAppendsWithPresetCapacity            | .NET 10.0 | .NET 10.0 | 100   |     144.640 ns |     1.2211 ns |     1.0824 ns |  -0.7642 |    2.524 |   0.1113 | 0.0002 |    2096 B |
| StringBuilderWithAppendFormat                         | .NET 10.0 | .NET 10.0 | 100   |   1,141.947 ns |     4.0021 ns |     3.5477 ns |  -0.2067 |    2.281 |   0.1316 |      - |    2480 B |
| StringBuilderWithAppendFormatWithPresetCapacity       | .NET 10.0 | .NET 10.0 | 100   |     948.693 ns |     6.5251 ns |     6.1036 ns |   0.3808 |    1.603 |   0.1106 |      - |    2096 B |
| StringBuilderWithAppendJoin                           | .NET 10.0 | .NET 10.0 | 100   |     322.694 ns |     1.2748 ns |     1.1301 ns |   0.1352 |    1.626 |   0.1316 | 0.0005 |    2480 B |
| StringBuilderWithAppendJoinWithPresetCapacity         | .NET 10.0 | .NET 10.0 | 100   |     270.794 ns |     0.9952 ns |     0.9309 ns |  -0.1385 |    2.619 |   0.1111 |      - |    2096 B |
| StringBuilderWithInterpolatedAppend                   | .NET 10.0 | .NET 10.0 | 100   |     221.727 ns |     1.0016 ns |     0.8879 ns |   0.3015 |    1.981 |   0.1316 | 0.0007 |    2480 B |
| StringBuilderWithInterpolatedAppendWithPresetCapacity | .NET 10.0 | .NET 10.0 | 100   |     158.744 ns |     0.7080 ns |     0.5912 ns |   0.1568 |    2.724 |   0.1113 | 0.0002 |    2096 B |
| StringConcatenationIdeal                              | .NET 8.0  | .NET 8.0  | 100   |     637.115 ns |     0.9119 ns |     0.8084 ns |  -0.0736 |    2.155 |   0.1402 |      - |    2648 B |
| StringConcatenation                                   | .NET 8.0  | .NET 8.0  | 100   |   2,167.092 ns |    12.9344 ns |    12.0989 ns |   0.6425 |    2.035 |   2.8152 | 0.0038 |   53000 B |
| StringInterpolationIdeal                              | .NET 8.0  | .NET 8.0  | 100   |     359.124 ns |     1.0720 ns |     1.0027 ns |   0.2159 |    2.562 |   0.0544 |      - |    1024 B |
| StringInterpolation                                   | .NET 8.0  | .NET 8.0  | 100   |   2,627.391 ns |    40.6743 ns |    38.0467 ns |  -0.8693 |    4.145 |   2.8152 | 0.0038 |   53000 B |
| StringFormatIdeal                                     | .NET 8.0  | .NET 8.0  | 100   |   1,098.463 ns |     6.6927 ns |     6.2603 ns |   0.4434 |    2.242 |   0.0973 |      - |    1848 B |
| StringFormat                                          | .NET 8.0  | .NET 8.0  | 100   |   4,876.447 ns |    38.6671 ns |    36.1692 ns |   0.2345 |    1.690 |   2.8152 |      - |   53000 B |
| StringBuilderWithAppends                              | .NET 8.0  | .NET 8.0  | 100   |     263.132 ns |     5.3129 ns |     7.7876 ns |  -0.2719 |    1.916 |   0.1316 | 0.0005 |    2480 B |
| StringBuilderWithAppendsWithPresetCapacity            | .NET 8.0  | .NET 8.0  | 100   |     147.733 ns |     1.3115 ns |     1.2268 ns |  -0.2823 |    2.114 |   0.1113 | 0.0002 |    2096 B |
| StringBuilderWithAppendFormat                         | .NET 8.0  | .NET 8.0  | 100   |   1,171.452 ns |     9.0271 ns |     8.4440 ns |   0.5317 |    2.249 |   0.1316 |      - |    2480 B |
| StringBuilderWithAppendFormatWithPresetCapacity       | .NET 8.0  | .NET 8.0  | 100   |   1,065.453 ns |     3.6966 ns |     3.2770 ns |  -0.1633 |    2.006 |   0.1106 |      - |    2096 B |
| StringBuilderWithAppendJoin                           | .NET 8.0  | .NET 8.0  | 100   |     523.119 ns |     5.5336 ns |     4.9054 ns |   0.1414 |    1.609 |   0.3443 | 0.0010 |    6480 B |
| StringBuilderWithAppendJoinWithPresetCapacity         | .NET 8.0  | .NET 8.0  | 100   |     494.182 ns |     4.2646 ns |     3.9891 ns |  -0.1534 |    1.674 |   0.3233 | 0.0010 |    6096 B |
| StringBuilderWithInterpolatedAppend                   | .NET 8.0  | .NET 8.0  | 100   |     281.255 ns |     5.1744 ns |     4.8401 ns |  -0.8338 |    2.442 |   0.1316 | 0.0005 |    2480 B |
| StringBuilderWithInterpolatedAppendWithPresetCapacity | .NET 8.0  | .NET 8.0  | 100   |     195.541 ns |     1.3168 ns |     1.2318 ns |  -0.4941 |    2.348 |   0.1113 | 0.0002 |    2096 B |
| **StringConcatenationIdeal**                              | **.NET 10.0** | **.NET 10.0** | **1000**  |   **3,740.341 ns** |     **9.7863 ns** |     **8.1720 ns** |  **-0.2782** |    **3.732** |   **1.3809** | **0.0381** |   **26048 B** |
| StringConcatenation                                   | .NET 10.0 | .NET 10.0 | 1000  | 157,811.818 ns | 3,094.8190 ns | 2,894.8956 ns |  -0.9028 |    3.118 | 267.3340 | 6.5918 | 5030000 B |
| StringInterpolationIdeal                              | .NET 10.0 | .NET 10.0 | 1000  |   4,337.532 ns |    31.7425 ns |    29.6920 ns |  -0.1392 |    1.681 |   0.5264 |      - |   10024 B |
| StringInterpolation                                   | .NET 10.0 | .NET 10.0 | 1000  | 131,013.205 ns | 1,330.8532 ns | 1,179.7667 ns |   0.4855 |    2.187 | 267.3340 | 6.5918 | 5030000 B |
| StringFormatIdeal                                     | .NET 10.0 | .NET 10.0 | 1000  |  10,842.243 ns |    64.9022 ns |    60.7096 ns |  -0.0616 |    1.925 |   0.5188 |      - |   10024 B |
| StringFormat                                          | .NET 10.0 | .NET 10.0 | 1000  | 218,139.938 ns | 2,961.0370 ns | 2,472.6000 ns |  -0.3992 |    3.584 | 267.3340 | 6.5918 | 5030000 B |
| StringBuilderWithAppends                              | .NET 10.0 | .NET 10.0 | 1000  |   1,560.732 ns |     8.4568 ns |     7.9105 ns |  -0.0479 |    1.946 |   1.4420 | 0.0896 |   27128 B |
| StringBuilderWithAppendsWithPresetCapacity            | .NET 10.0 | .NET 10.0 | 1000  |   1,245.435 ns |    12.2947 ns |    11.5004 ns |   0.2550 |    1.851 |   1.0662 | 0.0191 |   20096 B |
| StringBuilderWithAppendFormat                         | .NET 10.0 | .NET 10.0 | 1000  |   9,589.626 ns |    51.9453 ns |    46.0482 ns |   0.5670 |    2.562 |   1.4343 | 0.0763 |   27128 B |
| StringBuilderWithAppendFormatWithPresetCapacity       | .NET 10.0 | .NET 10.0 | 1000  |   9,771.797 ns |    85.5918 ns |    75.8749 ns |  -0.1536 |    1.840 |   1.0529 | 0.0153 |   20096 B |
| StringBuilderWithAppendJoin                           | .NET 10.0 | .NET 10.0 | 1000  |   2,963.677 ns |    20.5738 ns |    19.2447 ns |   0.2308 |    1.544 |   1.4420 | 0.0877 |   27128 B |
| StringBuilderWithAppendJoinWithPresetCapacity         | .NET 10.0 | .NET 10.0 | 1000  |   2,608.360 ns |    17.3417 ns |    14.4811 ns |  -0.1482 |    2.186 |   1.0643 | 0.0191 |   20096 B |
| StringBuilderWithInterpolatedAppend                   | .NET 10.0 | .NET 10.0 | 1000  |   2,059.451 ns |    18.9690 ns |    17.7436 ns |   0.1639 |    1.812 |   1.4420 | 0.0877 |   27128 B |
| StringBuilderWithInterpolatedAppendWithPresetCapacity | .NET 10.0 | .NET 10.0 | 1000  |   1,604.606 ns |    19.8949 ns |    18.6097 ns |   0.5256 |    1.956 |   1.0662 | 0.0191 |   20096 B |
| StringConcatenationIdeal                              | .NET 8.0  | .NET 8.0  | 1000  |   6,376.517 ns |    44.5884 ns |    39.5264 ns |   0.0678 |    2.030 |   1.3809 | 0.0381 |   26048 B |
| StringConcatenation                                   | .NET 8.0  | .NET 8.0  | 1000  | 163,216.807 ns | 2,262.2213 ns | 2,005.4003 ns |   0.5928 |    2.336 | 267.3340 | 6.5918 | 5030000 B |
| StringInterpolationIdeal                              | .NET 8.0  | .NET 8.0  | 1000  |   4,896.890 ns |    38.6993 ns |    34.3059 ns |   0.3091 |    1.468 |   0.5264 |      - |   10024 B |
| StringInterpolation                                   | .NET 8.0  | .NET 8.0  | 1000  | 165,227.671 ns | 3,217.3833 ns | 3,009.5423 ns |  -0.0509 |    1.672 | 267.3340 | 6.5918 | 5030000 B |
| StringFormatIdeal                                     | .NET 8.0  | .NET 8.0  | 1000  |  10,897.115 ns |    44.2767 ns |    36.9730 ns |  -0.4368 |    1.402 |   0.9460 |      - |   18048 B |
| StringFormat                                          | .NET 8.0  | .NET 8.0  | 1000  | 236,446.927 ns | 3,682.5456 ns | 3,264.4807 ns |  -2.1041 |    7.483 | 267.3340 | 6.5918 | 5030000 B |
| StringBuilderWithAppends                              | .NET 8.0  | .NET 8.0  | 1000  |   1,603.682 ns |     5.0137 ns |     4.6898 ns |   0.0006 |    1.762 |   1.4420 | 0.0896 |   27128 B |
| StringBuilderWithAppendsWithPresetCapacity            | .NET 8.0  | .NET 8.0  | 1000  |   1,222.899 ns |    12.5254 ns |    11.7163 ns |   0.1510 |    1.495 |   1.0662 | 0.0191 |   20096 B |
| StringBuilderWithAppendFormat                         | .NET 8.0  | .NET 8.0  | 1000  |  10,850.271 ns |    51.2264 ns |    42.7764 ns |  -0.4953 |    2.199 |   1.4343 | 0.0763 |   27128 B |
| StringBuilderWithAppendFormatWithPresetCapacity       | .NET 8.0  | .NET 8.0  | 1000  |  10,769.466 ns |    60.7369 ns |    56.8134 ns |  -0.2382 |    1.570 |   1.0529 | 0.0153 |   20096 B |
| StringBuilderWithAppendJoin                           | .NET 8.0  | .NET 8.0  | 1000  |   4,814.171 ns |    58.1888 ns |    48.5902 ns |   0.1104 |    2.503 |   3.5629 | 0.2213 |   67128 B |
| StringBuilderWithAppendJoinWithPresetCapacity         | .NET 8.0  | .NET 8.0  | 1000  |   4,680.698 ns |    37.9992 ns |    33.6853 ns |   0.4589 |    2.751 |   3.1891 | 0.1144 |   60096 B |
| StringBuilderWithInterpolatedAppend                   | .NET 8.0  | .NET 8.0  | 1000  |   1,959.660 ns |    23.9102 ns |    22.3656 ns |   0.0019 |    1.480 |   1.4420 | 0.0877 |   27128 B |
| StringBuilderWithInterpolatedAppendWithPresetCapacity | .NET 8.0  | .NET 8.0  | 1000  |   1,565.107 ns |    17.4472 ns |    16.3201 ns |   0.6280 |    2.080 |   1.0662 | 0.0191 |   20096 B |

Benchmarks with issues:
  Benchmarks.StringFormat: .NET 8.0(Runtime=.NET 8.0) [Count=10]
