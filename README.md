# Task Management Application (CRUDOperation)

## 1. Overview

This project is a Task Management Web Application developed using ASP.NET Core MVC (.NET 8) and Entity Framework Core (Code First Approach).

The application allows users to:

- Create Tasks
- View Task List
- View Task Details
- Update Tasks
- Delete Tasks
- Search Tasks by Title

This project demonstrates proper implementation of MVC architecture, database integration, CRUD operations, and documentation as required in the assignment.

---

## 2. Objectives Covered

The following assignment objectives are implemented:

- ✔ Create – Add new tasks
- ✔ Read – View task list and details
- ✔ Update – Edit existing tasks
- ✔ Delete – Remove tasks
- ✔ Search – Search tasks by title

---

## 3. Technology Stack

- ASP.NET Core MVC (.NET 8)
- Entity Framework Core
- SQL Server
- Razor Views
- Bootstrap (UI styling)

---

## 4. Architecture

This project follows the MVC (Model-View-Controller) pattern:

- **Models** → Contains entity classes and DbContext
- **Views** → Razor UI pages
- **Controllers** → Handles application logic
- **Migrations** → Database version control
- **wwwroot** → Static files (CSS, JS)

---

## 5. Database Design

### 5.1 Entity: TaskItem

| Column Name        | Data Type      | Description |
|-------------------|---------------|-------------|
| Id                | int (PK)      | Primary Key |
| TaskTitle         | string        | Title of task |
| TaskDescription   | string        | Task description |
| TaskDueDate       | DateTime      | Due date |
| TaskStatus        | string        | Status (Pending, Completed) |
| TaskRemarks       | string?       | Optional remarks |
| CreatedOn         | DateTime      | Creation timestamp |
| LastUpdatedOn     | DateTime?     | Last update timestamp |
| CreatedByName     | string        | Name of creator |
| CreatedById       | int           | Creator ID |
| LastUpdatedByName | string?       | Name of last updater |
| LastUpdatedById   | int?          | Last updater ID |

---

## 6. ER Diagram (Logical Representation)

TaskItem
---------
Id (Primary Key)
TaskTitle
TaskDescription
TaskDueDate
TaskStatus
TaskRemarks
CreatedOn
LastUpdatedOn
CreatedByName
CreatedById
LastUpdatedByName
LastUpdatedById

This project currently contains a single entity (TaskItem).

---

## 7. Indexes Used

- Primary Key Index on `Id`
- Search optimization can be improved by adding an index on `TaskTitle`

Example:

```csharp
modelBuilder.Entity<TaskItem>()
    .HasIndex(t => t.TaskTitle);
8. Development Approach
Code First Approach Used

Reason:

Database automatically generated using migrations

Easy to modify entity structure

Suitable for rapid development

Clean separation between model and database

Database is created using:

dotnet ef migrations add InitialCreate
dotnet ef database update
9. Build and Installation
Prerequisites

.NET 8 SDK

SQL Server

Visual Studio or VS Code

Steps to Run

Clone or download the project

Navigate to the project directory:

cd CrudOperaation

Restore dependencies:

dotnet restore

Apply migrations:

dotnet ef database update

Run the application:

dotnet run

Open browser and navigate to:

https://localhost:xxxx
10. Features Implemented

✔ MVC Architecture

✔ CRUD Operations

✔ Search Functionality

✔ Entity Framework Core

✔ Code First Migration

✔ SQL Server Integration

✔ Bootstrap UI

11. Project Structure
CrudOperaation
│
├── Controllers/
│     └── TasksController.cs
│
├── Models/
│     ├── TaskItem.cs
│     └── AppDbContext.cs
│
├── Views/
│     ├── Tasks/
│     │     ├── Index.cshtml
│     │     ├── Create.cshtml
│     │     ├── Edit.cshtml
│     │     ├── Delete.cshtml
│     │     └── Details.cshtml
│     └── Shared/
│
├── Migrations/
├── wwwroot/
├── appsettings.json
└── Program.cs
12. Future Enhancements

Authentication & Authorization

Role-based access

Pagination

Dashboard

Task priority

REST API integration

13. Conclusion

This project successfully fulfills all assignment requirements including MVC implementation, CRUD operations, search functionality, database design, and documentation.

It demonstrates understanding of backend development, database management, and structured application design.
