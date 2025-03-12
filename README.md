# SQL_Carpenter

## 1️ Basic Layers
- **UI (WinForms)** → Handles user interaction.
- **Logic (Services/Managers)** → Contains methods to execute SQL commands.
- **Data (SQL Connection Helper)** → Manages the database connection.

---

## 2️ Code Organization
📂 `SQLSmith` (Root Project)  
 ├── 📁 `Forms` *(App windows)*  
 │   ├── `MainForm.cs` *(Main screen with buttons for DDL and DML operations)*  
 │   ├── `DatabaseForm.cs` *(Form for creating/deleting databases)*  
 │   ├── `QueryForm.cs` *(Later, for DML operations)*  
 │  
 ├── 📁 `Services` *(Business logic and SQL execution)*  
 │   ├── `DatabaseService.cs` *(Will contain `CreateDatabase()` and `DropDatabase()` using `SqlCommand`)*  
 │  
 ├── 📁 `Data` *(Connection handling and configurations)*  
 │   ├── `DatabaseConnection.cs` *(Class to manage the connection to SQL Server)*  
 │  
 ├── `Program.cs` *(Application entry point)*  
 ├── `App.config` *(Configurations like the connection string, if you decide to place it here)*  

---

## 3️ Workflow
1. The user interacts with the buttons in `DatabaseForm`.
2. `DatabaseForm` calls `DatabaseService` to execute SQL.
3. `DatabaseService` uses `DatabaseConnection` to connect and execute `SqlCommand`.
