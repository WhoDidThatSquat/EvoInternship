CREATE TABLE [dbo].[User] (
    [id]       INT          IDENTITY (1, 1) NOT NULL,
    [username] VARCHAR (50) NOT NULL,
    [password] VARCHAR (50) NOT NULL,
    [role]     VARCHAR (50) CONSTRAINT [DF_User_role] DEFAULT (N'Customer') NOT NULL,
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_User_Customer] FOREIGN KEY ([id]) REFERENCES [dbo].[Customer] ([id])
);

