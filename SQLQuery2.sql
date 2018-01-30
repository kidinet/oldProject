CREATE TABLE [dbo].[Users] (
    [firstName]      VARCHAR (20) NULL,
    [lastName]       VARCHAR (20) NULL,
    [childFirstName] VARCHAR (20) NULL,
    [childLastName]  VARCHAR (20) NULL,
    [nickname]       VARCHAR (20) NULL,
    [profile_]       VARBINARY(MAX) NULL,
    [mail]           VARCHAR (100) NOT NULL,
    [password_]      VARCHAR (30) NULL,
    [city]           VARCHAR (20) NULL,
    [streat]         VARCHAR (20) NULL,
    [build]          INT          NULL,
	[latitute]       float		  NULL,
	[longitude]		 float		  NULL,
    PRIMARY KEY CLUSTERED ([mail] ASC)
);

CREATE TABLE [dbo].[Groups] (
    [id]     INT          IDENTITY (100, 2) NOT NULL,
    [name]   VARCHAR (30) NULL,
    [city]   VARCHAR (20) NULL,
    [streat] VARCHAR (20) NULL,
    [build]  INT          NULL,
    [phone]  VARCHAR (10) NULL,
    [mail]   VARCHAR (100) NULL,
    [fax]    VARCHAR (10) NULL,
    CONSTRAINT [id] PRIMARY KEY CLUSTERED ([id] ASC)
);
CREATE TABLE [dbo].[UserInGroup] (
    [userMail] VARCHAR (100) NOT NULL,
    [groupId]  INT          NOT NULL,
    [isAdministrator]    BIT          NOT NULL,
    PRIMARY KEY CLUSTERED ([userMail] ASC,[groupId] ASC),
    FOREIGN KEY ([userMail]) REFERENCES [dbo].[Users] ([mail]),
    FOREIGN KEY ([groupId]) REFERENCES [dbo].[Groups] ([id])
);
create table [AdministratorSettings]
(
[mail]   VARCHAR (100),
[chatStart] date,
[chatEnd] date, 
PRIMARY KEY CLUSTERED ([mail] ASC),
FOREIGN KEY ([mail]) REFERENCES [dbo].[Users] ([mail]),
)

create table imageGallery(
[id] int primary key identity(500,2),
[groupId]  INT          NOT NULL,
[date_added] date,
[src] VARBINARY(MAX),
[subject] varchar(30),
FOREIGN KEY ([groupId]) REFERENCES [dbo].[Groups] ([id])
)

create table responseImage
(
[imageId] int,
[date_added] date,
[text] varchar(255),
[userMail] VARCHAR (100) NOT NULL,
FOREIGN KEY ([userMail]) REFERENCES [dbo].[Users] ([mail]),
FOREIGN KEY ([imageId]) REFERENCES [dbo].[imageGallery] ([id]),
)

create table about(
[id] int primary key identity(400,2),
title varchar(30),
icon varchar(30),
color varchar(30)
)

create table formDilemma(
[id] int primary key identity(600,1),
[title] varchar(255),
[content] varchar(max),
date_added date,
)

create table formResponse(
[id] int primary key identity(700,1),
dilemmaId int,
[date_added] date,
FOREIGN KEY (dilemmaId) REFERENCES [dbo].formDilemma ([id]),
)

create table reminder(
[id] int primary key identity(800,1),
[userMail] VARCHAR (100) NOT NULL,
[groupId]  INT          NOT NULL,
[text] varchar(255),
[date] date,
[isRead] bit,
FOREIGN KEY ([userMail]) REFERENCES [dbo].[Users] ([mail]),
FOREIGN KEY ([groupId]) REFERENCES [dbo].[Groups] ([id])
)

create table topMessage(
[id] int primary key identity(900,1),
[text] varchar(255),
[date] date,
[groupId]  INT          NOT NULL,
FOREIGN KEY ([groupId]) REFERENCES [dbo].[Groups] ([id])
)

