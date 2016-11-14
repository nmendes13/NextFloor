CREATE TABLE [dbo].[User]
(
	[IdUser] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(50) NOT NULL, 
    [Email] VARCHAR(100) NOT NULL, 
    [Password] VARCHAR(50) NOT NULL 
)
