<<<<<<< HEAD
﻿CREATE TABLE [dbo].[LikeImages11111] (
    [ImageId]  INT           NOT NULL,
    [UserMail] VARCHAR (100) NOT NULL,
	[content] bit,
    PRIMARY KEY CLUSTERED ([ImageId] ASC, [UserMail] ASC),
    FOREIGN KEY ([ImageId]) REFERENCES [dbo].[imageGallery] ([id]),
    FOREIGN KEY ([UserMail]) REFERENCES [dbo].[Users] ([mail])
);
=======
﻿create table thisWeekTitle(
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
>>>>>>> 80086fcc5df8b4668ad26f755b2927e01d42c9c2
