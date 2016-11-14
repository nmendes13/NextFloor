CREATE TABLE [dbo].[Building]
(
	[BuidingID] INT NOT NULL PRIMARY KEY, 
    [Name] NCHAR(10) NULL, 
    [StreetName] NCHAR(10) NULL, 
    [City] NCHAR(10) NULL, 
    [PostCode] NCHAR(10) NULL, 
    [HouseNumber] NCHAR(10) NULL, 
    [State] NCHAR(10) NULL, 
    [CountryID] INT NULL, 
    [Floor] NCHAR(10) NULL
)
