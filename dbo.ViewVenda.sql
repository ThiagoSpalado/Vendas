CREATE VIEW [dbo].[ViewVenda]
	AS SELECT        dbo.Compra.Id, dbo.Cliente.Nome AS cliente, dbo.Compra.Data, dbo.Compra.Total, 
					 dbo.Compra.[Status], dbo.Compra.IdCliente
FROM            dbo.Cliente INNER JOIN
                         dbo.Compra ON dbo.Cliente.Id = dbo.Compra.IdCliente