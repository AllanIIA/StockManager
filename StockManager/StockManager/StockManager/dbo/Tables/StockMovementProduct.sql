CREATE TABLE [dbo].[StockMovementProduct] (
    [Identifier]              INT             IDENTITY (1, 1) NOT NULL,
    [IdentifierProduct]       INT             NULL,
    [IdentifierStockMovement] INT             NULL,
    [Quantity]                DECIMAL (18, 2) NULL,
    CONSTRAINT [PK_StockMovementProduct] PRIMARY KEY CLUSTERED ([Identifier] ASC),
    CONSTRAINT [FK_StockMovementProduct_Product] FOREIGN KEY ([IdentifierProduct]) REFERENCES [dbo].[Product] ([Identifier]),
    CONSTRAINT [FK_StockMovementProduct_StockMovement] FOREIGN KEY ([IdentifierStockMovement]) REFERENCES [dbo].[StockMovement] ([Identifier])
);



