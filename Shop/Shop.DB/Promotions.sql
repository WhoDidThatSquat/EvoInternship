CREATE TABLE [dbo].[Promotions] (
    [ID]          INT        IDENTITY (1, 1) NOT NULL,
    [IDPromotion] INT        NOT NULL,
    [StartDate]   DATE       NULL,
    [EndDate]     DATE       NULL,
    [Discount]    FLOAT (53) NULL
);

