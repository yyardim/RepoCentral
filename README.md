# RepoCentral

RepoCentral is a financial application designed to handle repo transactions. The application follows Clean Architecture principles and implements the CQRS pattern using MediatR. It is composed of a .NET Core Web API backend and a separate React front-end for user interaction.

## Table of Contents
- [Technologies](#technologies)
- [Architecture](#architecture)
- [Folder Structure](#folder-structure)
- [Getting Started](#getting-started)
- [Running the Project](#running-the-project)
- [React Front-End](#react-front-end)
- [CQRS with MediatR](#cqrs-with-mediatr)
- [XML Processing](#xml-processing)
- [Testing](#testing)
  
---

## Technologies

- *.NET Core 8.0* - Backend framework
- *React* - Front-end framework
- *SQL Server* - Database
- *Entity Framework Core* - ORM for database access
- *MediatR* - For implementing CQRS pattern
- *Mapster - Object-to-object mapping
- *FluentValidation* - Validation for commands
- *Carter - Elegant Routing for ASP.NET Core*
- *Bogus* - Fake data generation
- *Swagger* - API documentation- 
- *Moq* & *xUnit* - Unit testing

---

## Architecture

This solution follows *Clean Architecture* with the following layers:
1. *Core Layer* - Defines behaviors, exception & base classes for CQRS.
2. *API Layer* - ASP.NET Core Web API exposing RESTful endpoints.
3. *Application Layer* - Implements CQRS with Commands, Queries, DTOs, and Handlers.
4. *Domain Layer* - Contains core business logic (Entities, Value Objects, etc.).
5. *Infrastructure Layer* - Data access (repositories), XML processing, external services.
6. *Client Layer* - React-based front-end application.

---

## Folder Structure
*client* - Contains the React front-end application
*src* - Contains the .NET Core Web API
  *Api* - Contains the Web API project
	*Controllers* - Contains the API controllers
	*DTOs* - Contains Data Transfer Objects
	*Extensions* - Contains extension methods
	*Filters* - Contains exception filters
	*Handlers* - Contains MediatR handlers
	*Models* - Contains domain models
	*Services* - Contains services
  *Application* - Contains the application layer
	*Commands* - Contains CQRS commands
	*Queries* - Contains CQRS queries
	*DTOs* - Contains Data Transfer Objects
	*Handlers* - Contains MediatR handlers
  *Core* - Contains the core layer
	*Entities* - Contains domain entities
	*Exceptions* - Contains custom exceptions
	*Interfaces* - Contains interfaces
  *Domain* - Contains the domain layer
	*Entities* - Contains domain entities
	*ValueObjects* - Contains value objects
  *Infrastructure* - Contains the infrastructure layer
	*Data* - Contains data access (repositories)
	*Services* - Contains external services
	*XMLProcessing* - Contains XML processing service
*Tests* - Contains unit tests
  *Application* - Contains application layer tests
  *Core* - Contains core layer tests
  *Infrastructure* - Contains infrastructure layer tests
  *Models* - Contains domain model tests
  *Services* - Contains service tests
*RepoCentral.sln* - Solution file

---

## Getting Started

### Prerequisites
- *.NET Core 8.0 SDK* installed
- *SQL Server* running
- *Visual Studio 2019* or *Visual Studio Code* (for the .NET Core Web API)
- *Postman* or *Swagger* for API testing
- *Git* installed
- *Docker* installed (for running API in a container)
- *Node.js* and *npm* installed (for the React front-end)

### Setup

1. *Clone the repository:*
   ```bash
   git clone https://github.com/yourusername/RepoCentral.git

2. *Navigate to the project directory*
   ```bash
   cd RepoCentral/src

3. *Set up the database: Update the connection string in appsettings.json in the Api project*

4. *Run database migrations (if any):*
   ```bash
   dotnet ef database update

### Running the Project

1. *Start the .NET Web API:*
   ```bash
   cd src/Api/RepoCentral.Api
   dotnet run

2. *Start the React front-end*
   ```bash
   cd src/Client/RepoCentral.ReactApp
   npm install
   npm start

### Endpoints

- *GET /api/repo/{id}* - Get a specific repo by ID
- *POST /api/repo* - Create a new repo

### React Front-End
*The front-end is built with React and is placed in the /Client/RepoCentral.ReactApp folder. It interacts with the RepoCentral API using RESTful endpoints

*Features:*
- View repo headers and details in a grid
- Edit repo headers and collateral details
- Column customization (show/hide, reorder)

### CQRS with MediatR

This project uses CQRS with MediatR to separate commands (write operations) and queries (read operations).

#Example:#
- *Command*: Creating a repo (CreateRepoCommand)
- *Query*: Fetching a repo by ID (GetRepoByIdQuery)

### XML Processing

The XML Processing service processes files from a network location and parses them into XML format.

### Testing

This project incudes unit tests using xUnit and Moq for mocking dependencies while Bogus handles data generation.