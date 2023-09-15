CREATE TABLE Orders
(OrderId int PRIMARY KEY IDENTITY(1,1), CustomerName varchar(25), Item varchar(25), Price money, Quantity int)

INSERT INTO Orders
(CustomerName, Item, Price, Quantity)
VALUES('Acme Hardware', 'Mouse', 25, 3)

INSERT INTO Orders
(CustomerName, Item, Price, Quantity)
VALUES('Acme Hardware', 'Keyboard', 45, 2)

INSERT INTO Orders
(CustomerName, Item, Price, Quantity)
VALUES('Falls Realty', 'Macbook', 800, 2)

INSERT INTO Orders
(CustomerName, Item, Price, Quantity)
VALUES('Julies Morning Diner', 'iPad', 525, 1)

INSERT INTO Orders
(CustomerName, Item, Price, Quantity)
VALUES('Julies Morning Diner', 'Credit Card Reader', 45, 1)

SELECT CustomerName, Item, Price,SUM(Quantity) AS TotalQuantity, SUM(Price* Quantity) as Total
FROM Orders 
WHERE CustomerName = 'Acme Hardware'
GROUP BY CustomerName, Item, Price

SELECT SUM(Price* Quantity) as GrandTotal
FROM Orders
WHERE CustomerName = 'Acme Hardware'

SELECT CustomerName, Item, Price,SUM(Quantity) AS TotalQuantity, SUM(Price* Quantity) as Total
FROM Orders 
WHERE CustomerName = 'Falls Realty'
GROUP BY CustomerName, Item, Price

SELECT SUM(Price* Quantity) as GrandTotal
FROM Orders
WHERE CustomerName = 'Falls Realty'

SELECT CustomerName, Item, Price,SUM(Quantity) AS TotalQuantity, SUM(Price* Quantity) as Total
FROM Orders 
WHERE CustomerName = 'Julies Morning Diner'
GROUP BY CustomerName, Item, Price

SELECT SUM(Price* Quantity) as GrandTotal
FROM Orders
WHERE CustomerName = 'Julies Morning Diner'

INSERT INTO Orders
(CustomerName)
VALUES( 'Joes Chicago Pizza')

SELECT TOP 10*
FROM Orders