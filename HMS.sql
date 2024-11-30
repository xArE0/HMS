USE hostel__management_system;

SELECT * FROM Students;
SELECT * FROM  Rooms;
SELECT * FROM Employees;
SELECT * FROM Teachers;

drop table Rooms;
drop table Students;
drop table Employees;
drop table Teachers;

delete FROM Students;
delete FROM Employees;
delete FROM Teachers;
delete FROM Rooms;


-- Create Rooms table
CREATE TABLE Rooms(
    RoomNo INT PRIMARY KEY,
    BookedStatus INT
);

-- Create Students table
CREATE TABLE Students (
    StudentID INT PRIMARY KEY,
    Name VARCHAR(30) NOT NULL,
    Address VARCHAR(30) NOT NULL,
    FatherName VARCHAR(30),
    MotherName VARCHAR(30),
	RoomNo INT,
    Contact BIGINT NOT NULL,
    Status INT,
);

---- Create HostelIncharge table
--CREATE TABLE HostelIncharge (
--    InchargeID INT PRIMARY KEY
--);

-- Create Employees table
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    Name VARCHAR(30) NOT NULL,
    Address VARCHAR(30) NOT NULL,
    Contact BIGINT NOT NULL,
    Status INT,
);

-- Create Teachers table
CREATE TABLE Teachers (
    TeacherID INT PRIMARY KEY,
    Name VARCHAR(30) NOT NULL,
    Address VARCHAR(30) NOT NULL,
    Contact BIGINT NOT NULL,
    Position VARCHAR(30),
    Status INT
);

-- Insert values into Rooms table
INSERT INTO Rooms (RoomNo, BookedStatus)
VALUES
(101, 1),
(102, 1),
(103, 1),
(104, 1),
(105, 1),
(106, 0),
(107, 0),
(108, 0);



--Dummy Values

-- Insert values into Students table
INSERT INTO Students (StudentID, Name, Address, FatherName, MotherName, RoomNo, Contact, Status)
VALUES
(1, 'Sita Gurung', 'Kathmandu', 'Ram Gurung', 'Gita Gurung', 101, 9812345678, 1),
(2, 'Ramesh Sharma', 'Pokhara', 'Shyam Sharma', 'Sita Sharma', 102, 9845678901, 1),
(3, 'Anita Thapa', 'Biratnagar', 'Hari Thapa', 'Mina Thapa', 103, 9861234567, 1),
(4, 'Prakash Adhikari', 'Lalitpur', 'Nabin Adhikari', 'Saraswoti Adhikari', 104, 9809876543, 1),
(5, 'Nirmala Khadka', 'Butwal', 'Bishnu Khadka', 'Kalpana Khadka', 105, 9856789012, 1),
(6, 'Dilip Rai', 'Dharan', 'Raj Kumar Rai', 'Parvati Rai', 106, 9812345678, 0),
(7, 'Meera Shah', 'Bhaktapur', 'Hem Raj Shah', 'Ganga Shah', 107, 9845678901, 0),
(8, 'Rajan Shrestha', 'Nepalgunj', 'Shiva Shrestha', 'Laxmi Shrestha', 108, 9861234567, 0),
(9, 'Kumari Basnet', 'Janakpur', 'Narayan Basnet', 'Sita Basnet', 101, 9809876543, 0),
(10, 'Rajendra Lama', 'Hetauda', 'Bal Bahadur Lama', 'Saraswoti Lama', 102, 9856789012, 0);

-- Insert values into Employees table
INSERT INTO Employees (EmployeeID, Name, Address, Contact, Status)
VALUES
(1, 'Amit Sharma', 'Kathmandu', 9812345678, 1),
(2, 'Nisha Maharjan', 'Lalitpur', 9845678901, 1),
(3, 'Rajiv Thapa', 'Bhaktapur', 9861234567, 1),
(4, 'Anju Rai', 'Pokhara', 9809876543, 1),
(5, 'Santosh Khadka', 'Butwal', 9856789012, 1);

-- Insert values into Teachers table
INSERT INTO Teachers (TeacherID, Name, Address, Contact, Position, Status)
VALUES
(1, 'Aarati Joshi', 'Kathmandu', 9812345678, 'Math Teacher', 1),
(2, 'Bibek Subedi', 'Lalitpur', 9845678901, 'Science Teacher', 1),
(3, 'Nisha Tamang', 'Bhaktapur', 9861234567, 'English Teacher', 1),
(4, 'Prakash Shrestha', 'Pokhara', 9809876543, 'Computer Teacher', 1),
(5, 'Sunita Thapa', 'Butwal', 9856789012, 'Nepali Teacher', 1);
