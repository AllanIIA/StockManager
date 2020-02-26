CREATE TABLE [dbo].[Product] (
    [Identifier]                INT             IDENTITY (1, 1) NOT NULL,
    [Nom]                       NVARCHAR (50)   NULL,
    [Reference]                 NVARCHAR (50)   NULL,
    [Price]                     DECIMAL (18, 2) NULL,
    [Description]               NVARCHAR (3000) NULL,
    [IdentifierProductCategory] INT             NOT NULL,
    [StoredQuantity]            DECIMAL (18, 2) NULL,
    CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED ([Identifier] ASC),
    CONSTRAINT [FK_Product_ProductCategory] FOREIGN KEY ([IdentifierProductCategory]) REFERENCES [dbo].[ProductCategory] ([Identifier])
);



