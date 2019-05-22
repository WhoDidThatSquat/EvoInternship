CREATE TABLE [dbo].[Product] (
    [id]          INT          IDENTITY (1, 1) NOT NULL,
    [categoryId]  INT          NOT NULL,
    [name]        VARCHAR (50) NOT NULL,
    [description] VARCHAR (50) NULL,
    [price]       MONEY        NOT NULL,
    [brand]       VARCHAR (50) NULL,
    [model]       VARCHAR (50) NULL,
    CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Product_Product] FOREIGN KEY ([categoryId]) REFERENCES [dbo].[Category] ([id])
);

