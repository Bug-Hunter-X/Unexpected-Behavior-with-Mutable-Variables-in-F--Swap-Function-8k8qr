# F# Mutable Variable Bug

This repository demonstrates a common error in F# related to mutable variables. The `swap` function attempts to swap the values of two mutable variables, but due to the way mutability is handled, the result is not what one might expect.

The `bug.fs` file contains the buggy code, and `bugSolution.fs` provides a corrected version. The issue stems from the fact that the mutable variables `x` and `y` are passed by reference, not by value, leading to unexpected results.

## How to Reproduce

1. Clone the repository.
2. Open `bug.fs` in an F# editor (e.g. Visual Studio, Ionide).
3. Compile and run the code. Observe the incorrect output.
4. Open `bugSolution.fs` to see how the issue can be fixed by avoiding mutable variables or using other suitable approaches.

## Solution

The solution demonstrates avoiding mutable variables which leads to more predictable results.