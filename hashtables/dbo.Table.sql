CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [login] NCHAR(10) NOT NULL, 
    [password] NCHAR(10) NOT NULL, 
    [hp] INT NOT NULL DEFAULT 1, 
    [attack] INT NOT NULL DEFAULT 1, 
    [def] INT NOT NULL DEFAULT 1, 
    [money] INT NULL DEFAULT 10, 
    [itemsInHand] NVARCHAR(50) NULL DEFAULT 0, 
    [itemsInBag] NVARCHAR(50) NULL DEFAULT 0)