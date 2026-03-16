# PortfolioFer API

This project is a backend API built with ASP.NET Core using a feature-based architecture.

The goal of this project is to demonstrate a clean and scalable backend structure following professional development practices.

## Technologies

- .NET 8
- ASP.NET Core Web API
- xUnit (Testing)
- Docker
- Swagger (OpenAPI)

## Solution Architecture

```
Solution
├── PortfolioFer
│   └── Features
│       └── HelloWorld
│           ├── Controllers
│           ├── Services
│           ├── Repositories
│           ├── Interfaces
│           └── Dtos
├── PortfolioFer.Tests
├── Database
└── Shared
```

## Running the project

Clone the repository:

```bash
git clone https://github.com/yourusername/yourrepository.git
```

Run the project:

```bash
dotnet run
```

Swagger will open automatically.

## First Endpoint

```
GET /api/v1/hello-world
```

Response:

```
Hello World
```

## Project Goals

This project demonstrates:

- Feature-based architecture
- Separation of concerns
- Clean project structure
- Scalable API design