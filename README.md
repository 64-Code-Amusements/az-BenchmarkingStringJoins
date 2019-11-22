# BenchmarkingStringJoins

**TL;DR** Use `String.Join` rather then a string building to concatentate collections of string.

|  Method |     Mean |     Error |    StdDev |
|-------- |---------:|----------:|----------:|
|    Join | 2.742 us | 0.0186 us | 0.0174 us |
| Builder | 4.161 us | 0.0366 us | 0.0324 us |
