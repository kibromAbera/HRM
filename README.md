# HRM - Clean Architecture Scaffold

This is a minimal scaffold for **HRM** (Human Resource Management) using:

- **Backend:** ASP.NET Core 8 (projects structured for Clean Architecture)
- **Database:** SQL Server (configured via `appsettings.json`)
- **Frontend:** Vite + React + TailwindCSS

This scaffold is intended as a starting point for development. It contains:
- HRM.Domain (entities)
- HRM.Application (DTOs, interfaces)
- HRM.Infrastructure (EF Core DbContext, repository)
- HRM.WebApi (ASP.NET Core Web API)
- HRM.ReactUI (Vite React + Tailwind frontend)

Notes:
- You will need .NET 8 SDK and Node.js installed to run the projects.
- To run the Web API: open `HRM.WebApi` in Visual Studio / `dotnet build` then `dotnet run`.
- Update the SQL Server connection string in `HRM.WebApi/appsettings.json`.
- To run the React frontend: `cd HRM.ReactUI` then `npm install` and `npm run dev`.

