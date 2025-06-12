# 🎫 Ticket Tracker API

The **Ticket Tracker API** is a lightweight internal support system built with **C# and ASP.NET Core 6**, designed to simulate real-world application support workflows. It allows users to create, retrieve, and resolve support tickets via a RESTful web API, and includes full database persistence using **Entity Framework Core** with a **SQLite** backend.

This project is inspired by the kinds of internal tools used by field services and IT support teams to streamline issue reporting and tracking.

---

## 💡 Features

- ✅ **Create, read, and resolve tickets** via RESTful endpoints
- ✅ Built with **.NET 6 Web API** and **Entity Framework Core**
- ✅ Exposes interactive API documentation via **Swagger UI**
- ✅ Automatically timestamps and tracks ticket statuses (`Open` or `Resolved`)
- ✅ Designed to mirror internal support workflows used in real enterprise environments

---

## 🛠 Technologies Used

- **C#**, **.NET 6**
- **Entity Framework Core** (code-first)
- **SQLite** (lightweight embedded database)
- **Swagger / OpenAPI** for live API exploration
- **RESTful design principles**
- **Dependency Injection** and service scoping best practices

---

## 📚 Why This Project

This API was built to demonstrate:
- Strong understanding of **backend web service development** using C#
- Experience with **relational data modeling and persistence**
- Familiarity with **API documentation standards** (Swagger/OpenAPI)
- Ability to design tools relevant to **support, field ops, or IT workflows**
- Readiness to contribute to **internal tools or application support platforms**

---

## 📁 Example Use Cases

- 🔧 IT departments can log and resolve technical support issues
- 🧑‍💼 Internal teams can track bug reports or feature requests
- 📊 Admin dashboards could consume the API for ticket analytics

---

> **Live API testing is available via Swagger UI** for all core endpoints.

## 🔧 How to Run the Project
```bash
git clone https://github.com/UzonnaA/TicketTracker
cd TicketTracker

# Build and Run
dotnet build
dotet run
```
You can then visit localhost:7220/swagger to use the ticket tracker.

