# WebSocket Chat

![Language](https://img.shields.io/badge/Language-C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![Framework](https://img.shields.io/badge/Framework-ASP.NET%20Core%209-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)

A real-time chat application using ASP.NET Core SignalR.

## Features
- Real-time messaging with SignalR
- Persistent messages stored in SQL Server
- Vanilla JS frontend served as static files

## Tech Stack
| Technology | Description |
|---|---|
| C# / ASP.NET Core 9 | Backend Framework |
| SignalR | Real-time communication |
| EF Core 9 | ORM |
| SQL Server | Database |
| HTML/JS | Frontend |

## Getting Started

1. Clone the repository:
   ```bash
   git clone https://github.com/OmarAlfar0uk/WebSocket.git
   ```
2. Restore dependencies:
   ```bash
   dotnet restore
   ```
3. Update the database:
   ```bash
   dotnet ef database update
   ```
4. Run the application:
   ```bash
   dotnet run
   ```

## Project Structure
- `Contexts/ChatDbContext.cs`: Entity Framework database context
- `Hubs/ChatHub.cs`: SignalR hub for the `/chat` endpoint
- `Models/Message.cs`: Database message model
- `Migrations/`: EF Core database migrations
- `wwwroot/`: Static files including `Index.html` and `Chat.js`

## Author
- GitHub: [OmarAlfar0uk](https://github.com/OmarAlfar0uk)
- LinkedIn: [omar-alfarouk-252471251](https://www.linkedin.com/in/omar-alfarouk-252471251/)
- Email: omaralfarouk646@gmail.com
