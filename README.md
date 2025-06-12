# Ticket Tracker API

Quick project to simulate how internal support tickets are created and resolved — mainly to get hands-on practice with C# Web APIs, data persistence, and basic workflow logic.

I built this to better understand how internal tools (like those used in field services or IT departments) manage issue tracking. It gave me a chance to work with .NET, set up a database with EF Core, and wire up endpoints with Swagger for easy testing.

---

## Features

- Create, fetch, and resolve support tickets through a RESTful API
- Tracks timestamps and status (open or resolved)
- Swagger UI for testing endpoints without needing a frontend
- Lightweight and focused — just enough to mimic a real workflow

---

## Technologies

- .NET 6 (C#)
- Entity Framework Core
- SQLite
- Swagger / OpenAPI

---

## Why I Built This

I wanted something simple but useful to showcase backend API development using C# (especially something that lines up with real-world app support roles). While building it, I focused on:
- Modeling ticket data using EF Core
- Setting up clean API routes with controllers
- Practicing service registration, dependency injection, and scoping
- Using Swagger as an easy way to interact with and debug the API

---

## Potential Use Cases

- Could serve as a backend for an internal IT helpdesk
- Useful for admin tools or dashboards that track issue progress
- Extendable into a full CRUD app with authentication or role-based access

---

> You can test the API live using the built-in Swagger UI.


## 🔧 How to Run the Project
```bash
# Download the project
git clone https://github.com/UzonnaA/TicketTracker
cd TicketTracker

# Build and run
dotnet build
dotnet run
```
You can then visit [localhost:7220/swagger](https://localhost:7220/swagger) to use the ticket tracker.


