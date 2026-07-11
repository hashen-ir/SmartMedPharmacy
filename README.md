# SmartMedPharmacy
Smart Med Pharmacy

# 🚀 Installation

## Requirements

- Visual Studio 2022
- .NET Framework
- SQL Server
- SQL Server Management Studio (SSMS)

---

## Steps

### 1. Clone the Repository

```
git clone <repository-url>
```

Or download the ZIP file.

---

### 2. Open the Project

Open

```
SmartMedPharmacy.sln
```

using Visual Studio.

---

### 3. Restore NuGet Packages

Restore the following packages if required:

- ClosedXML
- iTextSharp

---

### 4. Create Database

Open SQL Server Management Studio.

Create the database:

```
SmartMedPharmacyDB
```

Run the provided SQL script to create all tables.

---

### 5. Configure Connection String

Update the SQL connection string inside the project.

Example:

```csharp
string connectionString =
@"Data Source=YOUR_SERVER_NAME;
Initial Catalog=SmartMedPharmacyDB;
Integrated Security=True;
TrustServerCertificate=True";
```

---

### 6. Run the Project

Press

```
F5
```

or

```
Start Debugging
```

---
