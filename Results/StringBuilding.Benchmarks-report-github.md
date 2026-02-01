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
| **StringConcatenation**                                   | **.NET 10.0** | **.NET 10.0** | **1**     |       **2.174 ns** |     **0.0433 ns** |     **0.0384 ns** |   **0.2030** |    **1.766** |   **0.0017** |      **-** |      **32 B** |
| StringConcatenationDynamic                            | .NET 10.0 | .NET 10.0 | 1     |       2.372 ns |     0.0128 ns |     0.0106 ns |  -0.3545 |    1.991 |   0.0017 |      - |      32 B |
| StringInterpolation                                   | .NET 10.0 | .NET 10.0 | 1     |       2.313 ns |     0.0249 ns |     0.0233 ns |   0.1570 |    1.719 |   0.0017 |      - |      32 B |
| StringInterpolationDynamic                            | .NET 10.0 | .NET 10.0 | 1     |       2.385 ns |     0.0402 ns |     0.0376 ns |   0.1501 |    2.364 |   0.0017 |      - |      32 B |
| StringFormat                                          | .NET 10.0 | .NET 10.0 | 1     |      71.591 ns |     0.3032 ns |     0.2688 ns |   0.1534 |    1.694 |   0.0017 |      - |      32 B |
| StringFormatDynamic                                   | .NET 10.0 | .NET 10.0 | 1     |      27.342 ns |     0.2562 ns |     0.2396 ns |  -0.1188 |    1.944 |   0.0017 |      - |      32 B |
| StringJoin                                            | .NET 10.0 | .NET 10.0 | 1     |     106.937 ns |     0.5374 ns |     0.4764 ns |   0.7844 |    2.321 |   0.0017 |      - |      32 B |
| StringJoinDynamic                                     | .NET 10.0 | .NET 10.0 | 1     |      10.172 ns |     0.1171 ns |     0.0978 ns |  -0.2261 |    1.983 |   0.0017 |      - |      32 B |
| StringBuilderWithAppends                              | .NET 10.0 | .NET 10.0 | 1     |       8.133 ns |     0.0752 ns |     0.0703 ns |  -0.0863 |    1.506 |   0.0072 |      - |     136 B |
| StringBuilderWithAppendsWithPresetCapacity            | .NET 10.0 | .NET 10.0 | 1     |       8.452 ns |     0.0422 ns |     0.0352 ns |  -1.3328 |    3.590 |   0.0064 |      - |     120 B |
| StringBuilderWithAppendFormat                         | .NET 10.0 | .NET 10.0 | 1     |      16.966 ns |     0.0748 ns |     0.0700 ns |   0.3374 |    1.743 |   0.0072 |      - |     136 B |
| StringBuilderWithAppendFormatWithPresetCapacity       | .NET 10.0 | .NET 10.0 | 1     |      17.027 ns |     0.1122 ns |     0.0937 ns |   0.5653 |    1.862 |   0.0063 |      - |     120 B |
| StringBuilderWithAppendJoin                           | .NET 10.0 | .NET 10.0 | 1     |       9.932 ns |     0.0707 ns |     0.0661 ns |  -0.2489 |    2.084 |   0.0072 |      - |     136 B |
| StringBuilderWithAppendJoinWithPresetCapacity         | .NET 10.0 | .NET 10.0 | 1     |       9.502 ns |     0.0697 ns |     0.0652 ns |  -0.1986 |    1.928 |   0.0064 |      - |     120 B |
| StringBuilderWithInterpolatedAppend                   | .NET 10.0 | .NET 10.0 | 1     |       8.040 ns |     0.0617 ns |     0.0577 ns |  -1.0344 |    2.955 |   0.0072 |      - |     136 B |
| StringBuilderWithInterpolatedAppendWithPresetCapacity | .NET 10.0 | .NET 10.0 | 1     |       7.617 ns |     0.0571 ns |     0.0477 ns |  -0.7073 |    2.094 |   0.0064 |      - |     120 B |
| StringConcatenation                                   | .NET 8.0  | .NET 8.0  | 1     |       2.336 ns |     0.0373 ns |     0.0331 ns |   0.6182 |    2.012 |   0.0017 |      - |      32 B |
| StringConcatenationDynamic                            | .NET 8.0  | .NET 8.0  | 1     |       2.693 ns |     0.0311 ns |     0.0259 ns |  -1.3598 |    4.404 |   0.0017 |      - |      32 B |
| StringInterpolation                                   | .NET 8.0  | .NET 8.0  | 1     |       2.722 ns |     0.0147 ns |     0.0130 ns |  -0.0675 |    1.976 |   0.0017 |      - |      32 B |
| StringInterpolationDynamic                            | .NET 8.0  | .NET 8.0  | 1     |       2.502 ns |     0.0176 ns |     0.0164 ns |   0.3127 |    1.840 |   0.0017 |      - |      32 B |
| StringFormat                                          | .NET 8.0  | .NET 8.0  | 1     |      16.102 ns |     0.1349 ns |     0.1196 ns |   0.0876 |    2.159 |   0.0017 |      - |      32 B |
| StringFormatDynamic                                   | .NET 8.0  | .NET 8.0  | 1     |      25.452 ns |     0.1260 ns |     0.1117 ns |   0.6750 |    1.960 |   0.0017 |      - |      32 B |
| StringJoin                                            | .NET 8.0  | .NET 8.0  | 1     |      11.663 ns |     0.1290 ns |     0.1144 ns |  -0.3539 |    3.678 |   0.0038 |      - |      72 B |
| StringJoinDynamic                                     | .NET 8.0  | .NET 8.0  | 1     |      14.438 ns |     0.1254 ns |     0.1173 ns |   0.0517 |    1.547 |   0.0042 |      - |      80 B |
| StringBuilderWithAppends                              | .NET 8.0  | .NET 8.0  | 1     |       8.238 ns |     0.0360 ns |     0.0319 ns |   0.3343 |    2.212 |   0.0072 |      - |     136 B |
| StringBuilderWithAppendsWithPresetCapacity            | .NET 8.0  | .NET 8.0  | 1     |       8.495 ns |     0.0678 ns |     0.0601 ns |   0.2228 |    2.159 |   0.0064 |      - |     120 B |
| StringBuilderWithAppendFormat                         | .NET 8.0  | .NET 8.0  | 1     |      18.040 ns |     0.0985 ns |     0.0921 ns |  -0.2038 |    2.398 |   0.0072 |      - |     136 B |
| StringBuilderWithAppendFormatWithPresetCapacity       | .NET 8.0  | .NET 8.0  | 1     |      18.675 ns |     0.1024 ns |     0.0958 ns |  -0.0849 |    2.577 |   0.0063 |      - |     120 B |
| StringBuilderWithAppendJoin                           | .NET 8.0  | .NET 8.0  | 1     |      11.269 ns |     0.0881 ns |     0.0688 ns |  -0.2326 |    2.666 |   0.0093 |      - |     176 B |
| StringBuilderWithAppendJoinWithPresetCapacity         | .NET 8.0  | .NET 8.0  | 1     |      12.026 ns |     0.1038 ns |     0.0867 ns |   0.9607 |    2.977 |   0.0085 |      - |     160 B |
| StringBuilderWithInterpolatedAppend                   | .NET 8.0  | .NET 8.0  | 1     |       8.277 ns |     0.0487 ns |     0.0407 ns |  -0.5454 |    3.276 |   0.0072 |      - |     136 B |
| StringBuilderWithInterpolatedAppendWithPresetCapacity | .NET 8.0  | .NET 8.0  | 1     |       8.460 ns |     0.1422 ns |     0.1187 ns |   0.6154 |    2.558 |   0.0064 |      - |     120 B |
| **StringConcatenation**                                   | **.NET 10.0** | **.NET 10.0** | **10**    |      **46.097 ns** |     **0.2739 ns** |     **0.2562 ns** |  **-0.2385** |    **2.338** |   **0.0166** |      **-** |     **312 B** |
| StringConcatenationDynamic                            | .NET 10.0 | .NET 10.0 | 10    |      50.440 ns |     0.1983 ns |     0.1758 ns |   0.2871 |    1.577 |   0.0425 |      - |     800 B |
| StringInterpolation                                   | .NET 10.0 | .NET 10.0 | 10    |      20.141 ns |     0.0739 ns |     0.0577 ns |  -0.5175 |    2.098 |   0.0068 |      - |     128 B |
| StringInterpolationDynamic                            | .NET 10.0 | .NET 10.0 | 10    |      50.536 ns |     0.2074 ns |     0.1940 ns |  -0.0868 |    1.374 |   0.0425 |      - |     800 B |
| StringFormat                                          | .NET 10.0 | .NET 10.0 | 10    |     144.988 ns |     0.5453 ns |     0.5100 ns |   0.3312 |    1.625 |   0.0067 |      - |     128 B |
| StringFormatDynamic                                   | .NET 10.0 | .NET 10.0 | 10    |     279.056 ns |     1.5508 ns |     1.4507 ns |   0.1205 |    2.010 |   0.0424 |      - |     800 B |
| StringJoin                                            | .NET 10.0 | .NET 10.0 | 10    |     141.949 ns |     0.7894 ns |     0.7384 ns |  -0.6138 |    1.968 |   0.0067 |      - |     128 B |
| StringJoinDynamic                                     | .NET 10.0 | .NET 10.0 | 10    |      97.447 ns |     1.3757 ns |     1.2195 ns |  -1.4508 |    4.862 |   0.0424 |      - |     800 B |
| StringBuilderWithAppends                              | .NET 10.0 | .NET 10.0 | 10    |      54.381 ns |     0.6821 ns |     0.6047 ns |  -0.6333 |    2.189 |   0.0250 |      - |     472 B |
| StringBuilderWithAppendsWithPresetCapacity            | .NET 10.0 | .NET 10.0 | 10    |      27.365 ns |     0.2872 ns |     0.2687 ns |  -0.2421 |    1.749 |   0.0162 |      - |     304 B |
| StringBuilderWithAppendFormat                         | .NET 10.0 | .NET 10.0 | 10    |     127.595 ns |     0.6522 ns |     0.6100 ns |  -0.2853 |    1.656 |   0.0250 |      - |     472 B |
| StringBuilderWithAppendFormatWithPresetCapacity       | .NET 10.0 | .NET 10.0 | 10    |     109.924 ns |     0.6140 ns |     0.5443 ns |   0.5000 |    1.924 |   0.0161 |      - |     304 B |
| StringBuilderWithAppendJoin                           | .NET 10.0 | .NET 10.0 | 10    |      59.334 ns |     0.4452 ns |     0.4164 ns |   0.6495 |    2.883 |   0.0250 |      - |     472 B |
| StringBuilderWithAppendJoinWithPresetCapacity         | .NET 10.0 | .NET 10.0 | 10    |      37.376 ns |     0.2793 ns |     0.2476 ns |   0.0208 |    1.524 |   0.0162 |      - |     304 B |
| StringBuilderWithInterpolatedAppend                   | .NET 10.0 | .NET 10.0 | 10    |      55.621 ns |     0.3813 ns |     0.3380 ns |   0.2262 |    2.295 |   0.0250 |      - |     472 B |
| StringBuilderWithInterpolatedAppendWithPresetCapacity | .NET 10.0 | .NET 10.0 | 10    |      27.624 ns |     0.3183 ns |     0.2977 ns |   0.1880 |    1.715 |   0.0162 |      - |     304 B |
| StringConcatenation                                   | .NET 8.0  | .NET 8.0  | 10    |      66.972 ns |     0.4981 ns |     0.4159 ns |  -0.0060 |    2.179 |   0.0166 |      - |     312 B |
| StringConcatenationDynamic                            | .NET 8.0  | .NET 8.0  | 10    |      59.867 ns |     0.6102 ns |     0.5409 ns |  -0.8015 |    3.617 |   0.0425 |      - |     800 B |
| StringInterpolation                                   | .NET 8.0  | .NET 8.0  | 10    |      30.609 ns |     0.2334 ns |     0.2183 ns |   0.0883 |    1.650 |   0.0068 |      - |     128 B |
| StringInterpolationDynamic                            | .NET 8.0  | .NET 8.0  | 10    |      61.405 ns |     1.2461 ns |     1.2796 ns |   0.7804 |    3.519 |   0.0424 |      - |     800 B |
| StringFormat                                          | .NET 8.0  | .NET 8.0  | 10    |     104.403 ns |     0.5661 ns |     0.5295 ns |   0.3784 |    1.598 |   0.0123 |      - |     232 B |
| StringFormatDynamic                                   | .NET 8.0  | .NET 8.0  | 10    |             NA |            NA |            NA |       NA |       NA |       NA |     NA |        NA |
| StringJoin                                            | .NET 8.0  | .NET 8.0  | 10    |      87.416 ns |     0.5684 ns |     0.5039 ns |   0.5062 |    2.143 |   0.0166 |      - |     312 B |
| StringJoinDynamic                                     | .NET 8.0  | .NET 8.0  | 10    |     161.212 ns |     1.9341 ns |     1.6151 ns |   0.2713 |    1.255 |   0.0679 |      - |    1280 B |
| StringBuilderWithAppends                              | .NET 8.0  | .NET 8.0  | 10    |      54.067 ns |     0.6544 ns |     0.5801 ns |   0.0040 |    2.555 |   0.0250 |      - |     472 B |
| StringBuilderWithAppendsWithPresetCapacity            | .NET 8.0  | .NET 8.0  | 10    |      27.135 ns |     0.4625 ns |     0.4100 ns |   0.2888 |    1.409 |   0.0162 |      - |     304 B |
| StringBuilderWithAppendFormat                         | .NET 8.0  | .NET 8.0  | 10    |     135.804 ns |     0.5557 ns |     0.4926 ns |   0.3469 |    1.745 |   0.0250 |      - |     472 B |
| StringBuilderWithAppendFormatWithPresetCapacity       | .NET 8.0  | .NET 8.0  | 10    |     115.402 ns |     0.5998 ns |     0.5317 ns |   0.8206 |    3.240 |   0.0160 |      - |     304 B |
| StringBuilderWithAppendJoin                           | .NET 8.0  | .NET 8.0  | 10    |      78.209 ns |     0.4286 ns |     0.4009 ns |  -0.5711 |    3.174 |   0.0463 |      - |     872 B |
| StringBuilderWithAppendJoinWithPresetCapacity         | .NET 8.0  | .NET 8.0  | 10    |      51.572 ns |     0.5594 ns |     0.4671 ns |   0.9423 |    2.763 |   0.0374 |      - |     704 B |
| StringBuilderWithInterpolatedAppend                   | .NET 8.0  | .NET 8.0  | 10    |      55.887 ns |     0.5782 ns |     0.5409 ns |  -0.5422 |    2.098 |   0.0250 |      - |     472 B |
| StringBuilderWithInterpolatedAppendWithPresetCapacity | .NET 8.0  | .NET 8.0  | 10    |      28.721 ns |     0.6109 ns |     0.6000 ns |   0.2926 |    2.030 |   0.0162 |      - |     304 B |
| **StringConcatenation**                                   | **.NET 10.0** | **.NET 10.0** | **100**   |     **467.209 ns** |     **3.3110 ns** |     **2.7648 ns** |  **-0.5872** |    **3.133** |   **0.1407** |      **-** |    **2648 B** |
| StringConcatenationDynamic                            | .NET 10.0 | .NET 10.0 | 100   |   1,645.154 ns |    16.6015 ns |    14.7168 ns |  -0.3529 |    2.577 |   2.8152 | 0.0057 |   53000 B |
| StringInterpolation                                   | .NET 10.0 | .NET 10.0 | 100   |     329.123 ns |     1.4577 ns |     1.3636 ns |   0.1689 |    2.235 |   0.0544 |      - |    1024 B |
| StringInterpolationDynamic                            | .NET 10.0 | .NET 10.0 | 100   |   1,759.705 ns |    35.2373 ns |    44.5639 ns |   0.6521 |    1.937 |   2.8152 | 0.0038 |   53000 B |
| StringFormat                                          | .NET 10.0 | .NET 10.0 | 100   |   1,065.943 ns |     2.9350 ns |     2.6018 ns |   0.3571 |    1.797 |   0.0534 |      - |    1024 B |
| StringFormatDynamic                                   | .NET 10.0 | .NET 10.0 | 100   |   4,852.536 ns |    28.2206 ns |    26.3976 ns |  -0.2265 |    1.393 |   2.8152 |      - |   53000 B |
| StringJoin                                            | .NET 10.0 | .NET 10.0 | 100   |     475.477 ns |     2.7411 ns |     2.5640 ns |   0.4397 |    1.846 |   0.0544 |      - |    1024 B |
| StringJoinDynamic                                     | .NET 10.0 | .NET 10.0 | 100   |   2,139.091 ns |    26.1045 ns |    24.4182 ns |  -1.0266 |    2.719 |   2.8152 | 0.0038 |   53000 B |
| StringBuilderWithAppends                              | .NET 10.0 | .NET 10.0 | 100   |     200.177 ns |     1.0986 ns |     0.9739 ns |   0.8579 |    3.262 |   0.1316 | 0.0007 |    2480 B |
| StringBuilderWithAppendsWithPresetCapacity            | .NET 10.0 | .NET 10.0 | 100   |     145.210 ns |     1.1041 ns |     1.0327 ns |  -0.0516 |    1.466 |   0.1113 | 0.0002 |    2096 B |
| StringBuilderWithAppendFormat                         | .NET 10.0 | .NET 10.0 | 100   |   1,139.282 ns |     4.3496 ns |     3.6321 ns |  -0.1407 |    1.432 |   0.1316 |      - |    2480 B |
| StringBuilderWithAppendFormatWithPresetCapacity       | .NET 10.0 | .NET 10.0 | 100   |     943.914 ns |     4.4395 ns |     4.1527 ns |   0.0151 |    1.355 |   0.1106 |      - |    2096 B |
| StringBuilderWithAppendJoin                           | .NET 10.0 | .NET 10.0 | 100   |     316.190 ns |     1.6038 ns |     1.5002 ns |  -0.6730 |    2.632 |   0.1316 | 0.0005 |    2480 B |
| StringBuilderWithAppendJoinWithPresetCapacity         | .NET 10.0 | .NET 10.0 | 100   |     268.656 ns |     1.6667 ns |     1.5590 ns |  -0.7095 |    2.830 |   0.1111 |      - |    2096 B |
| StringBuilderWithInterpolatedAppend                   | .NET 10.0 | .NET 10.0 | 100   |     221.306 ns |     1.1127 ns |     1.0409 ns |  -0.1731 |    1.431 |   0.1316 | 0.0007 |    2480 B |
| StringBuilderWithInterpolatedAppendWithPresetCapacity | .NET 10.0 | .NET 10.0 | 100   |     160.209 ns |     0.9118 ns |     0.7614 ns |   1.1164 |    3.264 |   0.1113 | 0.0002 |    2096 B |
| StringConcatenation                                   | .NET 8.0  | .NET 8.0  | 100   |     639.751 ns |     1.8848 ns |     1.7631 ns |  -0.1813 |    1.739 |   0.1402 |      - |    2648 B |
| StringConcatenationDynamic                            | .NET 8.0  | .NET 8.0  | 100   |   2,145.061 ns |    27.0007 ns |    25.2564 ns |   0.0299 |    1.433 |   2.8152 | 0.0038 |   53000 B |
| StringInterpolation                                   | .NET 8.0  | .NET 8.0  | 100   |     362.009 ns |     1.3462 ns |     1.1934 ns |   0.0005 |    1.866 |   0.0544 |      - |    1024 B |
| StringInterpolationDynamic                            | .NET 8.0  | .NET 8.0  | 100   |   2,193.365 ns |    15.2958 ns |    13.5594 ns |   0.0228 |    1.868 |   2.8152 | 0.0038 |   53000 B |
| StringFormat                                          | .NET 8.0  | .NET 8.0  | 100   |   1,073.674 ns |     3.9515 ns |     3.0850 ns |   0.2233 |    1.351 |   0.0973 |      - |    1848 B |
| StringFormatDynamic                                   | .NET 8.0  | .NET 8.0  | 100   |   4,859.696 ns |    28.3745 ns |    25.1532 ns |   0.3402 |    2.413 |   2.8152 |      - |   53000 B |
| StringJoin                                            | .NET 8.0  | .NET 8.0  | 100   |     910.000 ns |     3.9480 ns |     3.2967 ns |  -0.0914 |    1.479 |   0.1402 |      - |    2648 B |
| StringJoinDynamic                                     | .NET 8.0  | .NET 8.0  | 100   |   3,059.155 ns |    52.1990 ns |    46.2731 ns |   0.2135 |    2.378 |   3.0708 | 0.0076 |   57800 B |
| StringBuilderWithAppends                              | .NET 8.0  | .NET 8.0  | 100   |     242.628 ns |     4.8958 ns |     8.1797 ns |  -0.0154 |    1.584 |   0.1316 | 0.0005 |    2480 B |
| StringBuilderWithAppendsWithPresetCapacity            | .NET 8.0  | .NET 8.0  | 100   |     147.495 ns |     0.8279 ns |     0.7744 ns |  -0.9086 |    3.106 |   0.1113 | 0.0002 |    2096 B |
| StringBuilderWithAppendFormat                         | .NET 8.0  | .NET 8.0  | 100   |   1,143.352 ns |     4.3761 ns |     3.6542 ns |  -0.8639 |    2.703 |   0.1316 |      - |    2480 B |
| StringBuilderWithAppendFormatWithPresetCapacity       | .NET 8.0  | .NET 8.0  | 100   |   1,069.032 ns |     5.5783 ns |     4.9450 ns |  -0.2541 |    1.735 |   0.1106 |      - |    2096 B |
| StringBuilderWithAppendJoin                           | .NET 8.0  | .NET 8.0  | 100   |     588.256 ns |     9.6073 ns |     8.0225 ns |  -1.2134 |    3.242 |   0.3443 | 0.0010 |    6480 B |
| StringBuilderWithAppendJoinWithPresetCapacity         | .NET 8.0  | .NET 8.0  | 100   |     491.641 ns |     6.6205 ns |     6.1928 ns |  -0.7900 |    2.257 |   0.3238 | 0.0010 |    6096 B |
| StringBuilderWithInterpolatedAppend                   | .NET 8.0  | .NET 8.0  | 100   |     291.568 ns |     5.7244 ns |     7.4434 ns |   0.1767 |    1.407 |   0.1316 | 0.0005 |    2480 B |
| StringBuilderWithInterpolatedAppendWithPresetCapacity | .NET 8.0  | .NET 8.0  | 100   |     193.834 ns |     2.9186 ns |     2.5873 ns |   0.3804 |    2.454 |   0.1113 | 0.0002 |    2096 B |
| **StringConcatenation**                                   | **.NET 10.0** | **.NET 10.0** | **1000**  |   **3,762.700 ns** |    **13.0809 ns** |    **10.9232 ns** |   **0.0924** |    **1.796** |   **1.3809** | **0.0381** |   **26048 B** |
| StringConcatenationDynamic                            | .NET 10.0 | .NET 10.0 | 1000  | 133,993.784 ns | 1,952.6836 ns | 1,826.5415 ns |   0.4019 |    2.411 | 267.3340 | 6.5918 | 5030000 B |
| StringInterpolation                                   | .NET 10.0 | .NET 10.0 | 1000  |   4,286.269 ns |    12.8875 ns |    10.0617 ns |  -0.4908 |    1.875 |   0.5264 |      - |   10024 B |
| StringInterpolationDynamic                            | .NET 10.0 | .NET 10.0 | 1000  | 152,038.263 ns | 2,826.4508 ns | 2,775.9526 ns |   0.0638 |    2.056 | 267.3340 | 6.5918 | 5030000 B |
| StringFormat                                          | .NET 10.0 | .NET 10.0 | 1000  |  10,874.219 ns |    46.0341 ns |    40.8080 ns |   0.0493 |    1.811 |   0.5188 |      - |   10024 B |
| StringFormatDynamic                                   | .NET 10.0 | .NET 10.0 | 1000  | 189,928.992 ns |   846.0019 ns |   749.9586 ns |   0.1156 |    2.478 | 267.3340 | 6.5918 | 5030000 B |
| StringJoin                                            | .NET 10.0 | .NET 10.0 | 1000  |   3,699.748 ns |    12.4299 ns |    11.6269 ns |   0.4829 |    1.903 |   0.5302 |      - |   10024 B |
| StringJoinDynamic                                     | .NET 10.0 | .NET 10.0 | 1000  | 135,741.442 ns | 1,202.9663 ns | 1,125.2554 ns |  -1.1672 |    3.070 | 267.3340 | 6.5918 | 5030000 B |
| StringBuilderWithAppends                              | .NET 10.0 | .NET 10.0 | 1000  |   1,665.949 ns |    12.9100 ns |    11.4443 ns |  -0.3214 |    1.783 |   1.4420 | 0.0896 |   27128 B |
| StringBuilderWithAppendsWithPresetCapacity            | .NET 10.0 | .NET 10.0 | 1000  |   1,253.728 ns |    12.6304 ns |    11.8145 ns |   0.0401 |    1.426 |   1.0662 | 0.0191 |   20096 B |
| StringBuilderWithAppendFormat                         | .NET 10.0 | .NET 10.0 | 1000  |   9,727.241 ns |    46.2898 ns |    38.6541 ns |   0.3767 |    2.389 |   1.4343 | 0.0763 |   27128 B |
| StringBuilderWithAppendFormatWithPresetCapacity       | .NET 10.0 | .NET 10.0 | 1000  |   9,220.820 ns |    33.9815 ns |    31.7863 ns |   0.1472 |    1.814 |   1.0529 | 0.0153 |   20096 B |
| StringBuilderWithAppendJoin                           | .NET 10.0 | .NET 10.0 | 1000  |   2,849.486 ns |    17.5243 ns |    15.5349 ns |  -0.5701 |    1.866 |   1.4420 | 0.0877 |   27128 B |
| StringBuilderWithAppendJoinWithPresetCapacity         | .NET 10.0 | .NET 10.0 | 1000  |   2,586.513 ns |    10.1457 ns |     8.9939 ns |   0.1292 |    1.549 |   1.0643 | 0.0191 |   20096 B |
| StringBuilderWithInterpolatedAppend                   | .NET 10.0 | .NET 10.0 | 1000  |   2,053.991 ns |    21.9734 ns |    20.5539 ns |  -0.3972 |    1.733 |   1.4420 | 0.0877 |   27128 B |
| StringBuilderWithInterpolatedAppendWithPresetCapacity | .NET 10.0 | .NET 10.0 | 1000  |   1,606.433 ns |     5.2768 ns |     4.1197 ns |  -0.5657 |    2.006 |   1.0662 | 0.0191 |   20096 B |
| StringConcatenation                                   | .NET 8.0  | .NET 8.0  | 1000  |   6,340.174 ns |    40.4532 ns |    37.8400 ns |  -0.3591 |    1.757 |   1.3809 | 0.0381 |   26048 B |
| StringConcatenationDynamic                            | .NET 8.0  | .NET 8.0  | 1000  | 134,959.065 ns | 1,307.7720 ns | 1,159.3058 ns |  -1.2181 |    3.428 | 267.3340 | 6.5918 | 5030000 B |
| StringInterpolation                                   | .NET 8.0  | .NET 8.0  | 1000  |   4,776.391 ns |    26.0086 ns |    24.3284 ns |   0.5608 |    2.511 |   0.5264 |      - |   10024 B |
| StringInterpolationDynamic                            | .NET 8.0  | .NET 8.0  | 1000  | 133,003.216 ns | 1,665.0985 ns | 1,557.5342 ns |   0.2107 |    1.716 | 267.3340 | 6.5918 | 5030000 B |
| StringFormat                                          | .NET 8.0  | .NET 8.0  | 1000  |  10,795.788 ns |    87.0943 ns |    77.2068 ns |   0.8910 |    2.191 |   0.9460 |      - |   18048 B |
| StringFormatDynamic                                   | .NET 8.0  | .NET 8.0  | 1000  | 210,175.108 ns | 1,784.0034 ns | 1,392.8325 ns |  -0.8822 |    3.073 | 267.3340 | 6.5918 | 5030000 B |
| StringJoin                                            | .NET 8.0  | .NET 8.0  | 1000  |   7,961.951 ns |    57.7306 ns |    54.0013 ns |   1.0943 |    3.458 |   1.3733 | 0.0305 |   26048 B |
| StringJoinDynamic                                     | .NET 8.0  | .NET 8.0  | 1000  | 143,482.860 ns | 1,809.4371 ns | 1,692.5486 ns |  -1.0717 |    3.137 | 269.7754 | 6.5918 | 5078000 B |
| StringBuilderWithAppends                              | .NET 8.0  | .NET 8.0  | 1000  |   1,597.174 ns |     7.2063 ns |     6.7408 ns |   0.1287 |    1.733 |   1.4420 | 0.0896 |   27128 B |
| StringBuilderWithAppendsWithPresetCapacity            | .NET 8.0  | .NET 8.0  | 1000  |   1,282.555 ns |     6.1396 ns |     5.1269 ns |  -0.0132 |    1.963 |   1.0662 | 0.0191 |   20096 B |
| StringBuilderWithAppendFormat                         | .NET 8.0  | .NET 8.0  | 1000  |  10,851.295 ns |    41.4888 ns |    34.6450 ns |  -0.4152 |    2.124 |   1.4343 | 0.0763 |   27128 B |
| StringBuilderWithAppendFormatWithPresetCapacity       | .NET 8.0  | .NET 8.0  | 1000  |  10,676.990 ns |    20.8377 ns |    18.4721 ns |   0.3256 |    2.018 |   1.0529 | 0.0153 |   20096 B |
| StringBuilderWithAppendJoin                           | .NET 8.0  | .NET 8.0  | 1000  |   4,364.133 ns |    34.0989 ns |    30.2278 ns |  -0.5403 |    3.307 |   3.5629 | 0.2213 |   67128 B |
| StringBuilderWithAppendJoinWithPresetCapacity         | .NET 8.0  | .NET 8.0  | 1000  |   4,260.886 ns |    29.1070 ns |    27.2267 ns |   0.3261 |    2.185 |   3.1891 | 0.1144 |   60096 B |
| StringBuilderWithInterpolatedAppend                   | .NET 8.0  | .NET 8.0  | 1000  |   1,905.990 ns |     8.0406 ns |     7.5212 ns |   0.3047 |    1.918 |   1.4420 | 0.0877 |   27128 B |
| StringBuilderWithInterpolatedAppendWithPresetCapacity | .NET 8.0  | .NET 8.0  | 1000  |   1,551.205 ns |    18.7460 ns |    17.5350 ns |   0.7102 |    2.637 |   1.0662 | 0.0191 |   20096 B |

Benchmarks with issues:
  Benchmarks.StringFormatDynamic: .NET 8.0(Runtime=.NET 8.0) [Count=10]
