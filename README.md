## Framework 4.6.1 and Standard 2.0

### Framework 4.6.1

```bash
# Build
msbuild Framework461/MyLibrary/MyLibrary.fsproj

# Not supported on mono
nuget pack Framework461/MyLibrary/MyLibrary.fsproj -OutputDirectory ~/.local-nuget -IncludeReferencedProjects -Prop Configuration=Release

# Pack
nuget pack Framework461/MyLibrary/MyLibrary.nuspec -OutputDirectory ~/.local-nuget -Prop Configuration=Debug -Prop Id=MyLibrary
```

### Standard 2.0

```
# Build 
dotnet build Standard20/MyApp/MyApp.fsproj

# Create NuGet config (Not working on mono)
nuget config -ConfigFile NuGet.config

# Add package reference
dotnet add Standard20/MyApp/MyApp.fsproj package MyLibrary

# Restore package
dotnet restore Standard20/MyApp/MyApp.fsproj

# Run
dotnet run --project Standard20/MyApp/MyApp.fsproj
```