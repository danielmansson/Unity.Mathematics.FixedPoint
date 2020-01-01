# Unity.Mathematics.FixedPoint

A Fixed-point extension of Unity's C# math library based on [FixedMath.Net](https://github.com/asik/FixedMath.Net) and [Unity.Mathematics](https://github.com/Unity-Technologies/Unity.Mathematics). One of the main reasons for using this library instead of the built-in one is support for cross-platform determinism, until Unity officially supports it with Burst/DOTS. 

The intention is to keep the API as close as possible to Unity.Mathematics. This should make it easy to convert your project to use floating point math if needed.

## Usage

You can use this library in your Unity game by adding this repository to the package manifest file in your Unity project. `PROJECT_ROOT/Packages/manifest.json`:

```json
{
  "dependencies": {
    "com.danielmansson.mathematics.fixedpoint": "https://github.com/danielmansson/Unity.Mathematics.FixedPoint.git"
  }
}
```

## Testing and developing

The easiest way to iterate on this package is to clone this repository and [the test project](https://github.com/danielmansson/Unity.Mathematics.FixedPoint.TestProject) side-by-side and open the test project in Unity. This resolves the required dependencies (Unity.Mathematics) and makes the test runner available.

## Missing features

Unity.Mathematics.FixedPoint is not feature complete yet. This is missing:

- quaternion
- fpmath.tanh
- fpmath.cosh
- fpmath.sinh
- fpmath.exp
- fpmath.log10

Method stubs are added to match the API, but they are marked as obsolete with a compile error.

## Maintaining changes from Unity.Mathematics

Unity.Mathematics is using code generation to create their vector and matrix types. Most of the changes in this repository from Unity.Mathematics has been in `VectorGenerator.cs` and `fpmath.cs`.

The plan is to keep this repository almost up to date with Unity.Mathematics, so changes has been isolated as much as possible. However, `VectorGenerator.cs` was not made with external extensibility in mind. When there are internal changes to Unity.Mathematics in upcoming versions, this will require manual patching.

`fpmath.cs` contains the common fixed point math operations. The implementations are based on the floating point methods in Unity.Mathematics `math.cs`.

## Precision

More tests are needed to verify the precision of all fixed point operations. There might be intermediate calculations unsuitable for fixed point in the current implementation.

## Licensing

This project is licensed under the MIT License ([LICENSE.md](LICENSE.md))

Unity.Mathematics ([Unity Companion License](https://github.com/Unity-Technologies/Unity.Mathematics/blob/master/LICENSE.md))

FixedMath.Net ([Apache License, Version 2.0](Unity.Mathematics.FixedPoint/fp/LICENSE.txt))

