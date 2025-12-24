[![.NET](https://github.com/aimenux/OpenApiGenerationDemo/actions/workflows/ci.yml/badge.svg)](https://github.com/aimenux/OpenApiGenerationDemo/actions/workflows/ci.yml)

# OpenApiGenerationDemo
```
Generating open api specification at build time and run time
```

In this repo, i m adding the [support for generating oas at build time and run time](https://devblogs.microsoft.com/dotnet/dotnet9-openapi/).
>
> :one: ControllerApi : oas generation in a controller api style.
>
> :two: MinimalApi : oas generation in a minimal api style.
>
> 🚨 **Note**: The oas generation is done using the [Microsoft.Extensions.ApiDescription.Server](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/openapi/aspnetcore-openapi?view=aspnetcore-9.0&tabs=visual-studio%2Cvisual-studio-code#generate-openapi-documents-at-build-time).
> 
> Run `dotnet build -c release` to generate the oas directory and files.

**`Tools`** : net 10.0, oas
