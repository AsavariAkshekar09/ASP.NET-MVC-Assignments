create database HotelManagementSystem

create table GuestDetails
(
	GuestID int Primary Key, 
	GuestName nvarchar(255) NOT NULL,
	PhoneNumber decimal(10,0),
	Company	int,
	Email nvarchar(255),
	Gender varchar(50),
	GuestAddress nvarchar(255),
	RoomID	int
)

create table RoomDetails
(
	RoomID int PRIMARY KEY,
	ReservationID int,
	CheckIn datetime,
	CheckOut datetime,
	[Period] int,
)

create table Reservation
(
	ReservationID int PRIMARY KEY,
	Children int,
	Adults int,
	[Status] nvarchar(10),
	NumberOfNights int,
	GuestID int 
)

create table StaffDetails
(
	StaffID int PRIMARY KEY,
	DepartmentID int,
	StaffName varchar(255),
	StaffAddress nvarchar(255),
	Occupation varchar(255),
	Email nvarchar(255),
	Age int,
	Salary decimal(10,2),
	NIC decimal(16,0)
)

create table Department
(
	DepartmentID int PRIMARY KEY,
	DepartmentName varchar(255),
	ManagerID int,
	ManagerName varchar(255)
)


create table [Services]
(
	ServiceID int Primary Key,
	RoomID int,
	ServiceName varchar(50),
	ServicePrice decimal(10,0)
)

create table Rates
(
	RateID int Primary Key,
	FirstNightPrice decimal(10,2),
	ExtensionPrice decimal(10,2)
)

create table Bill 
(
	BillID int PRIMARY KEY,
	GuestID int,
	Taxes decimal(10,2),
	IssueDate datetime,
	ServiceID int,
	Unit int,
	Price decimal(10,2),
	CreditCardDetails decimal(16,0),
	Paytime datetime
)