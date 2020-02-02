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
