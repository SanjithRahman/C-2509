











--create database CompanyDB;

--use CompanyDB;



--create table Employee(

--	EmployeeID  int not null primary key identity(1,1),
--	FirstName varchar(50),
--	LastName varchar(50),
--	Department varchar(50),
--	Salary decimal(10,2),

--);	

----assignment-2

--insert into Employee (FirstName,LastName,Department,Salary)
--VALUES 
--('John','Doe','hr',50000),('Jane','Smith','IT',60000),('David','Lee','Marketing',55000);

----assignment:3

--select * from Employee;

--select FirstName,LastName,Salary from Employee where Department='it' AND SALARY>5000;


--SELECT MAX(SALARY)  AS MAXSALARY  FROM Employee;


----ASSIGNMENT-4

--UPDATE Employee set Salary=55000 where FirstName='John' and LastName='Doe';
--select * from Employee;


--UPDATE Employee set Department ='Marketing' where FirstName='Jane' and LastName='Smith';
--select * from Employee;

----ASSIGNMENNT 5

--DELETE FROM Employee where FirstName='David' and LastName='Lee';
--select * from Employee;
--Delete  FROM Employee WHERE Department = 'Marketing';

--select * from Employee;


--assignmennt 6 products 



--create table Product(

--	ProductID  int not null primary key identity(1,1),
--	ProductName varchar(50),
--	Category varchar(50),
--	Price  decimal(10,2),
--	Stock decimal(10,2),

--);	

--insert into PRODUCT  (ProductName,Category,Price,Stock)  VALUES ('LAPTOP','Electronics',1000,50),('Mouse','Electronics',20,200),('Keyboard','Electronics',30,150),('Printers','ELECTRONICS',150,75);

--select * from Product order by price desc;

--UPDATE Product SET Price=25 where ProductName ='Mouse';

--select * from product;


--DELETE FROM Product WHERE ProductId=14;

--select * from Product order by ProductName;


--Assignment 7 Library


--create table Books(

--	BookID  int not null primary key identity(1,1),
--	Title varchar(50),
--	Author varchar(50),
--	PublishedYear  INT,
--	AvailableCopies  decimal(10,2),

--);	

--INSERT INTO Books (Title,Author,PublishedYear,AvailableCopies) 

--VALUES ('The Great Gatsby','F. Scott Fitzgerald',1925,3),('1984','George Orwell',1949,2),('To Kill a Mockingbird','Harper Lee',1960,5),('Brave New World','Aldous Huxley',1932,4);



--UPDATE BOOKS SET AvailableCopies=5 where Title='1984';

--DELETE FROM BOOKS WHERE BOOKID=1;
--select title from Books where  PublishedYear >1950;

--SELECT * FROM Books;

----assignment 8

--create table Customer(

--	CustomerID  int not null primary key identity(201,1),
--	CustomerName varchar(50),
--	Email varchar(50),
--	PhoneNumbers   varchar(15),
--);	

--INSERT INTO  Customer(CustomerName ,Email,PhoneNumbers) 
--VALUES ('Alice Johnson','alice@example.com','555-1234'),('Bob Smith','bob@example.com','555-5678'),('Charlie Brown','charlie@example.com','555-8765');

--INSERT INTO  Customer(CustomerName ,Email,PhoneNumbers)  VALUES ('David Wilson','david@example.com','555-4321');

--UPDATE  Customer SET PhoneNumbers = '555-9999' WHERE CustomerName='Alice Johnson';

--SELECT * FROM Customer;

--DELETE FROM Customer WHERE CustomerID=202;

--SELECT * FROM Customer;




--create table Orders(

--	OrderID  int not null primary key identity(301,1),
--	CustomerId  int not null ,
--	OrderDate date,
--	TotalAmount   decimal(10,2),
--);	

--INSERT INTO Orders (CustomerId,OrderDate,TotalAmount) values (201,'2024-09-01',250),(202,'2024-09-02',150),(203,'2024-09-03',200),(204,'2024-09-03',200);

--UPDATE Orders set TotalAmount=275 where OrderID=301;

--DELETE from Orders where  OrderID=302;

--select * from Orders where TotalAmount > 200;
--select OrderID,TotalAmount from Orders;


--assignment 10


--create table Students(

--	StudentID  int not null primary key identity(1,1),
--	FirstName  varchar(200) ,
--	LastName  varchar(200) ,Email  varchar(200) ,
	
--);	

--insert into Students (FirstName,LastName,Email)
--VALUES ('John', 'Doe', 'john.doe@example.com'),
--( 'Jane', 'Smith', 'jane.smith@example.com'),( 'Mike', 'Johnson', 'mike.johnson@example.com');


--CREATE TABLE Courses(
--CourseID int primary key identity(1,1),
--CourseName VARCHAR(225),
--StartDate DATE,

--);
--TRUNCATE TABLE Students;

--SELECT * FROM STUDENTS;

--CREATE TABLE Enrollments(
--		EnrollmentsID int primary key  identity(1,1),
--		StudentID int,
--		CourseID int,
--		FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
--		FOREIGN KEY (CourseID) REFERENCES Courses(CourseID),

		
--);

--SELECT * FROM Courses;
--SELECT * FROM STUDENTS;
--SELECT * FROM Enrollments;

--insert into Students (FirstName,LastName,Email)
--VALUES ('John', 'Doe', 'john.doe@example.com'),
--( 'Jane', 'Smith', 'jane.smith@example.com'),( 'Mike', 'Johnson', 'mike.johnson@example.com');



--insert into Courses(CourseName,StartDate)
--VALUES ('Introduction to programminng ', '2025-10-14'),
--( 'c fundamental','2024-09-10'),( 'java fundamnetal','2023-10-20');



--SELECT * FROM Courses;
--SELECT * FROM STUDENTS;
--SELECT * FROM Enrollments;

--insert into Enrollments(StudentID,CourseID)
--values (1,1),(2,3);



--SELECT * FROM Courses;
--SELECT * FROM STUDENTS;
--SELECT * FROM Enrollments;


--assignment 12

--create table OrderDetails(OrderID INT,ProductID INT,Quantity Decimal(10,2) PRIMARY KEY(OrderID ,ProductID));

--SIGNMENT 13

--CREATE TABLE Users(
--	UserID INT PRIMARY KEY,
--	Email VARCHAR(100) UNIQUE,
--	Username VARCHAR(50),
--	Mobile VARCHAR(15),

--);

--assignment 17

--CREATE VIEW EmployeeView 
--AS
--SELECT FirstName,LastName,Department 
--FROM Employee;


--select * from EmployeeView;

----assignment 18
--CREATE VIEW EditableEmployeeView 
--AS
--SELECT FirstName,LastName,Salary 
--FROM Employee;

--select * from EditableEmployeeView;

--UPDATE EditableEmployeeView set Salary=60000 where FirstName='John' and LastName='Doe';
--select * from EditableEmployeeView  where FirstName='John' and LastName='Doe';


----assignment19

--CREATE VIEW EmployeeSalaryBonus
--AS
--SELECT FirstName,LastName,Salary,Salary*0.10 as Bonus 

--FROM Employee;
--select * from EmployeeSalaryBonus;


----assignment 20;
--Alter view EmployeeView
--AS
--SELECT FirstName,LastName,Salary ,Department
--FROM Employee;


--select * from  EmployeeView;

----assignment 21
--Create view FilteredEmployee

--as
--SELECT FirstName,LastName,Department

--from Employee;

--select * from  FilteredEmployee where department='hr';

----assignment 22

--Drop view EmployeeView;
--select * from EmployeeView;

--aggregate functions



