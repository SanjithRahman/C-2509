--sql lab 
--8-10-24


--use CompanyDB;


--create table Sales(
--	SaleID int primary key  identity(1,1),
--	ProductID INT,
--	ProductName varchar(255),
--	QuantitySold int,
--	SaleAmount decimal(10,2),
--	SaleDate date
--);


--insert into Sales (ProductID,ProductName,QuantitySold,SaleAmount,SaleDate)
--values 
--(101,'Laptop',5,500,'2024-09-01'),(102,'Mouse',10,250,'2024-09-02'),(103,'Keyboard',8,800,'2024-09-05'),(101,'Laptop',3,3000,'2024-09-03'),(102,'Mouse',6,150,'2024-09-05');

--select * from Sales;

--select SUM(SaleAmount)  AS SUM_SALES FROM SALES;


--SELECT MAX(QuantitySold) AS MAX_QUANTITY FROM SALES;

--SELECT MIN(SaleAmount) AS MIN_AMOUNT FROM SALES;

--SELECT SUM(QuantitySold)  AS QTY_SOLD  FROM SALES WHERE ProductName='Laptop'




--create table EmployeeSalary(
--	EmployeeID int primary key  identity(1,1),
--	EmployeeName varchar(255),
--	Department  varchar(20),
--	Salary decimal(10,2),
	
--	HireDate date
--);

--insert into EmployeeSalary (EmployeeName,Department,Salary,HireDate)
--VALUES 
--('John Doe','IT',5000,'2022-01-10'),('Jane Smith','HR',6000,'2021-03-15'),('Bob Johnson','Finance',5500,'2020-06-20'),('Alice Brown','IT',6200,'2023-02-01'),('Charlie White','Marketing',4800,'2023-03-10');

--select sum(Salary) as total_exp from EmployeeSalary;

--select max(Salary) as max_sal from  EmployeeSalary;
--select avg(Salary) as avg_sal from EmployeeSalary;
--select min(salary) AS MIN_SAL  from EmployeeSalary  where Department ='IT';
--select department ,count(*) as count_val   from  EmployeeSalary  group by Department;



--assignment 3:Inventory management


--create table Inventory(
--	ProductID int primary key  identity(201,1),
--	ProductName varchar(255),
--	QuantityInStock  int,
--	RecordLevel int,
	
--	 LastRestockDate date
--);

--INSERT INTO Inventory (ProductName,QuantityInStock,RecordLevel, LastRestockDate) 
--VALUES
--('Monitor',50,10,'2024-08-25'),('Printer',30,5,'2024-09-01'),('Mouse',100,15,'2024-09-10'),
--('Keyboard',80,20,'2024-09-15'),('Laptop',25,5,'2024-09-20');




--select * from Inventory ;

--SELECT SUM(QuantityInStock) AS TOTAL_STOCK FROM Inventory;


--SELECT ProductName FROM Inventory WHERE  QuantityInStocK=  ( SELECT MAX(QuantityInStocK)  FROM Inventory);

--SELECT AVG(RecordLevel)  AS AVG_RECORD FROM Inventory; 

--SELECT ProductName FROM Inventory WHERE RecordLevel=  ( SELECT MIN(RecordLevel)  FROM Inventory);

--SELECT SUM(QuantityInStock) AS total_quantity  FROM Inventory   WHERE QuantityInStock < RecordLevel;




--assignment 4;



--create table CustomerOrders(
--		OrderID int primary key  identity(501,1),
--	customerID varchar(20),
--	QuantityOrdered  int,
--	orderAmount decimal(10,2),
	
--	 orderDate date
--);


--INSERT INTO CustomerOrders(customerID, orderDate,orderAmount,QuantityOrdered)
--VALUES 
--('c001','2024-09-10',1500,3),('C002','2024-09-11',2000,5),('C001','2024-09-12',1000,2),('C003','2024-09-13',2500,4),('C002','2024-09-14',3000,6)



--select SUM(orderAmount) total_order_amt FROM  customerOrders;

--select AVG(orderAmount) as avg_order_amt  FROM  customerOrders;


--SELECT MAX(orderAmount)  as max_orders  from  customerOrders;

--select sum(QuantityOrdered) total_qty  from customerOrders;

--SELECT MIN(OrderAmount) AS Mini_order_amount  from  CustomerOrders;

