# Introduction

This is a template help bootstrap a dotnetcore 3 based algorithmic experiment. Including unit tests and a benchmark option

## Using the Template

### Template installation

To install the template :

- Clone the project locally
- In the root folder run

```sh
dotnet new -i .\
```

After running that, you now have access to a template with a short new of `algorithm.DotNetCore3`

### Template usage

Once installed you can now create a new project based on the template.

Navigate to a folder where you want to create the project in.

```sh
dotnet new algorithm.DotNetCore3 -en {experiment name}
```

for example

```sh
dotnet new algorithm.DotNetCore3 -en SumOfTwoIntegers
```

This will create a solution and library project for you, including unit test and a console to benchmark your experiment

### How to use the benchmarking console

The console app uses ![BenchmarkDotNet](https://github.com/dotnet/BenchmarkDotNet) for benchmarking experiments.

To use the console app you need to build in Release mode then run the console from the build output folder.

If you don't build in Release mode BenchmarkDotNet will throw exceptions.

for example, I have a project called `SumOfTwoIntegers`

You'll get the console here

```sh
SumOfTwoIntegers\Src\SumOfTwoIntegers.Console\bin\Release\netcoreapp3.1\SumOfTwoIntegers.exe
```
