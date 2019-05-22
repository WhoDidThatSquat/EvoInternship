CREATE TABLE [dbo].[Customer] (
    [id]               INT          IDENTITY (1, 1) NOT NULL,
    [name]             VARCHAR (50) NULL,
    [surname]          VARCHAR (50) NULL,
    [address]          VARCHAR (50) NULL,
    [phone]            NCHAR (10)   NULL,
    [email]            VARCHAR (50) NULL,
    [registrationDate] DATETIME     CONSTRAINT [DF_Customer_registrationDate] DEFAULT (getdate()) NULL,
    CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([id] ASC)
);

