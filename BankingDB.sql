CREATE DATABASE BankingDB;
GO

USE BankingDB;

CREATE TABLE Transactions (
    Id INT PRIMARY KEY IDENTITY,
    Description NVARCHAR(100) NOT NULL,
    Amount DECIMAL(18, 2) NOT NULL CHECK (Amount > 0),
    Date DATETIME NOT NULL
);

INSERT INTO Transactions (Description, Amount, Date)
VALUES ('Initial Deposit', 1000.00, GETDATE());