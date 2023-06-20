CREATE TABLE [dbo].[Inventory]
(
    [Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [Name] VARCHAR(50) NOT NULL, 
    [Price] MONEY NOT NULL, 
    [Quantity] INT NOT NULL, 
    [AddedOn] DATE NOT NULL DEFAULT GETDATE()
)

