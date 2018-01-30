create table thisWeekTitle(
id int primary key identity (1000,1),
[date] date,
groupId int, 
FOREIGN KEY ([groupId]) REFERENCES [dbo].[Groups] ([id])
)
create table imageInThisWeekTitle(
id int primary key identity (1000,1),
thisWeekTitleId int,
src VARBINARY(MAX),
FOREIGN KEY (thisWeekTitleId) REFERENCES [dbo].thisWeekTitle ([id])
)

create table chatItem(
id int primary key identity (1100,1),
userMail   VARCHAR (100)   NOT NULL,
[date] date,
[text] varchar(max),
FOREIGN KEY (userMail) REFERENCES [dbo].Users ([mail])
)