--assignment 5:product rating 


--create table ProductRatings(
--		Ranking  int primary key  identity(1,1),
--	ProductID varchar(20),
--	CustomerID  varchar(20),
--	Rating   int ,
--	 reviewDate date
--);


--insert into ProductRatings (ProductID ,CustomerID,Rating, reviewDate)
--VALUES ('POO1','C001',4,'2024-09-01'),('POO2','C002',5,'2024-09-02'),('POO1','C003',3,'2024-09-03'),('POO3','C001',2,'2024-09-04'),('POO2','C004',4,'2024-09-05')


--SELECT * FROM ProductRatings;

--SELECT AVG(Rating),ProductID FROM ProductRatings GROUP BY ProductID;

--SELECT MAX(Rating) MAX_RATING FROM ProductRatings;

--SELECT MIN(Rating) MIN_RATING  FROM ProductRatings;

--SELECT COUNT(*) AS TOATAL_RATING,ProductID FROM  ProductRatings GROUP BY ProductID;

--SELECT COUNT(DISTINCT(ProductID)) AS RATED_PROD FROM  ProductRatingS;




--BETWEEN,LIKE,AND OR,NOT

--asigment-1
--SELECT * FROM Employee;
--select FirstName,LastName FROM Employee  where Department in ('hr','Finance','HR');

--assignment -2
--select * from Product;
--select ProductName from Product  where price  between  100  and 500;

--assignment-3
--select * from Customer;
--select * from Customer where  CustomerName like 'A%';

--assignment -4
--select  * from orders;
--select  OrderID from Orders where OrderDATE IN('2023-01-01','2023-02-01','2023-03-01');

--ASSIGNMENT -5;

--SELECT * FROM  PRODUCT;
--select ProductName FROM Product  where Price not between 100 and 500;






--09-10-24   alter commands
--sql lab
----assignment-1

--alter table Employee add DateOfBirth date;

--select * from Employee;

----assign 2

--select * from Customer;

--alter table Customer alter column PhoneNumbers varchar(15);

----assign 3





--create table Department (
--	departmentID int,
--	departmentName varchar(100)

--);

--alter table department aLter column departmentID int NOT NULL;

--alter table Department add constraint dp_prkeys   primary key(departmentID );
--select * FROM DEPARTMENT;

----aasig 4

--select * from Employee;
--alter table Employee add  middleName varchar(25);
--alter table employee drop column middleName;

----assign 5




--alter table Orders add EmployeeId int  constraint fk_emp_id foreign key (EmployeeId)
--references Employee(EmployeeId);

--select * from Orders;

----assign -6

--alter table orders drop  constraint fk_emp_id;

----assign -7


--EXEC sp_rename 'EmployeeSalary.EmployeeName','EmployeeFullName','COLUMN';
--select * from EmployeeSalary;

----ASIGN -8

--ALTER TABLE Employee add  status varchar(10) constraint df_val  default 'active ';


--SELECT * FROM EMPLOYEE;


----assign -9
--select * from department;

--alter table department  drop  dp_prkeys;

----assign 10
--alter table employee add email  varchar(30) constraint uq_email  UNIQUE(email);

----assign 11
--select * from Employee;
--alter table Employee add Constraint ck_salary check(salary > 1000); 

--insert into Employee (FirstName,LastName,Department,Salary,DATEOFBIRTH,EMAIL) VALUES
--('JOYAL','LALU','IT',500,'2002-05-05','SANJU@GMAIL');

----ASSIGN 12

--ALTER TABLE Employee  DROP ck_salary



--sql server subquries

--select * from EmployeeSalary;
----assignment 1
--select EmployeeFullName,Salary  from EmployeeSalary where salary > ( select avg(salary) from EmployeeSalary )

----assign 2


--select * from EmployeeSalary
--select department ,count(*) as dep_count  from  EmployeeSalary   group by department having count(*) > 5 ; 



----assignment 3


--select * from Product;

--select ProductName,price from product where price >=(select max(price) from product where category='Electronics');


----assignment 4

--select * from employee;
--alter table department add constraint pk_departmentid primary key (departmentid);

--alter table employee add departmentid  int  constraint fk_department_id  foreign key(departmentid)references department(departmentid);
--select * from Employee;

--insert into department (departmentid,departmentname) values (1,'it'),(2,'hr');

