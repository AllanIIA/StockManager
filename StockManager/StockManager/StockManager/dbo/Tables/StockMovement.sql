CREATE TABLE [dbo].[StockMovement] (
    [Identifier]   INT           IDENTITY (1, 1) NOT NULL,
    [Date]         DATE          NULL,
    [EmployeeCode] NVARCHAR (50) NULL,
    [IsStockEntry] BIT           NOT NULL,
    CONSTRAINT [PK_StockMovement] PRIMARY KEY CLUSTERED ([Identifier] ASC)
);

