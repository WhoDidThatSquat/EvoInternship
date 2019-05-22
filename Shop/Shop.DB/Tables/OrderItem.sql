CREATE TABLE [dbo].[OrderItem] (
    [orderId]   INT   NOT NULL,
    [productId] INT   NOT NULL,
    [quantity]  INT   NOT NULL,
    [price]     MONEY NOT NULL,
    CONSTRAINT [PK_OrderItem] PRIMARY KEY CLUSTERED ([orderId] ASC, [productId] ASC),
    CONSTRAINT [FK_OrderItem_Product] FOREIGN KEY ([productId]) REFERENCES [dbo].[Product] ([id]),
    CONSTRAINT [FK_OrderItems_Order] FOREIGN KEY ([orderId]) REFERENCES [dbo].[Order] ([id])
);



