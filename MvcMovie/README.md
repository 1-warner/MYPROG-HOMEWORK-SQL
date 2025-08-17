# MvcMovie - ASP.NET Core MVC Web Application

This is an ASP.NET Core Web App using the Model-View-Controller (MVC) pattern with MySQL database integration.

## Project Details

- **Name**: MvcMovie
- **Target Framework**: .NET 9.0
- **Database**: MySQL
- **Pattern**: MVC (Model-View-Controller)

## Features

- Movie CRUD operations (Create, Read, Update, Delete)
- Search functionality by movie title
- Data validation with client and server-side validation
- Responsive Bootstrap UI
- Entity Framework Core with MySQL

## Prerequisites

1. **.NET 9.0 SDK** - Download and install from [Microsoft](https://dotnet.microsoft.com/download/dotnet/9.0)
2. **MySQL Server** - Install MySQL Server 8.0 or later
3. **MySQL Workbench** (optional) - For database management

## Setup Instructions

### 1. Database Setup

1. Install MySQL Server if not already installed
2. Create a new database:
   ```sql
   CREATE DATABASE MvcMovie;
   ```
3. Create a MySQL user (optional):
   ```sql
   CREATE USER 'mvcuser'@'localhost' IDENTIFIED BY 'yourpassword';
   GRANT ALL PRIVILEGES ON MvcMovie.* TO 'mvcuser'@'localhost';
   FLUSH PRIVILEGES;
   ```

### 2. Connection String Configuration

Update the connection string in `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "MvcMovieContext": "Server=localhost;Database=MvcMovie;User=root;Password=yourpassword;"
  }
}
```

Replace `yourpassword` with your actual MySQL root password or the password for the user you created.

### 3. Install Dependencies

Navigate to the MvcMovie directory and restore packages:

```bash
cd MvcMovie
dotnet restore
```

### 4. Create Database and Run Migrations

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

### 5. Run the Application

```bash
dotnet run
```

The application will be available at `https://localhost:5001` or `http://localhost:5000`.

## Project Structure

```
MvcMovie/
├── Controllers/          # Controller classes
│   ├── HomeController.cs
│   └── MoviesController.cs
├── Data/                 # Data access layer
│   └── MvcMovieContext.cs
├── Models/               # Data models
│   ├── Movie.cs
│   └── ErrorViewModel.cs
├── Views/                # Razor views
│   ├── Home/
│   ├── Movies/
│   └── Shared/
├── wwwroot/              # Static files
│   ├── css/
│   └── js/
├── Program.cs            # Application entry point
├── appsettings.json      # Configuration
└── MvcMovie.csproj      # Project file
```

## Usage

1. **Home Page**: Navigate to the home page to see the welcome message
2. **Movies**: Click on "Movies" in the navigation to view the movie list
3. **Search**: Use the search box to filter movies by title
4. **CRUD Operations**:
   - **Create**: Click "Create New" to add a new movie
   - **Read**: Click "Details" to view movie information
   - **Update**: Click "Edit" to modify movie details
   - **Delete**: Click "Delete" to remove a movie

## Validation

The application includes both client-side and server-side validation:

- **Title**: Required, 3-60 characters
- **Release Date**: Required, valid date format
- **Genre**: Required, max 30 characters
- **Price**: Required, range $1-$100

## Troubleshooting

### Common Issues

1. **Database Connection Error**: Ensure MySQL is running and the connection string is correct
2. **Migration Errors**: Delete the Migrations folder and recreate migrations if needed
3. **Port Conflicts**: Change the port in `Properties/launchSettings.json` if needed

### Getting Help

- Check the console output for error messages
- Verify MySQL service is running
- Ensure database credentials are correct
- Check firewall settings if connecting to remote MySQL server

## Technologies Used

- ASP.NET Core 9.0
- Entity Framework Core
- MySQL Database
- Bootstrap 5
- jQuery Validation
- Razor Views
