CREATE TABLE [dbo].[Produto]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Nome] NVARCHAR(100) NOT NULL, 
    [Quantidade] INT NOT NULL, 
    [Preco] REAL NOT NULL, 
    [Texto] NVARCHAR(150) NULL, 
    [FlagAtiva] BIT NULL
)
