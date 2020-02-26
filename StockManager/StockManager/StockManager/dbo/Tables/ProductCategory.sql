CREATE TABLE [dbo].[ProductCategory] (
    [Identifier] INT           IDENTITY (1, 1) NOT NULL,
    [Label]      NVARCHAR (50) NULL,
    CONSTRAINT [PK_ProductCategory] PRIMARY KEY CLUSTERED ([Identifier] ASC)
);

