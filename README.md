# SimpleDispatch Shared Models

This package contains shared Entity Framework entities and DTOs for SimpleDispatch applications.

## Installation

```bash
dotnet add package SimpleDispatch.SharedModels
```

## Usage

### Entity Framework Entities

The package includes entities that are ready to use with Entity Framework:

```csharp
using SimpleDispatch.SharedModels.Entities;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Unit> Units { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
}
```

### DTOs

The package also includes DTOs for API communication:

```csharp
using SimpleDispatch.SharedModels.Dtos;

// Use DTOs in your controllers
public ActionResult<Event> GetEvent(int id)
{
    // Your logic here
}
```

## Available Entities

- `Unit` - Represents dispatch units (vehicles, personnel, etc.)

## Available DTOs

- `Event` - Event information with location and type
- `Unit` - Unit information for API responses
- `Coordinate` - Geographic coordinates (latitude/longitude)

## TypeScript Generation

This package can also generate TypeScript interfaces. See the `tools/` folder for the TypeScript generation utility.

## Building the Package

To build and pack the NuGet package:

```bash
dotnet pack
```

To generate TypeScript interfaces:

```bash
npm run build
```

## License

[Your License Here]
