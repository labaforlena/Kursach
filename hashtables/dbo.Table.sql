CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [login] NVARCHAR(50) NOT NULL, 
    [password] NVARCHAR(50) NOT NULL,
	[level] INT not null,
	[money] int null, 
    [attack] INT NULL, 
    [defence] INT NULL, 
    [itemsHeldId] INT NULL, 
    [itemsInBag] INT NULL
	
)
