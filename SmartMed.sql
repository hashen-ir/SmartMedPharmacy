CREATE TABLE Admin(
    AdminID INT IDENTITY(1,1) PRIMARY KEY,
    Username VARCHAR(50),
    Password VARCHAR(100)
);

CREATE TABLE Customer(
    CustomerID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100),
    Email VARCHAR(100),
    Phone VARCHAR(20),
    Address VARCHAR(200),
    Username VARCHAR(50),
    Password VARCHAR(100)
);

CREATE TABLE Medicine(
    MedicineID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100),
    Category VARCHAR(50),
    Dosage VARCHAR(50),
    Price DECIMAL(10,2),
    Stock INT,
    Supplier VARCHAR(100),
    ExpiryDate DATE,
    Discount DECIMAL(5,2)
);

CREATE TABLE Orders(
    OrderID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerID INT,
    OrderDate DATETIME,
    TotalAmount DECIMAL(10,2),
    Status VARCHAR(50),
    FOREIGN KEY(CustomerID) REFERENCES Customer(CustomerID)
);

CREATE TABLE OrderDetails(
    DetailID INT IDENTITY(1,1) PRIMARY KEY,
    OrderID INT,
    MedicineID INT,
    Quantity INT,
    UnitPrice DECIMAL(10,2),

    FOREIGN KEY(OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY(MedicineID) REFERENCES Medicine(MedicineID)
);

CREATE TABLE Prescription(
    PrescriptionID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerID INT,
    FilePath VARCHAR(255),
    UploadDate DATETIME,

    FOREIGN KEY(CustomerID) REFERENCES Customer(CustomerID)
);

CREATE TABLE Cart
(
    CartID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerID INT NOT NULL,
    MedicineID INT NOT NULL,
    Quantity INT NOT NULL,

    CONSTRAINT FK_Cart_Customer
        FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID),

    CONSTRAINT FK_Cart_Medicine
        FOREIGN KEY (MedicineID) REFERENCES Medicine(MedicineID)
);
