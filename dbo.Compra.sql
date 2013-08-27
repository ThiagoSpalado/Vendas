CREATE TABLE [dbo].[Compra] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [IdCliente]     INT           NOT NULL,
    [Data]          NVARCHAR (30) NULL,
    [Total]         NVARCHAR (15) NOT NULL,
    [CodReferencia] NVARCHAR (50) NOT NULL,
    [Status]        NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([IdCliente]) REFERENCES [dbo].[Cliente] ([Id])
);

