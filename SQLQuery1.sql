CREATE TABLE [dbo].[LikeImages11111] (
    [ImageId]  INT           NOT NULL,
    [UserMail] VARCHAR (100) NOT NULL,
	[content] bit,
    PRIMARY KEY CLUSTERED ([ImageId] ASC, [UserMail] ASC),
    FOREIGN KEY ([ImageId]) REFERENCES [dbo].[imageGallery] ([id]),
    FOREIGN KEY ([UserMail]) REFERENCES [dbo].[Users] ([mail])
);