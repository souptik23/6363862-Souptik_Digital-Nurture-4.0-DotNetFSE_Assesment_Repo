CREATE DATABASE DOTNETFSE;
USE DOTNETFSE;

CREATE TABLE Gadgets(
    GadgetID INT PRIMARY KEY,
    GadgetName NVARCHAR(100),
    Brand NVARCHAR(50),
    Price DECIMAL(10, 2)
);

INSERT INTO Gadgets (GadgetID, GadgetName, Brand, Price) VALUES
(1, 'Galaxy S21', 'Samsung', 75000),
(2, 'Galaxy Buds', 'Samsung', 8000),
(3, 'Galaxy Watch', 'Samsung', 20000),
(4, 'iPhone 14', 'Apple', 85000),
(5, 'AirPods Pro', 'Apple', 20000),
(6, 'MacBook Air', 'Apple', 120000),
(7, 'Mi 11X', 'Xiaomi', 30000),
(8, 'Redmi Note 10', 'Xiaomi', 15000),
(9, 'Mi Band 6', 'Xiaomi', 3000),
(10, 'iPad', 'Apple', 60000);


SELECT * FROM GADGETS;

-- . Use ROW_NUMBER() to assign a unique rank within each category --

SELECT *
FROM (
    SELECT 
        GadgetID, GadgetName, Brand, Price,
        ROW_NUMBER() OVER (PARTITION BY Brand ORDER BY Price DESC) AS RowNum
    FROM Gadgets
) AS Ranked
WHERE RowNum <= 3;


-- Use RANK() and DENSE_RANK() to compare how ties are handled

SELECT *
FROM (
    SELECT 
        GadgetID, GadgetName, Brand, Price,
        RANK() OVER (PARTITION BY Brand ORDER BY Price DESC) AS RankNum,
        DENSE_RANK() OVER (PARTITION BY Brand ORDER BY Price DESC) AS DenseRankNum
    FROM Gadgets
) AS Ranked
WHERE RankNum <= 3;


--Use PARTITION BY Category and ORDER BY Price DESC

SELECT 
    GadgetID, 
    GadgetName, 
    Brand, 
    Price,
    RANK() OVER (PARTITION BY Brand ORDER BY Price DESC) AS RankInBrand
FROM Gadgets;



