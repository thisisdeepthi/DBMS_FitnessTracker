create database FT;
use FT;

-- Table user
create table user(
UserID int primary key,
Name varchar(50),
DOB date,
Gender varchar(10),
Height decimal(5,2),
Weight decimal(5,2),
Category varchar(50),
PhoneNo varchar(12),
Email varchar(50),
ActivityDuration varchar(50),
CaloriesBurnt decimal(5,2),
Carbo decimal(5,2),
Protein decimal(5,2),
Vitamin decimal(5,2),
Fat decimal(5,2),
CalorieIntake decimal(5,2),
junkFreq int,
junkFreqDur varchar(15)
);

-- Table ActivityMaster
create table ActivityMaster
(
ActivityID int primary key,
ActivityName varchar(50),
CaloriesPerMin decimal(5,2)
);

-- -Table MustDo

Create table MustDo
(
 UserID int,
ActivityID int,
Constraint foreign1 foreign key(userid) references user(userid),
Constraint foreign2 foreign key(ActivityID) references ActivityMaster(activityID),
Constraint pkey primary key(userID,ActivityID)

);



-- Table ActivityChart
create table ActivityChart
(
LogNo int primary key,
Adate date,
AID int ,
Duration time,
Type varchar(10),
CaloriesBurnt decimal(5,2),
UserID int,
Remark varchar(20),
Constraint fk1 foreign key (AID) references ActivityMaster(ActivityID),
Constraint fk2 foreign key(UserID)  references User(userId)
);







-- Table DietMaster
create table DietMaster(
DietId int primary key,
DietName varchar(30),
Carbo decimal(5,2),
Protein decimal(5,2),
Vitamin decimal(5,2),
Fat decimal(5,2),
CaloriesPerS decimal(5,2),
isJunk int
);

-- Table DietChart
create table DietChart(
Logno int primary key,
dietDate date,
noOfServings int,
Userid int ,
DietId int,
Carbo decimal(5,2),
Protein decimal(5,2),
Vitamin decimal(5,2),
Fat decimal(5,2),
CaloriesIntake decimal(5,2),
Remark varchar(20),
Constraint fkey1 foreign key(UserId)  references user(userId),
Constraint fkey2  foreign key(dietId) references DietMaster(DietId)
);




 
