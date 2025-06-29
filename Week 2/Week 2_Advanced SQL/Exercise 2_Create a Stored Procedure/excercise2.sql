-- Define the stored procedure with a parameter for DepartmentID. 
CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(100)
);

CREATE TABLE Employees (
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT FOREIGN KEY REFERENCES Departments(DepartmentID),
    Salary DECIMAL(10,2),
    JoinDate DATE
);

-- Insert sample department data
INSERT INTO Departments (DepartmentID, DepartmentName) VALUES
(1, 'HR'),
(2, 'Finance'),
(3, 'IT'),
(4, 'Marketing');
-- 1. Create procedure to get employees by department

DROP PROCEDURE sp_GetEmployeesByDepartment;

CREATE PROCEDURE sp_GetEmployeesByDepartment
    @DepartmentID INT
AS
BEGIN
    SELECT 
        EmployeeID,
        FirstName,
        LastName,
        DepartmentID,
        Salary,
        JoinDate
    FROM Employees
    WHERE DepartmentID = @DepartmentID;
END;

-- 2. Execute it to fetch department 2
EXEC sp_GetEmployeesByDepartment @DepartmentID = 3;

-- 3. Create procedure to insert a new employee
CREATE PROCEDURE sp_InsertEmployee 
    @FirstName VARCHAR(50), 
    @LastName VARCHAR(50), 
    @DepartmentID INT, 
    @Salary DECIMAL(10,2), 
    @JoinDate DATE 
AS 
BEGIN 
    INSERT INTO Employees (FirstName, LastName, DepartmentID, Salary, JoinDate) 
    VALUES (@FirstName, @LastName, @DepartmentID, @Salary, @JoinDate); 
END;

-- 4. Insert an employee using the new procedure
EXEC sp_InsertEmployee 
    @FirstName = 'Souptik', 
    @LastName = 'Karan', 
    @DepartmentID = 2, 
    @Salary = 7500.00, 
    @JoinDate = '2025-06-29';

EXEC sp_InsertEmployee 
    @FirstName = 'Aditi', 
    @LastName = 'Roy', 
    @DepartmentID = 3, 
    @Salary = 6900.00, 
    @JoinDate = '2025-06-29';
