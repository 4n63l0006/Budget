USE CarRepairDB;
Go

Create Table Users(
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Username Varchar(50) NOT NULL UNIQUE,
    Password Varchar(50) NOT NULL
);

INSERT INTO Users (Username, Password)
VALUES ('admin', '12345');

select * from Users;

