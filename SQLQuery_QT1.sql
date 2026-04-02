
CREATE DATABASE SmartTicketingDB;
GO

USE SmartTicketingDB;
GO


CREATE TABLE Routes (
    RouteID INT IDENTITY(1,1) PRIMARY KEY,
    RouteName NVARCHAR(100),
    Price INT
);


CREATE TABLE Tickets (
    TicketID INT IDENTITY(1,1) PRIMARY KEY,
    RouteID INT FOREIGN KEY REFERENCES Routes(RouteID),
    IssueDate DATETIME,
    PaymentMethod NVARCHAR(50),
    Status NVARCHAR(50)
);


INSERT INTO Routes (RouteName, Price) VALUES 
(N'Bến Thành - Suối Tiên', 15000),
(N'Bến Thành - An Phú', 12000),
(N'Bến Thành - Thảo Điền', 10000);
