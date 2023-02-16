select * from tblStudent


create table tblProduct(
id int primary key identity(1,1),
Name varchar(40),
Mobile varchar(20),
Email varchar(40),
City varchar(40),
Gender varchar(10),
Price numeric(10,2),
IsActive int
)

select * from tblProduct

create table tblDept(
deptid int primary key identity(1,1),
deptname varchar(10))

select * from tblDept
select * from tblEmployee

alter table tblEmployee add deptid int
