CREATE TABLE [dbo].[Category] (
    [id]          INT          IDENTITY (1, 1) NOT NULL,
    [name]        VARCHAR (50) NULL,
    [description] VARCHAR (50) NULL,
    [parentId] INT          NULL,
    CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Category_Category] FOREIGN KEY ([parentId]) REFERENCES [dbo].[Category] ([id])
);

