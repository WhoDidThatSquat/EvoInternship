CREATE TABLE [dbo].[Order] (
    [id]          INT          IDENTITY (1, 1) NOT NULL,
    [customerId] INT          NOT NULL,
    [totalPrice]  MONEY        NULL,
    [date]        DATE         NULL,
    [status]      VARCHAR (50) NULL,
    CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Order_Customer] FOREIGN KEY ([customerId]) REFERENCES [dbo].[Customer] ([id])
);

