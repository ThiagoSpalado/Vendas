CREATE TABLE [dbo].[CompraProduto] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [IdProduto]     INT           NOT NULL,
	[IdCliente]     INT           NOT NULL,
    [CodReferencia] NVARCHAR (50) NOT NULL,
    [Quantidade]    INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([IdProduto]) REFERENCES [dbo].[Produto] ([Id]),
	FOREIGN KEY ([IdCliente]) REFERENCES [dbo].[Cliente] ([Id])
);

