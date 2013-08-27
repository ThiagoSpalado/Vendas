CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Nome] NVARCHAR(100) NOT NULL, 
    [Endereco] NVARCHAR(100) NULL, 
    [Bairro] NVARCHAR(50) NULL, 
    [Estado] NVARCHAR(50) NULL, 
    [Cep] NVARCHAR(50) NULL, 
    [Telefone] NVARCHAR(50) NULL, 
    [Telefone2] NVARCHAR(50) NULL, 
    [Email] NVARCHAR(100) NULL, 
    [PCM] NVARCHAR(100) NULL, 
    [Observacao] NVARCHAR(150) NULL, 
    [FlagAtiva] BIT NULL, 
    [FlagInadiplente] BIT NULL
)
