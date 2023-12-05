


CREATE TABLE EMPLOYEE
(

  ID varchar(50) primary key,
  EmployeeName varchar(50) NOT NULL,
  [Address] varchar(50) NOT NULL,
  Email varchar(50) NOT NULL,
   [Date] varchar(50) NOT NULL,
    Contact varchar(50) NOT NULL,

)


CREATE TABLE Salary
(
  EmployeeID varchar(50),
  SalaryAmount decimal(10, 2) NOT NULL,
  PaymentDate date NOT NULL,
  PRIMARY KEY (EmployeeID, PaymentDate),
  FOREIGN KEY (EmployeeID) REFERENCES EMPLOYEE(ID)
);

SELECT EMPLOYEE.ID, EmployeeName, SalaryAmount
FROM EMPLOYEE
INNER JOIN Salary ON EMPLOYEE.ID = Salary.EmployeeID;
-- Create a physical table VIEWSALARY
SELECT E.ID AS EmployeeID, E.EmployeeName, S.SalaryAmount, S.PaymentDate
INTO VIEWSALARY
FROM EMPLOYEE E
INNER JOIN Salary S ON E.ID = S.EmployeeID;

SELECT * FROM VIEWSALARY;


DROP TABLE Salary

-- Alter table to disallow null values for specified columns
ALTER TABLE EMPLOYEE

ALTER COLUMN EmployeeName NVARCHAR(MAX) NOT NULL;

ALTER TABLE EMPLOYEE
ALTER COLUMN [Address] NVARCHAR(MAX) NOT NULL;

ALTER TABLE EMPLOYEE
ALTER COLUMN Email NVARCHAR(MAX) NOT NULL;

ALTER TABLE EMPLOYEE
ALTER COLUMN [Date] NVARCHAR(MAX) NOT NULL;

ALTER TABLE EMPLOYEE
ALTER COLUMN Contact NVARCHAR(MAX) NOT NULL;