--insert into Employee (FirstName,LastName,Salary,DATEOFBIRTH,email,departmentid)  VALUES
--('JOYAL','LALU',50000,'2002-05-05','SANJU@GMAIL',1),('safwan','abdullah',60000,'2002-09-05','sag@ee',1),
--('krishnanad','m',40000,'2002-06-11','krish@12',9)




--select departmentid from employee group by departmentid having avg(salary) > 50000;

----assignment-5

--select FirstName,departmentid from employee e where salary > ( select avg(salary) from employee where departmentid=e.departmentid)


----assignment-6

--select * from customer;

--select * from orders;

--select CustomerName  from customer c where  c.customerid NOT IN ( SELECT CUSTOMERID FROM ORDERS );
----assignment-8


--select * from product;
--select * from  OrderDetails;

--select productname from product where productid not in ( select productid from orderdetails);











--sql joins 


----assignment 1
--select * from employee;
--select * from department;

--select e.firstname,e.lastname,d.departmentname from employee e inner join department d on e.departmentid=d.departmentid;


----assignment 2
--select e.firstname,e.lastname,d.departmentname from employee e left outer join  department d on e.departmentid=d.departmentid;


----assignment 3

--select e.firstname,e.lastname,d.departmentname from employee e right outer join  department d on e.departmentid=d.departmentid;


----assignment -4

--select e.firstname,e.lastname,d.departmentname from employee e full outer join department d on e.departmentid=d.departmentid;

----assignment 5
--select * from orders ;
--select *from Customer;



--select c.customername,o.orderid  from customer c inner join  orders o on c.CustomerID=o.customerid;

----assignment-6

--select c.customername,o.orderid  from customer c left outer join  orders o on c.CustomerID=o.customerid;

----assignment 7


--select * from productcategory;
--select * from producttable;

----create table productcategory(
----	categoryid varchar(20) primary key,
----	categoryname varchar(20)


----);

----create table producttable(

----	productid varchar(20) primary key,
----	productname varchar(20),
----	categoryid varchar(20),
----	foreign key(categoryid)references productcategory(categoryid )

----);










--select p.productname, c.categoryname from  productcategory c inner join producttable p on 

--p.categoryid=c.categoryid;


----assignment-8
----INSERT INTO productcategory (categoryid, categoryname) VALUES 
----('C05', 'Toys')

--select p.productname, c.categoryname from  productcategory c left outer  join producttable p on 

--p.categoryid=c.categoryid;


----assignment-9


--select * from Employee;


--select e1.FirstName as EmployeeName ,e2.FirstName as manager 
--from Employee e1 inner join employee e2 
--on e1.departmentid = e2.employeeid;


----assignment 10 

--select * from product;
--select * from orderdetails;
--select p.productid,p.productname,o.orderid from product p cross join  orderdetails o



----GROUP BY HAVING CAUSE 
----assin 1
--SELECT * FROM EMPLOYEE;
--SELECT * FROM DEPARTMENT;


--SELECT  d.departmentname,avg(e.salary) from Employee e inner join department d  on  e.departmentid= d.departmentid group by
--d.departmentname  having  avg(e.salary) > 50000;

----assign2
--SELECT  d.departmentname,count(*) as emp_count from Employee e inner join department d  on  e.departmentid= d.departmentid group by
--d.departmentname  having count(*) > 1;

----assign 3


--SELECT  d.departmentname,max(e.salary) as max_sal,min(e.salary) as min_sal from Employee e inner join department d  on  e.departmentid= d.departmentid group by
--d.departmentname  having min(salary)> 30000 ;


----assignment-4
--select *  from employee;
--select * from EmployeeSales;

--select e.firstname ,sum(s.amount) as total_sales from employee e inner join EmployeeSales s on
--e.employeeid=s.employeeid group by e.firstname;
----create table EmployeeSales(
----	SALESID  INT PRIMARY KEY IDENTITY(1,1),
----	Employeeid int,
----	amount decimal(10,2),



------);

------INSERT INTO  EmployeeSales (Employeeid, amount) VALUES (1, 25000),(9,6000),(10,5666),(12,444444);

------assign 5

--select * from customer;
--select * from orders;


--select  c.CustomerName  , count(*) as total_orders from customer c inner join 
--orders o on c.customerid=o.CustomerId group by c.CustomerName ;