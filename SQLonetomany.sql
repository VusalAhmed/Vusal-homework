CREATE DATABASE DEPARTMENT
USE DEPARTMENT

CREATE TABLE Employees
(
ID INT Primary Key Identity,
Fullname nvarchar(40) CHECK(LEN(Fullname) > 2) NOT NULL,
Salary Money CHECK(Salary >= 0),
DepartmentID int references Departments(ID)
)

CREATE TABLE Departments
( 
ID INT Primary Key Identity,
Name nvarchar(20) CHECK(LEN(Name) > 2) NOT NULL
)