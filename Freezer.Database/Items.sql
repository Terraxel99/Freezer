CREATE TABLE [dbo].[Items]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [TypeId] UNIQUEIDENTIFIER NOT NULL, 
    [FreezerId] UNIQUEIDENTIFIER NOT NULL, 
    [ExpirationDate] DATETIME NULL, 
    [Quantity] INT NOT NULL DEFAULT 1, 
    [AmountOfPeople] INT NULL,
    [DrawerNumber] INT NULL, 

    FOREIGN KEY (TypeId) REFERENCES ItemTypes(Id),
    FOREIGN KEY (FreezerId) REFERENCES Freezers(Id),
)
