CREATE VIEW [dbo].[ViewDetalhe]
		AS SELECT     dbo.Produto.Nome AS Produto, dbo.Produto.Texto, dbo.CompraProduto.Quantidade, dbo.Produto.Preco, dbo.Compra.CodReferencia
FROM         dbo.CompraProduto INNER JOIN
             dbo.Produto ON dbo.Produto.Id = dbo.CompraProduto.IdProduto INNER JOIN
             dbo.Compra ON dbo.Compra.CodReferencia = dbo.CompraProduto.CodReferencia