# SQL_Carpenter

SQL Carpenter is a SQL Server instance client that allows you to perform basic DDL and DML operations.

- DDL: Create, modify and delete databases.
- DML: Insert, modify, and delete records.

## Basic Layers

- **UI (WinForms)** → Handles user interaction.
- **Logic** → Contains methods to execute SQL commands.
- **Data** → Manages the database connection.

## Code Organization

📂 `SQL_Carpenter` (Root Project)
 ├── 📁 `Data`
 |    ├── `ConnectionSettings.cs`: Singleton class, creates a single instance of the connection string. Subsequently the connector class assembles the connection string.
 |    ├── `DatabaseConnection.cs`: Abstract class, manages the opening and closing of the connection to the database, uses SqlClient data provider.    
 ├── 📁 `Forms` (UI - Windows Forms) 
 ├── 📁 `Managers`
 |    ├── `DatabaseManager.cs`: Facade class with static methods that access DDL services
 |    ├── `TableManager.cs`: Facade class with static methods that access DML services
 ├── 📁 `Services` *(Business logic and SQL execution)*
 |    ├── 📁 `DDL`: DDL services are here
 |    ├── 📁 `DML`: DML services are here
 ├── `Program.cs` *(Application entry point)*  
 ├── `App.config` *(Configurations)*  

