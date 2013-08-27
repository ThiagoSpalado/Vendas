CREATE TABLE [dbo].[Produto] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [Nome]       NVARCHAR (100) NOT NULL,
    [Quantidade] INT            NOT NULL,
    [Preco]      NVARCHAR (10)  NOT NULL,
    [Texto]      NVARCHAR (150) NULL,
    [FlagAtiva]  BIT            NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

