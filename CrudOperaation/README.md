# CrudOperaation

A simple ASP.NET Core MVC application for performing CRUD (Create, Read, Update, Delete) operations on Task items.

## Features
- Create, view, edit, and delete tasks
- Entity Framework Core for data access
- MVC architecture
- Bootstrap for basic styling

## Project Structure
- **Controllers/**: Contains MVC controllers (HomeController, TasksController)
- **Models/**: Entity and DbContext classes
- **Views/**: Razor views for UI
- **Migrations/**: Entity Framework Core migrations
- **wwwroot/**: Static files (CSS, JS, libraries)

## Getting Started

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- SQL Server (or change connection string for another provider)

### Setup
1. Clone the repository or download the source code.
2. Navigate to the project directory:
   ```sh
   cd CrudOperaation
   ```
3. Restore dependencies:
   ```sh
   dotnet restore
   ```
4. Apply database migrations:
   ```sh
   dotnet ef database update
   ```
5. Run the application:
   ```sh
   dotnet run
   ```
6. Open your browser and go to `https://localhost:5001` or the URL shown in the terminal.

## Usage
- Navigate to the Tasks section to manage your tasks.
- Use the navigation bar to access different pages.

## Folder Overview
- `Controllers/` - Application controllers
- `Models/` - Data models and DbContext
- `Views/` - Razor views for UI
- `Migrations/` - Database migrations
- `wwwroot/` - Static assets

## License
This project is licensed under the MIT License.
